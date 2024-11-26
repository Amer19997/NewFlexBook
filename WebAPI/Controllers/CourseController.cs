using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.Admin.Courses.Commands;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourseById;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourses;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CourseController : ApiControllerBase
{
    // Get courses with optional filters for Topic, Category, and Keyword (with pagination, sorting, and includes)
    [HttpGet("GetCourses")]
    /*  [Authorize(Policy = "createbooks")] */ // Protect this endpoint with the "ViewCourses" policy

    public async Task<IActionResult> GetCourses(
        [FromQuery] Guid? topicId,
        [FromQuery] Guid? categoryId,
        [FromQuery] string keyword = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "NameEn",
        [FromQuery] string sortDirection = "asc"
        /*[FromQuery] string includeProperties = ""*/)
    {
        var query = new GetCoursesQuery(topicId, categoryId, keyword, pageNumber, pageSize, sortBy, sortDirection);
        var result = await Mediator.Send(query);
        return Ok(result);

    }

    [HttpGet("GetCourseByID/{courseId}")]
    [ProducesResponseType(typeof(TResponse<CourseDetailDTO>), StatusCodes.Status200OK)]  // Success response
    [ProducesResponseType(typeof(TResponse<CourseDetailDTO>), StatusCodes.Status404NotFound)]  // Not found response
    public async Task<IActionResult> GetCourseById(Guid courseId)
    {
        var query = new GetCourseByIdQuery(courseId);

        // Send the query using Mediator
        var result = await Mediator.Send(query);

        // Check the result using the 'Success' property (without parentheses)
        //if (!result.success)
        //{
        //    // Return the error response with its status code
        //    return StatusCode(result.StatusCode, result);
        //}

        // Return success response
        return Ok(result);
    }
    // POST: api/course
    [HttpPost("addCourse")]
    public async Task<IActionResult> CreateCourse([FromForm] CreateCourseCommand command, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await Mediator.Send(command, cancellationToken);
        return Ok(result);
        // Return the newly created course details with a Created (201) status code
        //return CreatedAtAction(nameof(GetCourseById), new { id = result.Id }, result);
    }
    [HttpPut("UpdateCourse")]
    public async Task<IActionResult> UpdateCourse(Guid id, [FromForm] UpdateCourseCommand command)
    {
     
        var result = await Mediator.Send(command);


        return Ok(result);
    }
}
