using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.AccessCode;
using FlexBook.Application.Features.Core.Classes.Commands;
using FlexBook.Application.Features.Core.Classes.Quieries;
using FlexBook.Application.Features.Core.Classes.Quieries.GetClassesForInstructor;
using FlexBook.Application.Features.Core.ClassRequests.Commands.Aprrove;
using FlexBook.Application.Features.Core.ClassRequests.Commands.Request;
using FlexBook.Application.Features.Core.ClassRequests.Quireies;
using FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries;
using FlexBook.Application.Features.Core.StudentsInvitations;
using FlexBook.Domain.Entities;
using FlexBook.Domain.Entities.Catalog;
using FlexBook.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ClassController : ApiControllerBase
{

    // Endpoint for instructor to create a class
    //[HttpPost("create")]
    //public async Task<Guid> CreateClass([FromBody] CreateClassCommand command)
    //{
    //   var dto=  await Mediator.Send(command);
    //    return dto;

    //}
    //[HttpPost("CreateClass")]
    //public async Task<IActionResult> CreateClass([FromBody] CreateClassCommand command)
    //{
    //    Send the command to the mediator
    //    var result = await Mediator.Send(command);

    //    Check for failure and return appropriate error response
    //    if (!result.success)
    //        return StatusCode(result.StatusCode, result.Errors);

    //    On success, return the result with a 200 OK status
    //    return Ok(result);
    //}
    [HttpGet("GetClassesForInstructor")]
    public async Task<IActionResult> GetClassesForInstructor()
    {
        var query = new GetClassesForInstructorQuery();
        var result = await Mediator.Send(query);


        return Ok(result);
    }
    [HttpPost("CreateClass")]
    public async Task<IActionResult> CreateClass([FromBody] CreateClassCommand command)
    {

        var result = await Mediator.Send(command);


        return Ok(result);
    }

    // GET: api/course/{courseId}/classes
    [HttpGet("GetClassesForCourse/{courseId}")]
    public async Task<IActionResult> GetClassesForCourse(Guid courseId, [FromQuery] string className = null)
    {
        var query = new GetClassesForCourseQuery(courseId, className);
        var result = await Mediator.Send(query);

        return Ok(result);
    }
    [HttpGet("GetAllClassRequestsForInstructor")]
    public async Task<IActionResult> GetAllClassRequestsForInstructor([FromQuery]GetAllClassRequestsForInstructorQuery query)
    {
        // Construct the query with the provided instructor ID
        //var query = new GetAllClassRequestsForInstructorQuery();

        // Send the query to the mediator
        var result = await Mediator.Send(query);


        // Return success response with the list of class requests
        return Ok(result);
    }
    [HttpPost("RequestClassAccess")]
    public async Task<IActionResult> RequestClassAccess([FromBody] RequestClassAccessCommand command)
    {
        // Send the command to the mediator
        var result = await Mediator.Send(command);

        // Handle failure responses

        // Return success response
        return Ok(result);
    }

    [HttpPost("ApproveClassRequest")]
    public async Task<IActionResult> ApproveClassRequest([FromQuery] Guid requestId, bool IsApprove)
    {
        // Construct the command using the request ID
        var command = new ApproveClassRequestCommand(requestId, IsApprove);

        // Send the command to the mediator
        var result = await Mediator.Send(command);

        // Handle failure responses

        // Return success response
        return Ok(result);
    }

    /// <returns>A response indicating whether the access code was successfully used to join the class.</returns>
    [HttpPost("UseAccessCode")]
    public async Task<IActionResult> UseAccessCode([FromBody] UseAccessCode request)
    {
        // Construct the command with the provided access code and class ID
        var command = new UseAccessCodeCommand(request.ClassId, request.AccessCode);

        // Send the command to the mediator
        var result = await Mediator.Send(command);

        // Handle failure responses
 
        // Return success response
        return Ok(result);
    }


    [HttpPost("InviteStudents")]
    public async Task<IActionResult> InviteStudents([FromBody] InviteStudentsCommand command)
    {
        // Send the command to the mediator
        var result = await Mediator.Send(command);

        // Handle failure responses

        // Return success response
        return Ok(result);
    }
    //// Endpoint to add a student to a class
    //[HttpPost("class/{classId}/add-student")]
    //public async Task<IActionResult> AddStudentToClass(Guid classId, [FromBody] AddStudentToClassCommand command)
    //{
    //    command.ClassId = classId;
    //    await _mediator.Send(command);
    //    return Ok();
    //}

    //// Endpoint for students to get the content of the class they are enrolled in
    //[HttpGet("{classId}/content")]
    //public async Task<IActionResult> GetClassContent(Guid classId, [FromQuery] Guid studentId)
    //{
    //    var result = await _mediator.Send(new GetClassContentQuery { ClassId = classId, StudentId = studentId });
    //    return Ok(result);
    //}
}
