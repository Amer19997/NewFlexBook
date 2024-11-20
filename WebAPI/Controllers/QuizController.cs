using FlexBook.Application.Features.Admin;
using FlexBook.Application.Features.Admin.Questions;
using FlexBook.Application.Features.Admin.Quiz.Commands;
using FlexBook.Application.Features.Core.Quizes;
using FlexBook.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class QuizController : ApiControllerBase
{
    // POST: api/quiz
    [HttpPost("CreateQuiz")]
    public async Task<IActionResult> CreateQuiz([FromBody] CreateQuizCommand command, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await Mediator.Send(command, cancellationToken);
        //return CreatedAtAction(nameof(GetQuizById), new { id = result.Id }, result);
        return Ok(result);
    }
    // GET: api/quiz/{id}
    [HttpGet("{QuizId}/GetQuizById")]
    public async Task<IActionResult> GetQuizById(Guid id, CancellationToken cancellationToken)
    {
        // Replace with logic to get a quiz by ID
        var quiz = await Mediator.Send(new GetQuizWithQuestionsForInstructorQuery(id), cancellationToken);
        if (quiz == null)
        {
            return NotFound();
        }

        return Ok(quiz);
    }

    // POST: api/question
    [HttpPost("AddQuestion")]
    public async Task<IActionResult> CreateQuestion([FromBody] AddQuestionCommand command, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await Mediator.Send(command, cancellationToken);
        //return CreatedAtAction(nameof(GetQuestionById), new { id = result.Id }, result);
        return Ok(result);
    }

    [HttpPost("submit-answers")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SubmitQuizAnswers([FromBody] SubmitQuizAnswersCommand command)
    {
        // Validate the request
        if (command.QuizId == Guid.Empty || command.UserAnswers == null || !command.UserAnswers.Any())
        {
            return BadRequest("Invalid quiz or answers.");
        }

        // Send the command to the handler
        var result = await Mediator.Send(command);

        // Return the result
        if (result)
        {
            return Ok("Quiz answers submitted successfully.");
        }
        else
        {
            return BadRequest("Failed to submit answers or incorrect answers.");
        }
    }
}
