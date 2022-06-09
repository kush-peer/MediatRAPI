using MediatR;
using MediatRApi.Models;

namespace MediatRApi.Queries
{
   public record GetProducById(int Id) : IRequest<Product>;
 
}
