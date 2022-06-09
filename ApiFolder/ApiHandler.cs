using MediatR;

namespace MediatRAPI.ApiFolder
{
    public class ApiHandler : IRequestHandler<ApiRequestModel, ApiResponseModel>
    {
        public async Task<ApiResponseModel> Handle(ApiRequestModel request, CancellationToken cancellationToken)
        {
            var response = $"number : - {request.Number}";
            return new ApiResponseModel
            {
                Response = response
            };
        }
    }
}
