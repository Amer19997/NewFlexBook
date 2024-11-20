using System;
using System.Threading;
using System.Threading.Tasks;
using FlexBook.Application.Common.Interfaces;
using FlexBook.Application.Common.Models;
using FlexBook.Application.Features.StaticPages.AcademicIntegrity.Commands;
using FlexBook.Domain;
using MediatR;

namespace FlexBook.Application.Features.StaticPages.AcademicIntegrity.Handlers
{
    public class DeleteAcademicIntegrityHandler : IRequestHandler<DeleteAcademicIntegrityCommand, TResponse<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteAcademicIntegrityHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TResponse<bool>> Handle(DeleteAcademicIntegrityCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // Retrieve the AcademicIntegrity entity from the database
                var academicIntegrity = await _unitOfWork.AcademicIntegrityrRepository.FindById(request.Id, cancellationToken);

                if (academicIntegrity == null)
                {
                    return TResponse<bool>.Failure(
                        new[] { "Academic Integrity entry not found" },
                        "Academic Integrity entry not found",
                        404
                    );
                }

                // Remove the entry
                _unitOfWork.AcademicIntegrityrRepository.Remove(academicIntegrity);
                await _unitOfWork.CommitAsync(cancellationToken);

                return TResponse<bool>.Success(true, "Academic Integrity entry deleted successfully");
            }
            catch (Exception ex)
            {
                return TResponse<bool>.Failure(new[] { "Error deleting Academic Integrity entry" }, ex.Message);
            }
        }
    }
}
