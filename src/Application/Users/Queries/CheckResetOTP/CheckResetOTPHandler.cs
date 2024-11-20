//using MediatR;
//using FlexBook.Application.Common.Exceptions;
//using FlexBook.Application.Common.Helpers;
//using FlexBook.Application.Common.Interfaces;
//using FlexBook.Application.Common.Models;
//using FlexBook.Application.Users.Commands.SignUpCommand;

//namespace FlexBook.Application.Users.Queries.CheckResetOTP;
//public class CheckResetOTPHandler : IRequestHandler<CheckResetOTPQuery, TResponse<string>>
//{
//    public ICacheService _cacheService { get; set; }
//    private readonly IResourceService _resourceService;


//    public CheckResetOTPHandler(ICacheService cacheService, IResourceService resourceService)
//    {
//        _cacheService = cacheService;
//        _resourceService = resourceService;
//    }
//    public async Task<TResponse<string>> Handle(CheckResetOTPQuery request, CancellationToken cancellationToken)
//    {
//        int.TryParse(_cacheService.GetAsync<string>(CachePrefix.LockForgetPassowrd, request.email, cancellationToken), out int lockCount);
//        if (lockCount < 3)
//        {
//            var otp = _cacheService.GetAsync<OTPSettings>(CachePrefix.ForgetPassowrd, request.email, cancellationToken);
//            if (string.IsNullOrEmpty(request.otp) || otp.OTPValue != request.otp)
//            {
//                 lockCount +=1;
//                _cacheService.AddAsync(CachePrefix.LockForgetPassowrd, request.email, 2, lockCount.ToString());
//                throw new BussinessValidationException(_resourceService.GetError("WrongOTP"));
//            }
//            else
//            {
//                _cacheService.Delete(CachePrefix.LockForgetPassowrd, request.email);
//                return TResponse<string>.Success(_resourceService.GetInfo("NowYouCanRestPassword"));
//            }
//        }
//        {
//            return TResponse<string>.Failure(new[] { _resourceService.GetError("YouAreLocked") });

//        }
//    }
//}
using MediatR;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Users.Commands.SignUpCommand;

namespace FlexBook.Application.Users.Queries.CheckResetOTP;

public class CheckResetOTPHandler : IRequestHandler<CheckResetOTPQuery, TResponse<string>>
{
    public ICacheService _cacheService { get; set; }
    private readonly IResourceService _resourceService;

    public CheckResetOTPHandler(ICacheService cacheService, IResourceService resourceService)
    {
        _cacheService = cacheService;
        _resourceService = resourceService;
    }

    public async Task<TResponse<string>> Handle(CheckResetOTPQuery request, CancellationToken cancellationToken)
    {
        try
        {
            // Retrieve lock count
            var lockCountStr =  _cacheService.GetAsync<string>(CachePrefix.LockForgetPassowrd, request.email, cancellationToken);
            int.TryParse(lockCountStr, out int lockCount);

            if (lockCount >= 3)
            {
                // Return failure if the account is locked
                return TResponse<string>.Failure(
                    new[] { _resourceService.GetError("YouAreLocked") },
                    "Too many failed attempts. Account locked.",
                    403);
            }

            // Retrieve OTP
            var otp =  _cacheService.GetAsync<OTPSettings>(CachePrefix.ForgetPassowrd, request.email, cancellationToken);

            if (otp == null || string.IsNullOrEmpty(request.otp) || otp.OTPValue != request.otp)
            {
                // Increment lock count and update cache
                lockCount += 1;
                 _cacheService.AddAsync(CachePrefix.LockForgetPassowrd, request.email, 2, lockCount.ToString());

                return TResponse<string>.Failure(
                    new[] { _resourceService.GetError("WrongOTP") },
                    _resourceService.GetError("WrongOTP"),
                    400);
            }

            // OTP is valid, reset lock and allow password reset
             _cacheService.Delete(CachePrefix.LockForgetPassowrd, request.email);

            //return TResponse<string>.Success(
            //    _resourceService.GetMessage("NowYouCanRestPassword"),
            //    _resourceService.GetInfo("NowYouCanRestPassword"));


            // Return success response
            return TResponse<string>.Success(
                _resourceService.GetMessage("NowYouCanRestPassword"),
                 _resourceService.GetMessage("NowYouCanRestPassword"),
                200);







        }
        catch (Exception ex)
        {
            // Handle unexpected exceptions
            return TResponse<string>.Failure(
                new[] { "An unexpected error occurred." },
                ex.Message,
                500);
        }
    }
}
