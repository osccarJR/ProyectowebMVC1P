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
        public virtual Evento Evento { get; set; } // Asegúrate de que exista en la BD

        [Required]
        public decimal Precio { get; set; }

    }
}
