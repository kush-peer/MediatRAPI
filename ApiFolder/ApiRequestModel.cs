using MediatR;

namespace MediatRAPI.ApiFolder
{
    public class ApiRequestModel : IRequest<ApiResponseModel>
    {
        public int Number { get; set; }
    }
}
