using MediatR;
using MediatRApi.DataStore;
using MediatRApi.Models;
using MediatRApi.Queries;

namespace MediatRApi.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProducts, IEnumerable<Product>>
    {
        private readonly FakeDataSample _fakeDataSample;
        public GetProductsHandler(FakeDataSample fakeDataSample)
        {
            this._fakeDataSample = fakeDataSample;
        }
        public async Task<IEnumerable<Product>> Handle(GetProducts request, CancellationToken cancellationToken) => await _fakeDataSample.GetAllProducts();
    }
}
