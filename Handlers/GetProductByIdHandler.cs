using MediatR;
using MediatRApi.Queries;
using MediatRApi.Models;
using MediatRApi.DataStore;

namespace MediatRApi.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProducById, Product>
    {
        private readonly FakeDataSample _fakeDataSample;

        public GetProductByIdHandler(FakeDataSample fakeDataSample)
        {
            _fakeDataSample = fakeDataSample;
        }

        public async Task<Product> Handle(GetProducById request, CancellationToken cancellationToken)
        {
            return await this._fakeDataSample.GetProductById(request.Id);
        }
    }
}
