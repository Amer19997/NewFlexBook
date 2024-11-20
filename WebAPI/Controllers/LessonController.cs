using FlexBook.Application.Features.Admin.Lessons.Commands;
using FlexBook.Application.Features.Admin.Lessons.Commands.InteractiveElementCommand;
using FlexBook.Application.Features.Admin.Lessons.Commands.LessonPartCommand;
using FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries;
//using FlexBook.Application.Features.Core.Video;
using FlexBook.Domain.Entities;
using FlexBook.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LessonController : ApiControllerBase
{
    // Stream video for a lesson
    //[HttpGet("{lessonId}/stream-video")]
    //public async Task<IActionResult> StreamVideo(Guid lessonId)
    //{
    //    var response = await Mediator.Send(new StreamLessonVideoQuery(lessonId, HttpContext));
    //    if (response is NotFoundObjectResult)
    //        return NotFound((response as NotFoundObjectResult).Value);

    //    return response;
    //}
    [HttpGet("{id:guid}/GetLessonById")]
    public async Task<IActionResult> GetLessonById(Guid id, Guid? classId)
    {
        var query = new GetLessonByIdQuery(id, classId);
        var response = await Mediator.Send(query);

        if (response == null)
        {
            return StatusCode(500, new { Message = "Unexpected error occurred." });
        }

        // Check if the operation was successful
        if (response.Errors?.Any() == true || response.Result == null)
        {
            return StatusCode(response.StatusCode, new { Errors = response.Errors, Message = response.Message });
        }

        // Return the result property directly
        return Ok(response.Result);
    }


    [HttpPost("parts/{lessonPartId}/interactive-elements")]
    public async Task<IActionResult> AddInteractiveElement([FromForm] AddInteractiveElementCommand command)
    {
       

        // Build the command with the necessary parameters
       
        var result = await Mediator.Send(command);

     
            return Ok(result);
    }
    /// <summary>
    /// Add a new lesson part to a lesson.
    /// </summary>
    /// <param name="command">The AddLessonPartCommand containing lesson part details.</param>
    /// <returns>The created LessonPartDto.</returns>
    [HttpPost("addlessonpart")]
    public async Task<IActionResult> AddLessonPart( [FromBody] AddLessonPartCommand command)
    {
        // Ensure the command contains the correct lesson ID
 
        var result = await Mediator.Send(command);

        //if (result.IsSuccess)
        //    return CreatedAtAction(nameof(AddLessonPart), new { id = result.Data.Id }, result.Data);
        //else
        return Ok(result);
    }
    //[HttpPost("createthelesson")]
    // public async Task<IActionResult> createthelesson([FromForm] AddLessonCommand command)
    // {
    //     var response = await Mediator.Send(command);
    //     //if (!response.success)
    //     //    return BadRequest(response.Errors);

    //     return Ok(response);
    // }
}
