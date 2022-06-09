using MediatR;
using MediatRApi.Models;

namespace MediatRApi.Queries
{

    public record GetProducts() : IRequest<IEnumerable<Product>>;

}
