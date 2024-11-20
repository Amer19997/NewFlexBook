using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Core.Courses.CourseContentForInstructor;
using FlexBook.Application.Features.Core.Courses.InstructorCourseEdits.Commands;
using FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;
using FlexBook.Application.Features.Core.Lessons.GetLessonByIdForInstructor;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Catalog;
[Route("api/[controller]")]

[ApiController]
public class InstructorController : ApiControllerBase
{
    // Get course content for the instructor
    [HttpGet("{courseId}/course-content")]
    public async Task<IActionResult> GetCourseContentForInstructor(Guid courseId, [FromQuery] Guid instructorId)
    {
        var query = new GetCourseContentForInstructorQuery(courseId, instructorId);
        var result = await Mediator.Send(query);
        return Ok(result);
    }
    // POST: api/instructor/{courseId}/apply-edits
    //[HttpPost("{courseId}/apply-edits")]
    //public async Task<IActionResult> ApplyEdits(Guid courseId, [FromBody] ApplyInstructorCourseEditsCommand command)
    //{
    //    if (command.CourseId != courseId)
    //        return BadRequest("Course ID in the route and command body do not match.");

    //    // Send the command to the handler
    //    var success = await Mediator.Send(command);

    //    if (success)
    //        return Ok("Instructor edits applied successfully.");
    //    else
    //        return StatusCode(500, "Failed to apply instructor edits.");
    //}
    /// <summary>
    /// Applies instructor-specific edits to a course.
    /// </summary>
    /// <remarks>
    /// This endpoint allows an instructor to make custom modifications to specific sections and lessons within a course.
    /// Only instructors assigned to the course are authorized to make these edits. 
    /// Edits can include changes like hiding specific sections or lessons, modifying lesson titles, descriptions, and visibility of content.
    /// </remarks>
    /// <param name="command">The command containing course ID, section edits, and lesson edits.</param>
    /// <response code="200">Course edits applied successfully.</response>
    /// <response code="401">Unauthorized - The user must be logged in as an instructor to make course edits.</response>
    /// <response code="403">Forbidden - The instructor does not have permission to edit this course.</response>
    /// <response code="500">Internal Server Error - An unexpected error occurred while applying course edits.</response>
    /// <returns>
    /// A structured response indicating whether the operation succeeded or failed, along with a relevant status code and message.
    /// </returns>
    //[HttpPost("{courseId}/apply-edits")]
    //public async Task<IActionResult> ApplyInstructorCourseEdits(Guid courseId, [FromBody] ApplyInstructorCourseEditsCommand command)
    //{
    //    // Send the command with the courseId to the mediator
    //    var result = await Mediator.Send(new ApplyInstructorCourseEditsCommand
    //    {
    //        CourseId = courseId,
    //        SectionEdits = command.SectionEdits,
    //        LessonEdits = command.LessonEdits
    //    });


    //    // Return success response
    //    return Ok(result);
    //}
    /// <summary>
    /// Get a specific lesson by lesson ID for a specific instructor
    /// </summary>
    ///  [HttpPost("apply-edits")]
    ///        
    [HttpPost("apply-edits")]

    public async Task<IActionResult> ApplyEdits([FromBody] ApplyInstructorCourseEditsCommand command)
    {
     

       
            var result = await Mediator.Send(command);


        return Ok(result);
        }
      
    

[HttpGet("lessons/{lessonId}")]
    public async Task<IActionResult> GetLessonByIdForInstructor(Guid lessonId, [FromQuery] Guid instructorId)
    {
        var query = new GetLessonByIdForInstructorQuery(lessonId, instructorId);
        var result = await Mediator.Send(query);
        return Ok(result);
    }
}

