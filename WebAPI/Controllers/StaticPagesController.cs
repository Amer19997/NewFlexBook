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
using FlexBook.Application.Features.StaticPages.StudentStories.Queries;
using FlexBook.Application.Features.StaticPages.StudentStories.Commands;
using FlexBook.Application.Features.StaticPages.AuthorizingTeamMembers.Commands;
using FlexBook.Application.Features.StaticPages.Research.Commands;
using FlexBook.Application.Features.StaticPages.Research.Queries;
using FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Commands;
using FlexBook.Application.Features.StaticPages.InstructorSuccessStories.Queries;
using FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Commands;
using FlexBook.Application.Features.StaticPages.StudentsGettingStarted.Queries;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Commands;
using FlexBook.Application.Features.StaticPages.InstructorCommunity.Queries;
using FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Commands;
using FlexBook.Application.Features.StaticPages.EvaluatingAdopting.Queries;
using FlexBook.Application.Features.StaticPages.AboutUs.Commands;
using FlexBook.Application.Features.StaticPages.AboutUs.Queries;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StaticPagesController : ApiControllerBase
{
    [HttpGet("GetAcademicIntegrityEntries")]
    [ProducesResponseType(typeof(TResponse<IPagedList<AcademicIntegrityDto>>), 200)]
    public async Task<IActionResult> GetAcademicIntegrityEntries(
      [FromQuery] string search = "",
      [FromQuery] int pageNumber = 1,
      [FromQuery] int pageSize = 10,
      [FromQuery] string sortBy = "CreatedAt",
      [FromQuery] string sortDirection = "asc")
    {
        var query = new GetAcademicIntegrityListQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Get a specific Academic Integrity entry by ID
    /// </summary>
    [HttpGet("GetAcademicIntegrityById")]
    [ProducesResponseType(typeof(TResponse<AcademicIntegrityDto>), 200)]
    public async Task<IActionResult> GetAcademicIntegrityById([FromQuery] Guid id)
    {
        var query = new GetAcademicIntegrityByIdQuery(id);
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Add a new Academic Integrity entry
    /// </summary>
    [HttpPost("CreateAcademicIntegrityEntry")]
    [ProducesResponseType(typeof(TResponse<AcademicIntegrityDto>), 201)]
    public async Task<IActionResult> CreateAcademicIntegrityEntry([FromForm] CreateAcademicIntegrityCommand command)
    {
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Update an existing Academic Integrity entry
    /// </summary>
    [HttpPut("UpdateAcademicIntegrityEntry")]
    [ProducesResponseType(typeof(TResponse<AcademicIntegrityDto>), 200)]
    public async Task<IActionResult> UpdateAcademicIntegrityEntry([FromForm] UpdateAcademicIntegrityCommand command)
    {
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Delete an Academic Integrity entry
    /// </summary>
    [HttpDelete("DeleteAcademicIntegrityEntry")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteAcademicIntegrityEntry([FromQuery] Guid id)
    {
        var command = new DeleteAcademicIntegrityCommand(id);
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }
    /// <summary>
    /// Get a paginated list of research entries
    /// </summary>
    [HttpGet("GetResearchEntries")]
    [ProducesResponseType(typeof(TResponse<IPagedList<ResearchEntryDto>>), 200)]
    public async Task<IActionResult> GetResearchEntries(
        [FromQuery] string search = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "LastUpdated",
        [FromQuery] string sortDirection = "asc")
    {
        var query = new GetResearchEntriesQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Get a research entry by ID
    /// </summary>
    [HttpGet("GetResearchEntryById")]
    [ProducesResponseType(typeof(TResponse<ResearchEntryDto>), 200)]
    public async Task<IActionResult> GetResearchEntryById(Guid id)
    {
        var query = new GetResearchEntryByIdQuery(id);
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Create a new research entry
    /// </summary>
    [HttpPost("CreateResearchEntry")]
    [ProducesResponseType(typeof(TResponse<ResearchEntryDto>), 201)]
    public async Task<IActionResult> CreateResearchEntry([FromForm] CreateResearchEntryCommand command)
    {
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Update an existing research entry
    /// </summary>
    [HttpPut("UpdateResearchEntry")]
    [ProducesResponseType(typeof(TResponse<ResearchEntryDto>), 200)]
    public async Task<IActionResult> UpdateResearchEntry(Guid id, [FromForm] UpdateResearchEntryCommand command)
    {
        if (id != command.Id)
            return BadRequest(new { Error = "The provided ID does not match the entity ID." });

        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }

    /// <summary>
    /// Delete a research entry
    /// </summary>
    [HttpDelete("DeleteResearchEntry")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteResearchEntry(Guid id)
    {
        var command = new DeleteResearchEntryCommand { Id=id };
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }
    [HttpPost("GetAuthorizingTeamMembers")]
    [ProducesResponseType(typeof(TResponse<IPagedList<AuthorizingTeamMemberDto>>), 200)]
    public async Task<IActionResult> GetAuthorizingTeamMembers(
       [FromQuery] string search = "",
       [FromQuery] int pageNumber = 1,
       [FromQuery] int pageSize = 10,
       [FromQuery] string sortBy = "LastUpdated",
       [FromQuery] string sortDirection = "asc")
    {
        var query = new GetAuthorizingTeamMembersQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    } /// <summary>
      /// Get Authorizing Team Member by ID
      /// </summary>
    [HttpGet("GetAuthorizingTeamMemberById")]
    public async Task<IActionResult> GetAuthorizingTeamMemberById([FromRoute] Guid id)
    {
        var query = new GetAuthorizingTeamMemberByIdQuery(id);
        var response = await Mediator.Send(query);
        if (response.success)
            return Ok(response);
        return BadRequest(response);

    } /// <summary>
      /// Add a new Authorizing Team Member
      /// </summary>
    [HttpPost("AddAuthorizingTeamMember")]
    public async Task<IActionResult> AddAuthorizingTeamMember([FromForm] CreateAuthorizingTeamMemberCommand command)
    {
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);
    } /// <summary>
      /// Update an existing Authorizing Team Member
      /// </summary>
    [HttpPut("UpdateAuthorizingTeamMember")]
    public async Task<IActionResult> UpdateAuthorizingTeamMember([FromRoute] Guid id, [FromForm] UpdateAuthorizingTeamMemberCommand command)
    {
        if (id != command.Id)
            return BadRequest("The provided ID does not match the entity ID.");

        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);
        return BadRequest(response);

    }

    /// <summary>
    /// Delete an Authorizing Team Member
    /// </summary>
    [HttpDelete("DeleteAuthorizingTeamMember")]
    public async Task<IActionResult> DeleteAuthorizingTeamMember([FromRoute] Guid id)
    {
        var command = new DeleteAuthorizingTeamMemberCommand(id);
        var response = await Mediator.Send(command);

          if (response.success)
            return Ok(response);
        return BadRequest(response);
    }
    /// <summary>
    /// Get a paginated list of student success stories
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(TResponse<IPagedList<StudentSuccessStoryDto>>), 200)]
    public async Task<IActionResult> GetStudentSuccessStories(
        [FromQuery] string search = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "LastUpdated",
        [FromQuery] string sortDirection = "asc")
    {
        var query = new GetStudentSuccessStoriesQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);
        if (response.success)
            return Ok(response);
        return BadRequest(response);
    }
    /// <summary>
    /// Create a new student success story
    /// </summary>
    [HttpPost]
    [ProducesResponseType(typeof(TResponse<StudentSuccessStoryDto>), 201)]
    public async Task<IActionResult> CreateStudentSuccessStory([FromForm] CreateStudentSuccessStoryCommand command)
    {
        var response = await Mediator.Send(command);
     return Ok(response);
    }
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(TResponse<StudentSuccessStoryDto>), 200)]
    public async Task<IActionResult> GetStudentSuccessStoryById(Guid id)
    {
        var query = new GetStudentSuccessStoryByIdQuery(id);
        var response = await Mediator.Send(query);
      
            return Ok(response);
        
    }
    [HttpPut("{id:guid}")]
    [ProducesResponseType(typeof(TResponse<StudentSuccessStoryDto>), 200)]
    public async Task<IActionResult> UpdateStudentSuccessStory(Guid id, [FromForm] UpdateStudentSuccessStoryCommand command)
    {
 
        var response = await Mediator.Send(command);
             return Ok(response);
     }
    [HttpDelete("{id:guid}")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteStudentSuccessStory(Guid id)
    {
        var command = new DeleteStudentSuccessStoryCommand(id);
        var response = await Mediator.Send(command);
         
            return Ok(response);
        ;
    }
    /// <summary>
    /// Get a paginated list of authorizing team members
    /// </summary>
    /// 



    // --------------------------------------------------
    // Students Getting Started Endpoints
    // --------------------------------------------------

    /// <summary>
    /// Get a paginated list of Students Getting Started articles
    /// </summary>
    [HttpGet("students-getting-started")]
    [ProducesResponseType(typeof(TResponse<IPagedList<StudentsGettingStartedArticleDto>>), 200)]
    public async Task<IActionResult> GetStudentsGettingStartedArticles(
        [FromQuery] string search = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "UpdatedAt",
        [FromQuery] string sortDirection = "desc")
    {
        var query = new GetStudentsGettingStartedArticlesQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    /// <summary>
    /// Get a specific Students Getting Started article by ID
    /// </summary>
    [HttpGet("students-getting-started/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<StudentsGettingStartedArticleDto>), 200)]
    public async Task<IActionResult> GetStudentsGettingStartedArticleById(Guid id)
    {
        var query = new GetStudentsGettingStartedArticleByIdQuery(id);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    /// <summary>
    /// Create a new Students Getting Started article
    /// </summary>
    [HttpPost("students-getting-started")]
    [ProducesResponseType(typeof(TResponse<object>), 201)]
    public async Task<IActionResult> CreateStudentsGettingStartedArticle([FromForm] CreateStudentsGettingStartedArticleCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
            }
    /// <summary>
    /// Update a specific Students Getting Started article
    /// </summary>
    [HttpPut("students-getting-started/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<StudentsGettingStartedArticleDto>), 200)]
    public async Task<IActionResult> UpdateStudentsGettingStartedArticle(Guid id, [FromForm] UpdateStudentsGettingStartedArticleCommand command)
    {
        if (id != command.Id)
            return BadRequest(new { Error = "The provided ID does not match the entity ID." });

        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }

    /// <summary>
    /// Delete a specific Students Getting Started article
    /// </summary>
    [HttpDelete("students-getting-started/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteStudentsGettingStartedArticle(Guid id)
    {
        var command = new DeleteStudentsGettingStartedArticleCommand(id);
        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }

    // --------------------------------------------------
    // Instructor Success Stories Endpoints
    // --------------------------------------------------

    /// <summary>
    /// Get a paginated list of Instructor Success Stories
    /// </summary>
    [HttpGet("instructor-success-stories")]
    [ProducesResponseType(typeof(TResponse<IPagedList<InstructorSuccessStoryDto>>), 200)]
    public async Task<IActionResult> GetInstructorSuccessStories(
        [FromQuery] string search = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "CreatedAt",
        [FromQuery] string sortDirection = "desc")
    {
        var query = new GetInstructorSuccessStoriesQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    /// <summary>
    /// Get a specific Instructor Success Story by ID
    /// </summary>
    [HttpGet("instructor-success-stories/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<InstructorSuccessStoryDto>), 200)]
    public async Task<IActionResult> GetInstructorSuccessStoryById(Guid id)
    {
        var query = new GetInstructorSuccessStoryByIdQuery(id);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    /// <summary>
    /// Create a new Instructor Success Story
    /// </summary>
    [HttpPost("instructor-success-stories")]
    [ProducesResponseType(typeof(TResponse<InstructorSuccessStoryDto>), 201)]
    public async Task<IActionResult> CreateInstructorSuccessStory([FromForm] CreateInstructorSuccessStoryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Update a specific Instructor Success Story
    /// </summary>
    [HttpPut("instructor-success-stories/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<InstructorSuccessStoryDto>), 200)]
    public async Task<IActionResult> UpdateInstructorSuccessStory(Guid id, [FromForm] UpdateInstructorSuccessStoryCommand command)
    {
        if (id != command.Id)
            return BadRequest(new { Error = "The provided ID does not match the entity ID." });

        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }

    /// <summary>
    /// Delete a specific Instructor Success Story
    /// </summary>
    [HttpDelete("instructor-success-stories/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteInstructorSuccessStory(Guid id)
    {
        var command = new DeleteInstructorSuccessStoryCommand(id);
        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }
    // --------------------------------------------------
    // Instructor Community Endpoints
    // --------------------------------------------------

    [HttpGet("GetInstructorCommunityEntries")]
    [ProducesResponseType(typeof(TResponse<IPagedList<InstructorCommunityEntryDto>>), 200)]
    public async Task<IActionResult> GetInstructorCommunityEntries(
        [FromQuery] string search = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "UpdatedAt",
        [FromQuery] string sortDirection = "desc")
    {
        var query = new GetInstructorCommunityEntriesQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    [HttpGet("GetInstructorCommunityEntryById")]
    [ProducesResponseType(typeof(TResponse<InstructorCommunityEntryDto>), 200)]
    public async Task<IActionResult> GetInstructorCommunityEntryById(Guid id)
    {
        var query = new GetInstructorCommunityEntryByIdQuery(id);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    [HttpPost("CreateInstructorCommunityEntry")]
    [ProducesResponseType(typeof(TResponse<InstructorCommunityEntryDto>), 201)]
    public async Task<IActionResult> CreateInstructorCommunityEntry([FromForm] CreateInstructorCommunityEntryCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    [HttpPut("UpdateInstructorCommunityEntry")]
    [ProducesResponseType(typeof(TResponse<InstructorCommunityEntryDto>), 200)]
    public async Task<IActionResult> UpdateInstructorCommunityEntry(Guid id, [FromForm] UpdateInstructorCommunityEntryCommand command)
    {
        if (id != command.Id)
            return BadRequest(new { Error = "The provided ID does not match the entity ID." });

        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }

    [HttpDelete("DeleteInstructorCommunityEntry")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteInstructorCommunityEntry(Guid id)
    {
        var command = new DeleteInstructorCommunityEntryCommand(id);
        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }
    // --------------------------------------------------
    // Evaluating & Adopting Endpoints
    // --------------------------------------------------

    [HttpGet("evaluating-adopting")]
    [ProducesResponseType(typeof(TResponse<IPagedList<EvaluatingAdoptingArticleDto>>), 200)]
    public async Task<IActionResult> GetEvaluatingAdoptingArticles(
        [FromQuery] string search = "",
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10,
        [FromQuery] string sortBy = "UpdatedAt",
        [FromQuery] string sortDirection = "desc")
    {
        var query = new GetEvaluatingAdoptingArticlesQuery(search, pageNumber, pageSize, sortBy, sortDirection);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    [HttpGet("evaluating-adopting/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<EvaluatingAdoptingArticleDto>), 200)]
    public async Task<IActionResult> GetEvaluatingAdoptingArticleById(Guid id)
    {
        var query = new GetEvaluatingAdoptingArticleByIdQuery(id);
        var response = await Mediator.Send(query);
        return response.success ? Ok(response) : BadRequest(response);
    }

    [HttpPost("evaluating-adopting")]
    [ProducesResponseType(typeof(TResponse<EvaluatingAdoptingArticleDto>), 201)]
    public async Task<IActionResult> CreateEvaluatingAdoptingArticle([FromForm] CreateEvaluatingAdoptingArticleCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    [HttpPut("evaluating-adopting/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<EvaluatingAdoptingArticleDto>), 200)]
    public async Task<IActionResult> UpdateEvaluatingAdoptingArticle(Guid id, [FromForm] UpdateEvaluatingAdoptingArticleCommand command)
    {
        if (id != command.Id)
            return BadRequest(new { Error = "The provided ID does not match the entity ID." });

        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }

    [HttpDelete("evaluating-adopting/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteEvaluatingAdoptingArticle(Guid id)
    {
        var command = new DeleteEvaluatingAdoptingArticleCommand(id);
        var response = await Mediator.Send(command);
        return response.success ? Ok(response) : BadRequest(response);
    }



    /// <summary>
    /// Get all About Us Sections with their Testimonials
    /// </summary>
    [HttpGet("about-us")]
    [ProducesResponseType(typeof(TResponse<List<AboutUsPageDto>>), 200)]
    public async Task<IActionResult> GetAllAboutUsPages()
    {
        var query = new GetAllAboutUsPagesQuery();
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);

        return BadRequest(response);
    }

    /// <summary>
    /// Get a specific About Us Section by ID (with Testimonials)
    /// </summary>
    [HttpGet("about-us/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<AboutUsPageDto>), 200)]
    public async Task<IActionResult> GetAboutUsPage(Guid id)
    {
        var query = new GetAboutUsPageQuery(id);
        var response = await Mediator.Send(query);

        if (response.success)
            return Ok(response);

        return BadRequest(response);
    }

    /// <summary>
    /// Create a new About Us Section with Testimonials
    /// </summary>
    [HttpPost("about-us")]
    [ProducesResponseType(typeof(TResponse<object>), 201)]
    public async Task<IActionResult> CreateAboutUsPage([FromForm] CreateAboutUsPageCommand command)
    {
        var response = await Mediator.Send(command);
        return Ok(response);
    }

    /// <summary>
    /// Update an existing About Us Section with Testimonials
    /// </summary>
    [HttpPut("about-us/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<AboutUsPageDto>), 200)]
    public async Task<IActionResult> UpdateAboutUsPage(Guid id, [FromForm] UpdateAboutUsPageCommand command)
    {
        if (id != command.Id)
            return BadRequest(new { Error = "The provided ID does not match the command ID." });

        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);

        return BadRequest(response);
    }

    /// <summary>
    /// Delete an About Us Section with Testimonials
    /// </summary>
    [HttpDelete("about-us/{id:guid}")]
    [ProducesResponseType(typeof(TResponse<bool>), 200)]
    public async Task<IActionResult> DeleteAboutUsPage(Guid id)
    {
        var command = new DeleteAboutUsPageCommand(id);
        var response = await Mediator.Send(command);

        if (response.success)
            return Ok(response);

        return BadRequest(response);
    }
}







