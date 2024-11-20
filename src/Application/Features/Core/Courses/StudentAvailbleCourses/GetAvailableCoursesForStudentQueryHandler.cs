using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.StudentAfterLogin;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos.InstructorAfterLogin;
using Microsoft.EntityFrameworkCore;
using FlexBook.Application.Features.Core.Courses.InstructorCourses.Quireies;

namespace FlexBook.Application.Features.Core.Courses.StudentAvailbleCourses;

public class GetAvailableCoursesForStudentQueryHandler : IRequestHandler<GetAvailableCoursesForStudentQuery, TResponse<List<StudentCourseDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAvailableCoursesForStudentQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<List<StudentCourseDto>>> Handle(GetAvailableCoursesForStudentQuery request, CancellationToken cancellationToken)
    {
        // Retrieve student's affiliation details
        var student = await _unitOfWork.Users.FindById(request.StudentId, cancellationToken);
        //if (student == null) return new List<StudentCourseDto>();
        IQueryable<Course> studentCourses;
        if (student.FacultyId.HasValue && student.SpecializationId.HasValue)
        {
            studentCourses = _unitOfWork.CouresRepository.GetCoursesByConditions(
                student.UniversityId,
                student.FacultyId.Value,       // Faculty must match
                student.DepartmentId,
                student.SpecializationId.Value  // Specialization must match
            );
        }
        else
        {
            studentCourses = _unitOfWork.CouresRepository.GetCoursesByUniversityAndDepartment(
                student.UniversityId,
                student.DepartmentId           // Only filter by university and department (portal case)
            );
        }

        var finalInstructorCourses = await studentCourses.ToListAsync();

        // Map to CourseDto
        var courseDtos = finalInstructorCourses.Select(studentCourse => new StudentCourseDto
        {
            CourseId = studentCourse.Id,
            CourseNameEn = studentCourse.NameEn,
            CourseNameAr = studentCourse.NameAr,
            CourseDescriptionEn = studentCourse.DiscriptionEn,
            CourseDescriptionAr = studentCourse.DiscriptionAr,
            CourseCode = studentCourse.Code,  // Include the unique course code
            CoverPhoto = studentCourse.CoverPhoto  // Ensure the cover photo is returned
        }).ToList();

        return TResponse<List<StudentCourseDto>>.Success(courseDtos);
    }
}