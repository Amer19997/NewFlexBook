using FlexBook.Application.Features.Admin.Commnds.CreateInstructor;
using FlexBook.Application.Features.Admin.Commnds.DashBoardLoginCommand;
using FlexBook.WebAPI.Controllers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.DashBoard;
[Route("api/[controller]")]
[ApiController]
public class ManageInstructorsController : ApiControllerBase
{
    // POST: api/instructors
    [HttpPost("{CreateInstructor}")]
    public async Task<IActionResult> CreateInstructor([FromBody] CreateInstructorCommand command)
    {
        var result = await Mediator.Send(command);
        if (!result.success)
        {
            // Return the error response with its status code
            return StatusCode(result.StatusCode, result);
        }
        return Ok(result);
    }

}
