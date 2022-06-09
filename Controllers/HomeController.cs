using Microsoft.AspNetCore.Mvc;
using MediatRAPI.ApiFolder;

namespace MediatRAPI.Controllers
{
    public class HomeController : ApiControllerBase
    {
        public HomeController()
        {

        }
        [HttpGet(nameof(ApiController))]
        public async Task<ActionResult<ApiResponseModel>> ApiController(int number)
        {
            try
            {
                var request = new ApiRequestModel { Number = number };
                return await Mediator.Send(request);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
