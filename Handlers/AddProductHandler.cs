using MediatR;
using MediatRApi.DataStore;
using MediatRApi.Models;
using MediatRApi.Commands;

namespace MediatRApi.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProducts, Product>
    {
        private readonly FakeDataSample _fakeDataSample;

        public AddProductHandler(FakeDataSample fakeDataSample)
        {
            _fakeDataSample = fakeDataSample;
        }

        public async Task<Product> Handle(AddProducts request, CancellationToken cancellationToken)
        {
            await _fakeDataSample.AddProducts(request.Product);
            return request.Product;
        }
    }
}
