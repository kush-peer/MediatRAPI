using MediatR;
using MediatRApi.Models;

namespace MediatRApi.Commands
{
    public record AddProducts(Product Product): IRequest<Product>;
}
