using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Domain.Entities.Catalog.Dtos.Get;

namespace FlexBook.Application.Features.Core.Lessons;
public class GetLessonsBySectionIdQueryHandler : IRequestHandler<GetLessonsBySectionIdQuery, TResponse<List<GetLessonAfterLoginDto>>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetLessonsBySectionIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse<List<GetLessonAfterLoginDto>>> Handle(GetLessonsBySectionIdQuery request, CancellationToken cancellationToken)
    {
        var lessons = await _unitOfWork.LessonRepository.GetLessonsBySectionIdAsync(request.SectionId, cancellationToken);

        if (lessons == null || !lessons.Any())
            return TResponse<List<GetLessonAfterLoginDto>>.Failure(new[] { "No lessons found for the specified section." });

        var lessonDtos = lessons.Select(lesson => new GetLessonAfterLoginDto
        {
            Id = lesson.Id,
            NameAr = lesson.NameAr,
            NameEn = lesson.NameEn,
            DescriptionAr = lesson.DescriptionAr,
            DescriptionEn = lesson.DescriptionEn,
            TitleAr = lesson.TitleAr,
            TitleEn = lesson.TitleEn,
            Resources = lesson.Resources,
            HasCodeEditor = lesson.HasCodeEditor,
            CreationDate = lesson.CreationDate,
            //VideoUrl = lesson.VideoUrl,
            //VideoDuration = lesson.VideoDuration,
            CodeEditorLanguage = lesson.CodeEditorLanguage,
            CodeEditorInitialCode = lesson.CodeEditorInitialCode,
            //FileUrl = lesson.FileUrl,
            SectionId = lesson.SectionId,
            //InteractiveContentUrl = lesson.InteractiveContentUrl,
            //HasInteractiveContent = lesson.HasInteractiveContent,
            //ContentType = lesson.ContentType,
            //ImageUrl = lesson.ImageUrl,
            //GifUrl = lesson.GifUrl,
        }).ToList();

        return TResponse<List<GetLessonAfterLoginDto>>.Success(lessonDtos);
    }
}

