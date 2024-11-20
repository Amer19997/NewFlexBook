using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Admin.Commnds.CreateInstructor;
using MediatR;
using Microsoft.Extensions.Options;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using Microsoft.AspNetCore.Http;
using System.IO.Compression;
using FlexBook.Domain.Repositories;
using System.Text.Json;

namespace FlexBook.Application.Features.Admin.Lessons.Commands;
// AddLessonCommandHandler


    public class AddLessonCommandHandler : IRequestHandler<AddLessonCommand, TResponse<GetLessonAfterLoginDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;
        private readonly IResourceService _resourceService;
        private readonly AppSettings _appSettings;
        private readonly IMediator _mediator;
    //private readonly IVideoStorageService _videoStorageService;
    private readonly IFileUploadService _fileUploadService;
    private readonly IPhotoStorageService _photoStorageService;
    private readonly IInteractiveContentService _interactiveContentService;


    public AddLessonCommandHandler(
        IPhotoStorageService photoStorageService,
        IInteractiveContentService interactiveContentService,
        IFileUploadService fileUploadService,
        //IVideoStorageService videoStorageService,
        IUnitOfWork unitOfWork,
             IAccountService accountService,
             ITokenService tokenService,
             IOptions<AppSettings> appSettings,
             IResourceService resourceService,
             IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _accountService = accountService;
            _tokenService = tokenService;
            _appSettings = appSettings.Value;
            _resourceService = resourceService;
            _mediator = mediator;
        //_videoStorageService = videoStorageService;
        _fileUploadService = fileUploadService;
        _photoStorageService = photoStorageService;
        _interactiveContentService = interactiveContentService;

    }


    public async Task<TResponse<GetLessonAfterLoginDto>> Handle(AddLessonCommand request, CancellationToken cancellationToken)
    {
        // Handle file uploads for cover photo and resources
        string? coverPhotoUrl = request.CoverPhoto != null ? await _fileUploadService.UploadFileAsync(request.CoverPhoto) : null;
        List<string> resourceUrls = new List<string>();

        if (request.ResourceFiles != null)
        {
            foreach (var resourceFile in request.ResourceFiles)
            {
                var resourceUrl = await _fileUploadService.UploadFileAsync(resourceFile);
                resourceUrls.Add(resourceUrl);
            }
        }

        // Map LessonParts and InteractiveElements
        //var lessonParts = request.LessonParts.Select(partDto => new LessonPart
        //{
        //    Content = partDto.Content,
        //    InteractiveElements = partDto.InteractiveElements.Select(interactiveDto => new InteractiveElement
        //    {
        //        ZipUrl = interactiveDto.ZipFile != null
        //            ? _fileUploadService.UploadFileAsync(interactiveDto.ZipFile).Result
        //            : null
        //    }).ToList()
        //}).ToList();
        // Map quizzes
        //var quizzes = request.Quizzes.Select(q => new Domain.Entities.Catalog.Quiz

        //{
        //    Name = q.Name,
        //    QuizType = q.QuizType,
        //    Questions = q.Questions.Select(qst => new Question
        //    {
        //        QuestionText = qst.QuestionText,
        //        QuestionType = qst.QuestionType,
        //        OptionsJson = qst.Options != null ? JsonSerializer.Serialize(qst.Options) : null,
        //        CorrectAnswersJson = qst.CorrectAnswers != null ? JsonSerializer.Serialize(qst.CorrectAnswers) : null,
        //        MatchingPairsJson = qst.MatchingPairs != null ? JsonSerializer.Serialize(qst.MatchingPairs) : null,
        //        Answer = qst.Answer
        //    }).ToList()
        //}).ToList();
        // Create the Lesson entity
        var lesson = new Lesson
        {
            NameAr = request.NameAr,
            NameEn = request.NameEn,
            TitleAr = request.TitleAr,
            TitleEn = request.TitleEn,
            DescriptionAr = request.DescriptionAr,
            DescriptionEn = request.DescriptionEn,
            HasCodeEditor = request.HasCodeEditor,
            CodeEditorLanguage = request.CodeEditorLanguage,
            CodeEditorInitialCode = request.CodeEditorInitialCode,
            CoverPhoto = coverPhotoUrl,
            Resources = resourceUrls,
            SectionId = request.SectionId,
            CreationDate = DateTime.UtcNow,
            //LessonParts = lessonParts,

        };

        // Save lesson and create response
        await _unitOfWork.LessonRepository.Add(lesson, cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        var resultDto = new GetLessonAfterLoginDto
        {
            Id = lesson.Id,
            TitleEn = lesson.TitleEn,
            TitleAr = lesson.TitleAr,
            DescriptionEn = lesson.DescriptionEn,
            DescriptionAr = lesson.DescriptionAr,
            CoverPhoto = lesson.CoverPhoto
            // Add more fields if needed
        };

         return TResponse<GetLessonAfterLoginDto>.Success(resultDto);

    }
}













