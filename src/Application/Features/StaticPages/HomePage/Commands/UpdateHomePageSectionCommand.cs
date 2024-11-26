using FlexBook.Application.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace FlexBook.Application.Features.StaticPages.HomePage.Commands;

public record UpdateHomePageSectionCommand(
    Guid Id, // Section ID for updating

    // Books Section
    string BooksTitleAr,
    string BooksTitleEn,
    string BooksDescriptionAr,
    string BooksDescriptionEn,

    // First Feature
    string FirstFeatureTitleAr,
    string FirstFeatureTitleEn,
    string FirstFeatureDescriptionAr,
    string FirstFeatureDescriptionEn,

    // Second Feature
    string SeconedFeatureTitleAr,
    string SeconedFeatureTitleEn,
    string SeconedFeatureDescriptionAr,
    string SeconedFeatureDescriptionEn,

    // Featured Images
     IFormFile FeaturedImage,
    // Growth Section
    string GrowthTitleAr,
    string GrowthTitleEn,
    string GrowthDescriptionAr,
    string GrowthDescriptionEn,
    IFormFile? GrowthImage,

    // Highlighted Books Section
    string HighlightedBooksTitleAr,
    string HighlightedBooksTitleEn,
    string HighlightedBooksDescriptionAr,
    string HighlightedBooksDescriptionEn,
    List<Guid> HighlightedCourseIds,

    // Video Section
    string VideoTitleAr,
    string VideoTitleEn,
    string VideoDescriptionAr,
    string VideoDescriptionEn,
    IFormFile Video
) : IRequest<TResponse<object>>;
