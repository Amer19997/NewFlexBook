using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexBook.Application.Common.Models;
using FlexBook.Domain.Entities.Catalog.Dtos;
using FlexBook.Domain;
using MediatR;
using FlexBook.Application.Common.Helpers;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Features.Admin.Lessons.Commands;
using Microsoft.Extensions.Options;
using FlexBook.Domain.Entities.Catalog;

namespace FlexBook.Application.Features.Admin.Sections.Commands;




    public class AddSectionCommandHandler : IRequestHandler<AddSectionCommand, TResponse<SectionDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAccountService _accountService;
        private readonly ITokenService _tokenService;
        private readonly IResourceService _resourceService;
        private readonly AppSettings _appSettings;
        private readonly IMediator _mediator;

        public AddSectionCommandHandler(IUnitOfWork unitOfWork,
             IAccountService accountService,
             ITokenService tokenService,
             IOptions<AppSettings> appSettings,
             IResourceService resourceService,
             IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _accountService = accountService;
            _tokenService = tokenService;
            _appSettings = appSettings.Value;
            _resourceService = resourceService;
            _mediator = mediator;
        }

        public async Task<TResponse<SectionDto>> Handle(AddSectionCommand request, CancellationToken cancellationToken)
    {
        var section = new Section
        {
            Id = Guid.NewGuid(),
            TitleAr = request.TitleAr,
            TitleEn = request.TitleEn,
            CourseId = request.CourseId
        };

        _unitOfWork.SectionRepository.Add(section,cancellationToken);
        await _unitOfWork.CommitAsync(cancellationToken);

        var sectionDto = new SectionDto
        {
            Id = section.Id,
            TitleAr = section.TitleAr,
            TitleEn = section.TitleEn,
            CourseId = section.CourseId
        };

        return TResponse<SectionDto>.Success(sectionDto);
    }
}