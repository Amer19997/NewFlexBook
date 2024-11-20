using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourseById;
using FlexBook.Domain;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;
using MediatR;
using System.Text.Json;

namespace FlexBook.Application.Features.Admin.Quiz.Commands;

public class CreateQuizCommandHandler : IRequestHandler<CreateQuizCommand, TResponse<GetQuizAfterInstructorLoginDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IResourceService _resourceService;

    public CreateQuizCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IResourceService resourceService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _resourceService = resourceService;

    }

    public async Task<TResponse<GetQuizAfterInstructorLoginDto>> Handle(CreateQuizCommand request, CancellationToken cancellationToken)
    {
        var quiz = new Domain.Entities.Catalog.Quiz
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            QuizType = request.QuizType,
            SectionId = request.SectionId,
            LessonId= request.LessonId,
            Questions = request.Questions.Select(q => new Question
            {
                Id = Guid.NewGuid(),
                QuestionText = q.QuestionText,
                QuestionType = q.QuestionType,
                OptionsJson = JsonSerializer.Serialize(q.Options),
                CorrectAnswersJson = JsonSerializer.Serialize(q.CorrectAnswers),
                MatchingPairsJson= JsonSerializer.Serialize(q.MatchingPairs),
                Answer           =  q.Answer,
            }).ToList()
        };

        _unitOfWork.QuizRepository.Add(quiz,cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        var response  =  new GetQuizAfterInstructorLoginDto
        {
            Id = quiz.Id,
            Name = quiz.Name,
            QuizType = quiz.QuizType,
            Questions = quiz.Questions.Select(q => new GetQuestionForInstructorDto
            {
                QuestionText = q.QuestionText,
                QuestionType = q.QuestionType,
                Options = JsonSerializer.Deserialize<List<string>>(q.OptionsJson),
                CorrectAnswers = JsonSerializer.Deserialize<List<string>>(q.CorrectAnswersJson),
                Answer= q.Answer,

            }).ToList()
        };
        return TResponse<GetQuizAfterInstructorLoginDto>.Success(response);

    }















}