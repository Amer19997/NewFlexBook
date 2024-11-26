using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.HomePage.Queries;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.HomePage.Handlers;

public class GetHomePageSectionByIdQueryHandler : IRequestHandler<GetHomePageSectionByIdQuery, TResponse<HomePageSectionDto>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetHomePageSectionByIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<HomePageSectionDto>> Handle(GetHomePageSectionByIdQuery request, CancellationToken cancellationToken)
    {
        var section = await _unitOfWork.HomePageSectionRepository.GetHomePageSectionAsync(cancellationToken);

        if (section == null)
        {
            return TResponse<HomePageSectionDto>.Failure(
                new[] { "Home page section not found." },
                "Entity not found",
                404
            );
        }
        var coursesDtos = section.HighlightedCourses.Select(hc => new CourseDto
        {
            CoverPhoto = hc.CoverPhoto,
            DiscriptionAr = hc.DiscriptionAr,
            DiscriptionEn = hc.DiscriptionEn,
            NameAr = hc.NameAr,
            NameEn = hc.NameEn,
        });
        var dto = new HomePageSectionDto
        {
            BooksTitleAr = section.BooksTitleAr,
            BooksTitleEn = section.BooksTitleEn,
            BooksDescriptionAr = section.BooksDescriptionAr,
            BooksDescriptionEn = section.BooksDescriptionEn,
            FirstFeatureTitleAr = section.FirstFeatureTitleAr,
            FirstFeatureTitleEn = section.FirstFeatureTitleEn,
            FirstFeatureDescriptionAr = section.FirstFeatureDescriptionAr,
            FirstFeatureDescriptionEn = section.FirstFeatureDescriptionEn,
            SeconedFeatureTitleAr = section.SeconedFeatureTitleAr,
            SeconedFeatureTitleEn = section.SeconedFeatureTitleEn,
            SeconedFeatureDescriptionAr = section.SeconedFeatureDescriptionAr,
            SeconedFeatureDescriptionEn = section.SeconedFeatureDescriptionEn,
            FeaturedImage = section.FeaturedImage,
            GrowthTitleAr = section.GrowthTitleAr,
            GrowthTitleEn = section.GrowthTitleEn,
            GrowthDescriptionAr = section.GrowthDescriptionAr,
            GrowthDescriptionEn = section.GrowthDescriptionEn,
            GrowthImage = section.GrowthImage,
            HighlightedBooksTitleAr = section.HighlightedBooksTitleAr,
            HighlightedBooksTitleEn = section.HighlightedBooksTitleEn,
            HighlightedBooksDescriptionAr = section.HighlightedBooksDescriptionAr,
            HighlightedBooksDescriptionEn = section.HighlightedBooksDescriptionEn,
            HighlightedCourses= coursesDtos,
            VideoTitleAr = section.VideoTitleAr,
            VideoTitleEn = section.VideoTitleEn,
            VideoDescriptionAr = section.VideoDescriptionAr,
            VideoDescriptionEn = section.VideoDescriptionEn,
            VideoUrl = section.VideoUrl
        };

        return TResponse<HomePageSectionDto>.Success(dto);
    }
}
