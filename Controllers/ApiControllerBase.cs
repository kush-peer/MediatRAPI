using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace MediatRAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ApiControllerBase : ControllerBase
    {
        private ISender _sender;
        private IPublisher _publisher;
        protected ISender Sender => _sender ??= HttpContext.RequestServices.GetService<ISender>();
        protected IPublisher Publisher => _publisher ??= HttpContext.RequestServices.GetService<IPublisher>();
    }
}
