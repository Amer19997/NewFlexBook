using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourseById;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCourses;
using FlexBook.Application.Features.LookUps.Courses.Queries.GetCoursesBasicListQuery;
using FlexBook.Application.Features.LookUps.Topics.Queries.GetTopicsList;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FlexBook.Application.Features.Core.Courses.CourseContent.Queries;
using FlexBook.Application.Features.Admin.Sections.Commands;
using FlexBook.Application.Features.Core.Sections.GetSectionById;
using FlexBook.Application.Features.Core.Lessons.GetLessonById.Queries;
using FlexBook.Application.Features.Admin.Lessons.Commands;
using FlexBook.Application.Features.Admin.Courses.Commands;
using FlexBook.Application.Features.Admin.Quiz.Commands;
using FlexBook.Application.Features.Core.Quizes;
using FlexBook.Application.Features.Admin.Questions;
//using FlexBook.Application.Features.Core.Video;
using FlexBook.Application.Features.Core;
using FlexBook.Application.Features.Admin;
using FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;
using FlexBook.Application.Features.Core.Courses.RecommendedCourses;
using FlexBook.Application.Features.Core.Classes.Quieries.CoursesOfJoinedClasses;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Queries;
using FlexBook.Domain.Entities.StaticPages.Dtos;
using X.PagedList;

namespace WebAPI.Controllers.Catalog;
[Route("api/[controller]")]
[ApiController]
public class CatalogController : ApiControllerBase
{
    //[HttpGet("UserInterests")]
    //public async Task<ActionResult<TResponse<GetCoursesBasicListResult>>> GetBasicCourseList()
    //{
    //    return Ok(await Mediator.Send(new GetCoursesBasicListQuery()));
    //}
    [HttpGet("GetTopics")]
    public async Task<ActionResult<TResponse<GetTopicsResult>>> GetTopicsWithCourses()
    {
        var result = await Mediator.Send(new GetTopicsWithCoursesQuery());
        return Ok(result);
    }
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
    [HttpPost("AddLesson")]
    public async Task<IActionResult> AddLesson([FromForm] AddLessonCommand command)
    {
        var response = await Mediator.Send(command);

        if (response.success)
        {
            return Ok(response);
        }
        else
        {
            return BadRequest(response.Message);
        }
    }
   
    [HttpGet("GetCourseByID/{courseId}")]
    [ProducesResponseType(typeof(TResponse<CourseDetailDTO>), StatusCodes.Status200OK)]  // Success response
    [ProducesResponseType(typeof(TResponse<CourseDetailDTO>), StatusCodes.Status404NotFound)]  // Not found response
    public async Task<IActionResult> GetCourseById(Guid courseId,Guid? classId)
    {
        var query = new GetCourseByIdQuery(courseId, classId);

        // Send the query using Mediator
        var result = await Mediator.Send(query);

        // Check the result using the 'Success' property (without parentheses)
     

        // Return success response
        return Ok(result);
    }

    [HttpGet("GetAvailableCoursesForUser")]
    [ProducesResponseType(typeof(TResponse<List<CourseDto>>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(TResponse<List<CourseDto>>), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAvailableCoursesForUser(
        [FromQuery] string keyword = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "NameEn",
        [FromQuery] string sortDirection = "asc")
    {
        // Build the query object with parameters from the request
        var query = new GetAvailableCoursesQuery
        {
            Keyword = keyword,
            PageNumber = pageNumber,
            PageSize = pageSize,
            SortBy = sortBy,
            SortDirection = sortDirection
        };

        var result = await Mediator.Send(query);

  
        return Ok(result);
    }
    [HttpGet("GetRecommendedCoursesForUser")]
    public async Task<IActionResult> GetRecommendedCourses([FromQuery] GetRecommendedCoursesQuery query)
    {
        var result = await Mediator.Send(query);


        return Ok(result);
    }
    [HttpGet("JoinedClassesCourses")]
    public async Task<IActionResult> GetCoursesOfJoinedClasses()
    {
        var query = new GetCoursesOfJoinedClassesQuery();
        var result = await Mediator.Send(query);


        return Ok(result);
    }
}

