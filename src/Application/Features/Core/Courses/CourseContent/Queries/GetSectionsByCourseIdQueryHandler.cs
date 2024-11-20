using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;
using FlexBook.Application.Users.Commands.SignUpCommand;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using FlexBook.Domain.Entities.Catalog.Dtos.InstructorAfterLogin;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Options;

namespace FlexBook.Application.Features.Core.Courses.CourseContent.Queries;



    public class GetSectionsByCourseIdQueryHandler : IRequestHandler<GetSectionsByCourseIdQuery, TResponse<List<GetSectionAfterLoginDTo>>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICacheService _cacheService;
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;
        private readonly IResourceService _resourceService;
        private readonly AppSettings _appSettings;
        public GetSectionsByCourseIdQueryHandler(IUnitOfWork unitOfWork,
            ICacheService cacheService,
            IAccountService accountService,
            ITokenService tokenService,
            IOptions<AppSettings> appSettings,
            IResourceService resourceService,
            IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _cacheService = cacheService;
            _accountService = accountService;
            _tokenService = tokenService;
            _appSettings = appSettings.Value;
            _resourceService = resourceService;
        }


        public async Task<TResponse<List<GetSectionAfterLoginDTo>>> Handle(GetSectionsByCourseIdQuery request, CancellationToken cancellationToken)
    {
        // Fetch sections from the repository
        var sections = await _unitOfWork.CouresRepository.GetSectionsByCourseIdAsync(request.CourseId, cancellationToken);

        if (sections == null || !sections.Any())
        {
            return TResponse<List<GetSectionAfterLoginDTo>>.Failure(new[] { _resourceService.GetError("No sections found for the specified course.") });

        }



        // Map the sections to DTOs
        var sectionDtos = sections.Select(section => new GetSectionAfterLoginDTo
        {
            Id = section.Id,
            TitleAr = section.TitleAr,
            TitleEn = section.TitleEn,
            CourseId = section.CourseId,
            Lessons = section.Lessons.Select(l => new GetLessonAfterLoginDto
            {
                Id = l.Id,
                NameAr = l.NameAr,
                NameEn = l.NameEn,
                DescriptionAr = l.DescriptionAr,
                DescriptionEn= l.DescriptionEn,
                TitleAr= l.TitleAr,
                TitleEn= l.TitleEn, 
                //GifUrl = l.GifUrl,
                //ImageUrl= l.ImageUrl,
                //ResourceUrl = l.ResourceUrl,
                HasCodeEditor = l.HasCodeEditor,
                CreationDate = l.CreationDate,
                //ContentType = l.ContentType,
              CodeEditorInitialCode = l.CodeEditorInitialCode,
              CodeEditorLanguage = l.CodeEditorLanguage,
              //FileUrl = l.FileUrl,
              //VideoUrl = l.VideoUrl,
            }).ToList(),
            Quizzes = section.Quizzes.Select(q => new GetQuizAfterInstructorLoginDto
            {
                Id = q.Id,
                Name = q.Name,
                QuizType = q.QuizType,
                SectionId = q.SectionId,
                Questions = q.Questions.Select(question => new GetQuestionForInstructorDto
                {
                    Id = question.Id,
                    QuestionText = question.QuestionText,
                    QuestionType = question.QuestionType,
                    Options = question.Options,
                    CorrectAnswers = question.CorrectAnswers,
                    MatchingPairs = question.MatchingPairs,
                    Answer = question.Answer
                }).ToList()
            }).ToList()
        }).ToList();

        return TResponse<List<GetSectionAfterLoginDTo>>.Success(sectionDtos);
    }
}
