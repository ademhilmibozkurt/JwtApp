using JwtApp.Back.Core.Application.Features.CQRS.Commands;
using JwtApp.Back.Core.Application.Interfaces;
using JwtApp.Back.Core.Domain;
using MediatR;

namespace JwtApp.Back.Core.Application.Features.CQRS.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var updated = await _repository.GetByIdAsync(request.Id);
            if (updated != null) 
            {
                updated.Name = request.Name;
                updated.Stock = request.Stock;
                updated.Price = request.Price;
                updated.CategoryId = request.CategoryId;

                await _repository.UpdateAsync(updated);
            }

            return Unit.Value;
        }
    }
}
