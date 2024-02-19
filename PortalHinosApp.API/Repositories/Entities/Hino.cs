using PortalHinosApp.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalHinosApp.API.Repositories.Entities
{
    [Table("hinos")]
    public class Hino
    {
        public Hino()
        {

        }

        public int Id { get; set; }
        [Column("id")]
        public string Nome { get; set; }
        [Column("nome")]
        public string Letra { get; set; }
        [Column("letra")]
        public DateTime Inclusao { get; set; }
        [Column("inclusao")]
        public int Status { get; set; }
        [Column("status")]

        [NotMapped]
        public virtual HinoModel Hinos { get; set; }
    }
}
