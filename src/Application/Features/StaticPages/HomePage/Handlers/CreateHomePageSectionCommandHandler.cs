using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.HomePage.Commands;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.HomePage.Handlers;

public class CreateHomePageSectionCommandHandler : IRequestHandler<CreateHomePageSectionCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;
    private readonly IVideoStorageService _videoStorageService;

    public CreateHomePageSectionCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService,
        IVideoStorageService videoStorageService)
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
        _videoStorageService = videoStorageService;
    }

    public async Task<TResponse<object>> Handle(CreateHomePageSectionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Upload featured images
            var FeaturedImage = string.Empty;
            if (request.FeaturedImage != null)
            {
                 
            FeaturedImage = await _fileUploadService.UploadFileAsync(request.FeaturedImage);

            }

            // Upload growth image
            var growthImageUrl = string.Empty;
            if (request.GrowthImage != null)
            {
                growthImageUrl = await _fileUploadService.UploadFileAsync(request.GrowthImage);
            }
            var videoUrl= string.Empty;
            if (request.Video != null) { 
            
videoUrl=await _videoStorageService.UploadVideoAsync(request.Video);
                    }
            // Create the Home Page Section
            var homePageSection = new HomePageSection
            {
                BooksTitleAr = request.BooksTitleAr,
                BooksTitleEn = request.BooksTitleEn,
                BooksDescriptionAr = request.BooksDescriptionAr,
                BooksDescriptionEn = request.BooksDescriptionEn,
                FirstFeatureTitleAr = request.FirstFeatureTitleAr,
                FirstFeatureTitleEn = request.FirstFeatureTitleEn,
                FirstFeatureDescriptionAr = request.FirstFeatureDescriptionAr,
                FirstFeatureDescriptionEn = request.FirstFeatureDescriptionEn,
                SeconedFeatureTitleAr = request.SeconedFeatureTitleAr,
                SeconedFeatureTitleEn = request.SeconedFeatureTitleEn,
                SeconedFeatureDescriptionAr = request.SeconedFeatureDescriptionAr,
                SeconedFeatureDescriptionEn = request.SeconedFeatureDescriptionEn,
                FeaturedImage = FeaturedImage,
                GrowthTitleAr = request.GrowthTitleAr,
                GrowthTitleEn = request.GrowthTitleEn,
                GrowthDescriptionAr = request.GrowthDescriptionAr,
                GrowthDescriptionEn = request.GrowthDescriptionEn,
                GrowthImage = growthImageUrl,
                HighlightedBooksTitleAr = request.HighlightedBooksTitleAr,
                HighlightedBooksTitleEn = request.HighlightedBooksTitleEn,
                HighlightedBooksDescriptionAr = request.HighlightedBooksDescriptionAr,
                HighlightedBooksDescriptionEn = request.HighlightedBooksDescriptionEn,
                HighlightedCourses = await _unitOfWork.CouresRepository.GetByIdsAsync(request.HighlightedCourseIds, cancellationToken),
                VideoTitleAr = request.VideoTitleAr,
                VideoTitleEn = request.VideoTitleEn,
                VideoDescriptionAr = request.VideoDescriptionAr,
                VideoDescriptionEn = request.VideoDescriptionEn,
                VideoUrl = videoUrl
            };

            await _unitOfWork.HomePageSectionRepository.Add(homePageSection, cancellationToken);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Success response
            return TResponse<object>.Success(new { homePageSection.Id }, _resourceService.GetMessage("Home page section created successfully."));
        }
        catch (Exception ex)
        {
            // Failure response
            return TResponse<object>.Failure(
                new[] { _resourceService.GetError("Error creating home page section.") },
                ex.Message,
                500
            );
        }
    }
}
