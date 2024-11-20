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

namespace FlexBook.Application.Features.Core.Sections.GetSectionById;
public class GetSectionByIdQueryHandler : IRequestHandler<GetSectionByIdQuery, TResponse<GetSectionAfterLoginDTo>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetSectionByIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<GetSectionAfterLoginDTo>> Handle(GetSectionByIdQuery request, CancellationToken cancellationToken)
    {
        //var section = await _unitOfWork.SectionRepository.FindById(request.SectionId, cancellationToken);
        var section = await _unitOfWork.SectionRepository.GetByIdAsync(
    s => s.Id == request.SectionId,  // Filter expression
    "Lessons,Quizzes",               // Related entities to include
    cancellationToken                // Cancellation token
);
        if (section == null)
            return TResponse<GetSectionAfterLoginDTo>.Failure(new[] { "Section not found." });

        var sectionDto = new GetSectionAfterLoginDTo
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
                DescriptionEn = l.DescriptionEn,
                TitleEn      = l.TitleEn,
                TitleAr    = l.TitleAr,
                Resources = l.Resources,
                HasCodeEditor = l.HasCodeEditor,
                CreationDate = l.CreationDate,
                //FileUrl = l.FileUrl,
                //ImageUrl = l.ImageUrl,
                //GifUrl=l.GifUrl,
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
        };

        return TResponse<GetSectionAfterLoginDTo>.Success(sectionDto);
    }
}
