using MediatR;

namespace JwtApp.Back.Core.Application.Features.CQRS.Commands
{
    public class CreateProductCommandRequest : IRequest
    {
        private int id;

        public CreateProductCommandRequest(int id)
        {
            this.id = id;
        }

        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
