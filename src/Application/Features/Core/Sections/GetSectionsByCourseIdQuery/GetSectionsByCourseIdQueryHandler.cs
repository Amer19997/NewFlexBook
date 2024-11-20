using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Features.Core.Sections.GetSectionsByCourseIdQuery;
// GetSectionsByCourseIdQueryHandler
public class GetSectionsByCourseIdQueryHandler : IRequestHandler<GetSectionsByCourseIdQuery, TResponse<List<GetSectionAfterLoginDTo>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSectionsByCourseIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
 

    public async Task<TResponse<List<GetSectionAfterLoginDTo>>> Handle(GetSectionsByCourseIdQuery request, CancellationToken cancellationToken)
    {
        var sections = await _unitOfWork.CouresRepository.GetSectionsByCourseIdAsync(request.CourseId, cancellationToken);

        if (sections == null || !sections.Any())
            return TResponse<List<GetSectionAfterLoginDTo>>.Failure(new[] { "No sections found for the specified course." });

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
                DescriptionEn = l.DescriptionEn,
                DescriptionAr =l.DescriptionAr,
                TitleEn=l.TitleEn,
                TitleAr=l.TitleAr,
                Resources = l.Resources,
                HasCodeEditor = l.HasCodeEditor,
                CreationDate = l.CreationDate,
                //FileUrl = l.FileUrl,
                //GifUrl=l.GifUrl,
                //ImageUrl=l.ImageUrl
            }).ToList(),
            Quizzes = section.Quizzes.Select(q => new GetQuizAfterInstructorLoginDto
            {
                Id = q.Id,
                Name = q.Name,
                QuizType = q.QuizType,
                Questions = q.Questions.Select(qst => new GetQuestionForInstructorDto
                {
                    Id = qst.Id,
                    QuestionText = qst.QuestionText,
                    QuestionType = qst.QuestionType,
                    Options = qst.Options,
                    CorrectAnswers = qst.CorrectAnswers,
                    MatchingPairs = qst.MatchingPairs,
                    Answer = qst.Answer
                }).ToList()
            }).ToList()
        }).ToList();

        return TResponse<List<GetSectionAfterLoginDTo>>.Success(sectionDtos);
    }
}
