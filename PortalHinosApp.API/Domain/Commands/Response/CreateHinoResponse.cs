namespace PortalHinosApp.Web.Domain.Commands.Response
{
    public class CreateHinoResponse
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Letra { get; set; }
        public DateTime Inclusao { get; set; }
    }
}
