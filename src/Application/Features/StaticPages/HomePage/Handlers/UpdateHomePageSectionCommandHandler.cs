using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.HomePage.Commands;
using FlexBook.Domain;
using FlexBook.Domain.Entities.StaticPages;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.HomePage.Handlers;

public class UpdateHomePageSectionCommandHandler : IRequestHandler<UpdateHomePageSectionCommand, TResponse<object>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileUploadService _fileUploadService;
    private readonly IResourceService _resourceService;
    private readonly IVideoStorageService _videoStorageService;
    public UpdateHomePageSectionCommandHandler(
        IUnitOfWork unitOfWork,
        IFileUploadService fileUploadService,
        IResourceService resourceService,
        IVideoStorageService videoStorageService

        )
    {
        _unitOfWork = unitOfWork;
        _fileUploadService = fileUploadService;
        _resourceService = resourceService;
        _videoStorageService = videoStorageService;

    }

    public async Task<TResponse<object>> Handle(UpdateHomePageSectionCommand request, CancellationToken cancellationToken)
    {
        var section = await _unitOfWork.HomePageSectionRepository.GetHomePageSectionAsync(cancellationToken);

        if (section == null)
        {
            return TResponse<object>.Failure(
                new[] { _resourceService.GetError("Home page section not found.") },
                "Entity not found",
                404
            );
        }

        // Update properties
        section.BooksTitleAr = request.BooksTitleAr;
        section.BooksTitleEn = request.BooksTitleEn;
        section.BooksDescriptionAr = request.BooksDescriptionAr;
        section.BooksDescriptionEn = request.BooksDescriptionEn;

        section.FirstFeatureTitleAr = request.FirstFeatureTitleAr;
        section.FirstFeatureTitleEn = request.FirstFeatureTitleEn;
        section.FirstFeatureDescriptionAr = request.FirstFeatureDescriptionAr;
        section.FirstFeatureDescriptionEn = request.FirstFeatureDescriptionEn;

        section.SeconedFeatureTitleAr = request.SeconedFeatureTitleAr;
        section.SeconedFeatureTitleEn = request.SeconedFeatureTitleEn;
        section.SeconedFeatureDescriptionAr = request.SeconedFeatureDescriptionAr;
        section.SeconedFeatureDescriptionEn = request.SeconedFeatureDescriptionEn;

        //if (request.FeaturedImage != null)
        //{
        //    var imageUrls = new List<string>();
        //    foreach (var image in request.FeaturedImages)
        //    {
        //        var uploadedPath = await _fileUploadService.UploadFileAsync(image);
        //        imageUrls.Add(uploadedPath);
        //    }
        //    section.FeaturedImages = imageUrls;
        //}
        var FeaturedImage = string.Empty;
        if (request.FeaturedImage != null)
        {

            FeaturedImage = await _fileUploadService.UploadFileAsync(request.FeaturedImage);
            section.FeaturedImage = FeaturedImage;
        }

        section.GrowthTitleAr = request.GrowthTitleAr;
        section.GrowthTitleEn = request.GrowthTitleEn;
        section.GrowthDescriptionAr = request.GrowthDescriptionAr;
        section.GrowthDescriptionEn = request.GrowthDescriptionEn;

        if (request.GrowthImage != null)
        {
            section.GrowthImage = await _fileUploadService.UploadFileAsync(request.GrowthImage);
        }
        var videoUrl = string.Empty;
        if (request.Video != null)
        {

            videoUrl = await _videoStorageService.UploadVideoAsync(request.Video);
        }
        section.HighlightedBooksTitleAr = request.HighlightedBooksTitleAr;
        section.HighlightedBooksTitleEn = request.HighlightedBooksTitleEn;
        section.HighlightedBooksDescriptionAr = request.HighlightedBooksDescriptionAr;
        section.HighlightedBooksDescriptionEn = request.HighlightedBooksDescriptionEn;

        section.HighlightedCourses = await _unitOfWork.CouresRepository.GetByIdsAsync(request.HighlightedCourseIds, cancellationToken);

        section.VideoTitleAr = request.VideoTitleAr;
        section.VideoTitleEn = request.VideoTitleEn;
        section.VideoDescriptionAr = request.VideoDescriptionAr;
        section.VideoDescriptionEn = request.VideoDescriptionEn;
        section.VideoUrl = videoUrl;

         _unitOfWork.HomePageSectionRepository.Update(section);
 
        await _unitOfWork.CommitAsync(cancellationToken);

        return TResponse<object>.Success(new { section.Id }, _resourceService.GetMessage("Home page section updated successfully."));
    }
}
