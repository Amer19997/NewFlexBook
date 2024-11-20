using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Features.Core.Quizes;
using FlexBook.Domain.Enums;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Admin.Sections.Commands;
using FlexBook.Domain.Entities.Catalog.Dtos;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Features.Admin.Lessons.Commands;
using Microsoft.Extensions.Options;
using FlexBook.Domain.Entities.Catalog;
namespace FlexBook.Application.Features.Admin;
public class SubmitQuizAnswersCommandHandler : IRequestHandler<SubmitQuizAnswersCommand, bool>
{
    private readonly IQuizEvaluationService _quizEvaluationService;
    private readonly IMediator _mediator;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountService _accountService;
    private readonly ITokenService _tokenService;
    private readonly IResourceService _resourceService;
    private readonly AppSettings _appSettings;

    public SubmitQuizAnswersCommandHandler(IQuizEvaluationService quizEvaluationService, IMediator mediator, IUnitOfWork unitOfWork, IAccountService accountService,
             ITokenService tokenService,
             IOptions<AppSettings> appSettings,
             IResourceService resourceService
             )
    {
        _quizEvaluationService = quizEvaluationService;
        _mediator = mediator;
        _unitOfWork = unitOfWork;
        _accountService = accountService;
        _tokenService = tokenService;
        _appSettings = appSettings.Value;
        _resourceService = resourceService;
    }

        public async Task<bool> Handle(SubmitQuizAnswersCommand request, CancellationToken cancellationToken)
    {
        var quiz = await _mediator.Send(new GetQuizWithQuestionsForInstructorQuery (request.QuizId));

        if (quiz == null || quiz.Questions == null || !quiz.Questions.Any())
            return false;

        bool allCorrect = true;

        foreach (var userAnswer in request.UserAnswers)
        {
            var question = quiz.Questions.FirstOrDefault(q => q.Id == userAnswer.QuestionId);
            if (question == null)
                continue;

            switch (question.QuestionType)
            {
                case QuestionType.MultipleChoice:
                    var isMultipleChoiceCorrect = await _quizEvaluationService.EvaluateMultipleChoice(question, userAnswer.Answers);
                    allCorrect &= isMultipleChoiceCorrect;
                    break;

                case QuestionType.Matching:
                    var isMatchingCorrect = await _quizEvaluationService.EvaluateMatching(question, userAnswer.MatchingAnswers);
                    allCorrect &= isMatchingCorrect;
                    break;

                case QuestionType.TrueFalse:
                    var isTrueFalseCorrect = await _quizEvaluationService.EvaluateTrueFalse(question, userAnswer.Answer);
                    allCorrect &= isTrueFalseCorrect;
                    break;

                case QuestionType.Essay:
                    var isEssayCorrect = await _quizEvaluationService.EvaluateEssay(question, userAnswer.Answer);
                    allCorrect &= isEssayCorrect;
                    break;

                default:
                    return false;
            }
        }

        return allCorrect;
    }
}