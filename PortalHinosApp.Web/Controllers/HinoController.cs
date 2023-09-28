using Microsoft.AspNetCore.Mvc;
using PortalHinosApp.Web.Domain.Commands.Requests;
using PortalHinosApp.Web.Domain.Commands.Response;
using PortalHinosApp.Web.Domain.Handlers;

namespace PortalHinosApp.Web.Controllers
{
    [ApiController]
    [Route("/hinos")]
    public class HinoController : ControllerBase
    {
        [HttpPost("")]
        public CreateHinoResponse Create(
            [FromServices] ICreateHinoHandler handler,
            [FromBody] CreateHinoRequest command)
        {
            return handler.Handle(command);
        }
    }
}
