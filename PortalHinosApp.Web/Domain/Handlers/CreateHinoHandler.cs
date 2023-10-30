using PortalHinosApp.Web.Domain.Commands.Requests;
using PortalHinosApp.Web.Domain.Commands.Response;

namespace PortalHinosApp.Web.Domain.Handlers
{
    public class CreateHinoHandler : ICreateHinoHandler
    {
        public CreateHinoResponse Handle(CreateHinoRequest request)
        {
            //verificar se o hino já se encontra cadastrado
            //validar os dados
            //iserir o hino
            //retorna resultado

            return new CreateHinoResponse
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Letra = request.Letra,
                Inclusao = DateTime.Now
            };
        }
    }
}
