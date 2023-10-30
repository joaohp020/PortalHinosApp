namespace PortalHinosApp.Web.Models
{
    public class Hino
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Letra { get; set; }
        public List<string>? Hinos { get; set; }
        public DateTime? Inclusao { get; set; }
    }
}
