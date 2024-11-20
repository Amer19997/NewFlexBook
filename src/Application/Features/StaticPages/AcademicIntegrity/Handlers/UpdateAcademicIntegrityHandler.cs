using System.ComponentModel.Design;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Repositories;
using MediatR;
using IResourceService = FlexBook.Application.Common.Interfaces.IResourceService;

namespace FlexBook.Application.Features.StaticPages.AcademicIntegrity.Handlers
{
    public class UpdateAcademicIntegrityHandler : IRequestHandler<UpdateAcademicIntegrityCommand, TResponse<AcademicIntegrityDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileUploadService _fileUploadService;
        private readonly IResourceService _resourceService;

        public UpdateAcademicIntegrityHandler(IUnitOfWork unitOfWork, IFileUploadService fileUploadService, IResourceService resourceService)
        {
            _unitOfWork = unitOfWork;
            _fileUploadService = fileUploadService;
            _resourceService = resourceService;

        }

        public async Task<TResponse<AcademicIntegrityDto>> Handle(UpdateAcademicIntegrityCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var academicIntegrity = await _unitOfWork.AcademicIntegrityrRepository.FindById(request.Id, cancellationToken);
                if (academicIntegrity == null)
                    return TResponse<AcademicIntegrityDto>.Failure(new[] { "Academic Integrity entry not found" }, "Not Found", 404);

                academicIntegrity.TitleAr = request.TitleAr;
                academicIntegrity.TitleEn = request.TitleEn;
                academicIntegrity.DescriptionAr = request.DescriptionAr;
                academicIntegrity.DescriptionEn = request.DescriptionEn;
                academicIntegrity.HeaderTitleAr = request.HeaderTitleAr;
                academicIntegrity.HeaderTitleEn = request.HeaderTitleEn;
                academicIntegrity.HeaderDescriptionAr = request.HeaderDescriptionAr;
                academicIntegrity.HeaderDescriptionEn = request.HeaderDescriptionEn;

                if (request.Image != null)
                    academicIntegrity.ImageUrl = await _fileUploadService.UploadFileAsync(request.Image);

                _unitOfWork.AcademicIntegrityrRepository.Update(academicIntegrity);
                await _unitOfWork.CommitAsync(cancellationToken);

                var dto = new AcademicIntegrityDto
                {
                    Id = academicIntegrity.Id,
                    TitleAr = academicIntegrity.TitleAr,
                    TitleEn = academicIntegrity.TitleEn,
                    DescriptionAr = academicIntegrity.DescriptionAr,
                    DescriptionEn = academicIntegrity.DescriptionEn,
                    HeaderTitleAr = academicIntegrity.HeaderTitleAr,
                    HeaderTitleEn = academicIntegrity.HeaderTitleEn,
                    HeaderDescriptionAr = academicIntegrity.HeaderDescriptionAr,
                    HeaderDescriptionEn = academicIntegrity.HeaderDescriptionEn,
                    ImageUrl = academicIntegrity.ImageUrl
                };

                return TResponse<AcademicIntegrityDto>.Success(dto, _resourceService.GetMessage("AcademicIntegrityUpdated"));
            }
            catch (Exception ex)
            {
                return TResponse<AcademicIntegrityDto>.Failure(new[] { _resourceService.GetError("ErrorUpdatingAcademicIntegrity") }, ex.Message);
            }
        }
    }
}
