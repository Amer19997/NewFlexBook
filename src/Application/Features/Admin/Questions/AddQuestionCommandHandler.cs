using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace FlexBook.Application.Features.Admin.Questions;
public class AddQuestionCommandHandler : IRequestHandler<AddQuestionCommand, TResponse<QuestionDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountService _accountService;
    private readonly ITokenService _tokenService;
    private readonly IResourceService _resourceService;
    private readonly AppSettings _appSettings;
    private readonly IMediator _mediator;


    public AddQuestionCommandHandler(IUnitOfWork unitOfWork,
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
    }



    public async Task<TResponse<QuestionDto>> Handle(AddQuestionCommand request, CancellationToken cancellationToken)
    {
        var question = new Question
        {
            Id = Guid.NewGuid(),
            QuestionText = request.QuestionText,
            QuestionType = request.QuestionType,
            QuizId = request.QuizId,
            OptionsJson = request.Options != null ? JsonSerializer.Serialize(request.Options) : null,
            CorrectAnswersJson = request.CorrectAnswers != null ? JsonSerializer.Serialize(request.CorrectAnswers) : null,
            MatchingPairsJson = request.MatchingPairs != null ? JsonSerializer.Serialize(request.MatchingPairs) : null,
            Answer = request.Answer
        };

        _unitOfWork.QuestionRepository.Add(question,cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        var questionDto = new QuestionDto
        {
            Id = question.Id,
            QuestionText = question.QuestionText,
            QuestionType = question.QuestionType,
            Options = question.Options,
            CorrectAnswers = question.CorrectAnswers,
            MatchingPairs = question.MatchingPairs,
            Answer = question.Answer,
            QuizId = question.QuizId
        };

        return TResponse<QuestionDto>.Success(questionDto);
    }
}