using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TicketProyectoP1.Models
{
    public class Evento
    {
        [Key]
        public int EventoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        public DateTime FechaEvento { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [StringLength(200)]
        public string Ubicacion { get; set; }

        public string ImagenUrl { get; set; }

        public virtual List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
