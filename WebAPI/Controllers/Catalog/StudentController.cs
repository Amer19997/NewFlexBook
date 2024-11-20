using FlexBook.Application.Features.Core.Courses.StudentAvailbleCourses;
using FlexBook.Application.Features.Core.Courses.StudentJoinedCourses;
using FlexBook.Application.Features.Core.Lessons.GetLessonByIdForStudent;
using FlexBook.WebAPI.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Catalog;
[Route("api/[controller]")]
[ApiController]
public class StudentController : ApiControllerBase
{
    // GET: api/course/available
    [HttpGet("available")]
    public async Task<IActionResult> GetAvailableCoursesForStudent([FromQuery] Guid studentId)
    {
        var query = new GetAvailableCoursesForStudentQuery(studentId);
        var result = await Mediator.Send(query);
        return Ok(result);
    }
    [HttpGet("student-courses/{studentId}")]
    public async Task<IActionResult> GetStudentJoinedCourses(Guid studentId)
    {
        var query = new GetStudentJoinedCoursesQuery { StudentId = studentId };
        var result = await Mediator.Send(query);
        return Ok(result);
    }
    [HttpGet("student/{classId}/lesson/{lessonId}")]
    public async Task<IActionResult> GetLessonByIdForStudent(Guid studentId, Guid classId, Guid lessonId)
    {
        var query = new GetLessonByIdForStudentQuery
        {
            StudentId = studentId,
            ClassId = classId,
            LessonId = lessonId
        };

        var result = await Mediator.Send(query);
        return Ok(result);
    }
}
