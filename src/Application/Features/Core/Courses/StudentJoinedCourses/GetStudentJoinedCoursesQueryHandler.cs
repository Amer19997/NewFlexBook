using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Exceptions;
using FlexBook.Domain.Entities.Catalog.Dtos.StudentAfterLogin;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos;

namespace FlexBook.Application.Features.Core.Courses.StudentJoinedCourses;
public class GetStudentJoinedCoursesQueryHandler : IRequestHandler<GetStudentJoinedCoursesQuery, List<CourseDto>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetStudentJoinedCoursesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<CourseDto>> Handle(GetStudentJoinedCoursesQuery request, CancellationToken cancellationToken)
    {
        string includeProperties = "Course";

        //// Call GetByIdAsync directly with the set includeProperties
        //var classes = await _unitOfWork.CouresRepository.FindAsync(
        //    includeProperties,
        //    c => c.Id == request.CourseId,  // Filter by CourseId
        //    ,              // Include Sections, Lessons, and Quizzes
        //    cancellationToken);
        //// Fetch all classes the student is enrolled in
        var classes = await _unitOfWork.ClassRepository.FindAsync
            (c => c.Students.Any(s => s.Id == request.StudentId), null,null, null, includeProperties);

        if (classes == null || !classes.Any())
        {
            throw new NotFoundException("No courses found for the student.");
        }

        // Get distinct courses from the classes
        // Get distinct courses from the classes
          // Get distinct courses from the classes
            var courses = classes
                .Where(cls => cls.Course != null) // Ensure the Course property is not null
                .Select(cls => new CourseDto
                {
                    Id = cls.Course.Id,
                    //ClassId = cls.Id,  // Return the ClassId associated with the course
                    NameAr = cls.Course.NameAr,
                    NameEn = cls.Course.NameEn,
                    DiscriptionAr = cls.Course.DiscriptionAr,
                    DiscriptionEn = cls.Course.DiscriptionEn,
                    CoverPhoto = cls.Course.CoverPhoto
                })
                .Distinct()
                .ToList();

        return courses;
        return courses;
    }
}