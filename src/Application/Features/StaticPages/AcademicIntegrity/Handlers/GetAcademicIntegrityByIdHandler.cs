using System;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AcademicIntegrity.Handlers
{
    public class GetAcademicIntegrityByIdHandler : IRequestHandler<GetAcademicIntegrityByIdQuery, TResponse<AcademicIntegrityDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IResourceService _resourceService;

        public GetAcademicIntegrityByIdHandler(IUnitOfWork unitOfWork, IResourceService resourceService)
        {
            _unitOfWork = unitOfWork;
            _resourceService = resourceService;
        }

        public async Task<TResponse<AcademicIntegrityDto>> Handle(GetAcademicIntegrityByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                // Retrieve Academic Integrity by ID
                var academicIntegrity = await _unitOfWork.AcademicIntegrityrRepository.FindById(request.Id, cancellationToken);

                if (academicIntegrity == null)
                {
                    return TResponse<AcademicIntegrityDto>.Failure(
                        new[] {_resourceService.GetMessage( "Academic Integrity entry not found") },
                        "Academic Integrity entry not found",
                        404
                    );
                }

                // Map to DTO
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

                return TResponse<AcademicIntegrityDto>.Success(dto);
            }
            catch (Exception ex)
            {
                return TResponse<AcademicIntegrityDto>.Failure(new[] {_resourceService.GetError( "Error retrieving Academic Integrity entry" )}, ex.Message);
            }
        }
    }
}
