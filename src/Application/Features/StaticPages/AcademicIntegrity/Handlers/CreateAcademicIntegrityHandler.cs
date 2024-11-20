using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
using FlexBook.Domain;
 using FlexBook.Domain.Entities.StaticPages.Dtos;
using FlexBook.Domain.Repositories;
using MediatR;
using FlexBook.Domain.Entities.StaticPages;
using System.ComponentModel.Design;
using IResourceService = FlexBook.Application.Common.Interfaces.IResourceService;
namespace FlexBook.Application.Features.StaticPages.AcademicIntegrity.Handlers
{
    public class CreateAcademicIntegrityHandler : IRequestHandler<CreateAcademicIntegrityCommand, TResponse<AcademicIntegrityDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileUploadService _fileUploadService;
        private readonly IResourceService _resourceService;

        public CreateAcademicIntegrityHandler(IUnitOfWork unitOfWork, IFileUploadService fileUploadService, IResourceService resourceService)
        {
            _unitOfWork = unitOfWork;
            _fileUploadService = fileUploadService;
            _resourceService = resourceService;

        }

        public async Task<TResponse<AcademicIntegrityDto>> Handle(CreateAcademicIntegrityCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string? imageUrl = null;
                if (request.Image != null)
                {
                    imageUrl = await _fileUploadService.UploadFileAsync(request.Image);
                }

                var academicIntegrity =   new FlexBook.Domain.Entities.StaticPages.AcademicIntegrity
                
                {
                    TitleAr = request.TitleAr,
                    TitleEn = request.TitleEn,
                    DescriptionAr = request.DescriptionAr,
                    DescriptionEn = request.DescriptionEn,
                    HeaderTitleAr = request.HeaderTitleAr,
                    HeaderTitleEn = request.HeaderTitleEn,
                    HeaderDescriptionAr = request.HeaderDescriptionAr,
                    HeaderDescriptionEn = request.HeaderDescriptionEn,
                    ImageUrl = imageUrl
                };

                await _unitOfWork.AcademicIntegrityrRepository.Add(academicIntegrity, cancellationToken);
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

                return TResponse<AcademicIntegrityDto>.Success(dto, _resourceService.GetMessage("AcademicIntegrity Created Successfully"));
            }
            catch (Exception ex)
            {
                return TResponse<AcademicIntegrityDto>.Failure(new[] { _resourceService.GetError("Error creating Academic Integrity entry" )}, ex.Message);
            }
        }
    }
}
 