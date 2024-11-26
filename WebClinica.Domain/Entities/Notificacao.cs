using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.Domain.Entities
{
    public class Notificacao
    {
        public int NotificacaoID { get; set; }

        [Required]
        public int ConsultaID { get; set; }

        [ForeignKey("ConsultaID")]
        public Consulta Consulta { get; set; } = null!;

        [Required, StringLength(20)]
        public string Meio { get; set; } = string.Empty; // Ex.: SMS, Email

        public DateTime DataEnvio { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string Status { get; set; } = "Pendente";
    }
}