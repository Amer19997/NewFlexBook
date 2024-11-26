// File: UpdateCourseCommand.cs
using System;
using System.Collections.Generic;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Application.Common.Models;
using Microsoft.AspNetCore.Http;

namespace FlexBook.Application.Features.Admin.Courses.Commands;

public class UpdateCourseCommand : IRequest<TResponse<GetAllCourseDetails>>
{
    public Guid CourseId { get; set; } // ID of the course to update
    public string NameAr { get; set; } = default!;
    public string NameEn { get; set; } = default!;
    public string DiscriptionAr { get; set; } = default!;
    public string DiscriptionEn { get; set; } = default!;
    public Guid CategoryId { get; set; }
    public Guid TopicId { get; set; }
    public IFormFile CoverPhoto { get; set; } = default!;  // URL or path to the cover photo
    public string Code { get; set; } = default!;

    // Relationships
    public List<Guid> UniversityIds { get; set; } = new List<Guid>();
    public List<Guid> FacultyIds { get; set; } = new List<Guid>();
    public List<Guid> DepartmentIds { get; set; } = new List<Guid>();
    public List<Guid> SpecializationIds { get; set; } = new List<Guid>();
}
