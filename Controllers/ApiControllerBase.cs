using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace MediatRAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ApiControllerBase : ControllerBase
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
    }
}
