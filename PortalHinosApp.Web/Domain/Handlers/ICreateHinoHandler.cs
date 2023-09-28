using PortalHinosApp.Web.Domain.Commands.Requests;
using PortalHinosApp.Web.Domain.Commands.Response;

namespace PortalHinosApp.Web.Domain.Handlers
{
    public interface ICreateHinoHandler
    {
        CreateHinoResponse Handle(CreateHinoRequest request);
    }
}
