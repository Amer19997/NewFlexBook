using FlexBook.Application.Features.Admin.Sections.Commands;
using FlexBook.Application.Features.Core.Sections.GetSectionById;
using FlexBook.Application.Features.Core.Sections.GetSectionsByCourseIdQuery;
using FlexBook.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SectionController : ApiControllerBase
{
    [HttpGet("{courseId}/GetSectionsByCourseId")]
    public async Task<IActionResult> GetSectionsByCourseId(Guid courseId)
    {
        var query = new GetSectionsByCourseIdQuery(courseId);
        var result = await Mediator.Send(query);

        if (!result.success)
        {
            return NotFound(result.Message);
        }

        return Ok(result);
    }

    // GET: api/Sections/{id}
    [HttpGet("{sectionId}/GetSectionById")]
    public async Task<IActionResult> GetSectionById(Guid id)
    {
        var result = await Mediator.Send(new GetSectionByIdQuery(id));
        if (result == null) return NotFound();
        return Ok(result);
    }
    // POST: api/Sections
    [HttpPost("AddSection")]
    public async Task<IActionResult> CreateSection([FromBody] AddSectionCommand command)
    {
        var result = await Mediator.Send(command);
        return Ok(result);
    }
}
