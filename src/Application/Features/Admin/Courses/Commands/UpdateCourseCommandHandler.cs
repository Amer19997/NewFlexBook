using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.LookUps;
using FlexBook.Domain.Entities.Catalog.Dtos;
using MediatR;
using FlexBook.Domain;

namespace FlexBook.Application.Features.Admin.Courses.Commands;

public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, TResponse<GetAllCourseDetails>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IResourceService _resourceService;
    private readonly IFileUploadService _fileUploadService;
    public UpdateCourseCommandHandler(IUnitOfWork unitOfWork, IResourceService resourceService, IFileUploadService fileUploadService)
    {
        _unitOfWork = unitOfWork;
        _resourceService = resourceService;
        _fileUploadService = fileUploadService;
    }

    public async Task<TResponse<GetAllCourseDetails>> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        try
        {
            // Retrieve course by ID
            //var course = await _unitOfWork.CouresRepository.GetByIdAsync(request.CourseId, cancellationToken);
            //if (course == null)
            //{
            //    return TResponse<GetAllCourseDetails>.Failure(
            //        new[] { _resourceService.GetMessage("CourseNotFound") },
            //        _resourceService.GetError("Unable to update a non-existent course."),
            //        404);
            //}
            // Retrieve course with sections, lessons, and quizzes
            var course = await _unitOfWork.CouresRepository.GetByIdAsync(
                c => c.Id == request.CourseId,
                "Universities,Faculties,Departments,Specializations,Sections,Sections.Lessons,Sections.Quizzes",
                cancellationToken);

            if (course == null)
            {
                return TResponse<GetAllCourseDetails>.Failure(
                    new[] { _resourceService.GetError("Course not found.") },
                    _resourceService.GetError("Course not found."),
                    404);
            }
            string coverphotopath = string.Empty
           ;
            if (request.CoverPhoto != null)
            {
                coverphotopath = await _fileUploadService.UploadFileAsync(request.CoverPhoto);
            }
            // Update course properties
            course.NameAr = request.NameAr;
            course.NameEn = request.NameEn;
            course.DiscriptionAr = request.DiscriptionAr;
            course.DiscriptionEn = request.DiscriptionEn;
            course.CategoryId = request.CategoryId;
            course.TopicId = request.TopicId;
            course.CoverPhoto = coverphotopath;
            course.Code = request.Code;
            if (request.UniversityIds.Any())
            {
                // Validate the requested UniversityIds
                var universities = await _unitOfWork.UnivesityRepository.GetByIdsAsync(request.UniversityIds, cancellationToken);
                if (universities.Count() != request.UniversityIds.Count)
                {
                    return TResponse<GetAllCourseDetails>.Failure(
                        new[] { _resourceService.GetMessage("InvalidUniversityIds") },
                        _resourceService.GetError("Some provided university IDs are invalid."),
                        400);
                }

                // Clear existing Universities and replace with new ones
                course.Universities.Clear();
                foreach (var university in universities)
                {
                    course.Universities.Add(university);
                }
            }

            if (request.FacultyIds.Any())
            {
                // Validate the requested FacultyIds
                var faculties = await _unitOfWork.FacultyRepository.GetByIdsAsync(request.FacultyIds, cancellationToken);
                if (faculties.Count() != request.FacultyIds.Count)
                {
                    return TResponse<GetAllCourseDetails>.Failure(
                        new[] { _resourceService.GetMessage("InvalidFacultyIds") },
                        _resourceService.GetError("Some provided faculty IDs are invalid."),
                        400);
                }

                // Clear existing Faculties and replace with new ones
                course.Faculties.Clear();
                foreach (var faculty in faculties)
                {
                    course.Faculties.Add(faculty);
                }
            }

            if (request.DepartmentIds.Any())
            {
                // Validate the requested DepartmentIds
                var departments = await _unitOfWork.DepartmentRepository.GetByIdsAsync(request.DepartmentIds, cancellationToken);
                if (departments.Count() != request.DepartmentIds.Count)
                {
                    return TResponse<GetAllCourseDetails>.Failure(
                        new[] { _resourceService.GetMessage("InvalidDepartmentIds") },
                        _resourceService.GetError("Some provided department IDs are invalid."),
                        400);
                }

                // Clear existing Departments and replace with new ones
                course.Departments.Clear();
                foreach (var department in departments)
                {
                    course.Departments.Add(department);
                }
            }

            if (request.SpecializationIds.Any())
            {
                // Validate the requested SpecializationIds
                var specializations = await _unitOfWork.SpecializationRepository.GetByIdsAsync(request.SpecializationIds, cancellationToken);
                if (specializations.Count() != request.SpecializationIds.Count)
                {
                    return TResponse<GetAllCourseDetails>.Failure(
                        new[] { _resourceService.GetMessage("InvalidSpecializationIds") },
                        _resourceService.GetError("Some provided specialization IDs are invalid."),
                        400);
                }

                // Clear existing Specializations and replace with new ones
                course.Specializations.Clear();
                foreach (var specialization in specializations)
                {
                    course.Specializations.Add(specialization);
                }
            }
            // Save changes
            //course.UpdatedAt = DateTime.UtcNow;
            _unitOfWork.CouresRepository.Update(course);
            await _unitOfWork.CommitAsync(cancellationToken);

            // Prepare response DTO
            var responseDto = new GetAllCourseDetails
            {
                Id = course.Id,
                NameAr = course.NameAr,
                NameEn = course.NameEn,
                DiscriptionAr = course.DiscriptionAr,
                DiscriptionEn = course.DiscriptionEn,
                CategoryId = course.CategoryId,
                TopicId = course.TopicId,
                CoverPhoto = course.CoverPhoto,
                Code = course.Code,
                UniversityIds = course.Universities.Select(u => u.Id).ToList(),
                FacultyIds = course.Faculties.Select(f => f.Id).ToList(),
                DepartmentIds = course.Departments.Select(d => d.Id).ToList(),
                SpecializationIds = course.Specializations.Select(s => s.Id).ToList()
            };

            return TResponse<GetAllCourseDetails>.Success(responseDto, _resourceService.GetMessage("CourseUpdatedSuccessfully"));
        }
        catch (Exception ex)
        {
            return TResponse<GetAllCourseDetails>.Failure(
                new[] { _resourceService.GetMessage("ErrorUpdatingCourse") },
                ex.Message,
                500);
        }
    }
}
