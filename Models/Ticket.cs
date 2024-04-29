using System;
using System.ComponentModel.DataAnnotations;

namespace TicketProyectoP1.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [Required]
        public int EventoId { get; set; }
        public virtual Evento Evento { get; set; } 

        [Required(ErrorMessage = "Es necesario especificar un precio para el ticket.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Precio { get; set; }

    }
}
