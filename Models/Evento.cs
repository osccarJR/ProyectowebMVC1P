using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace TicketProyectoP1.Models
{
    public class Evento
    {
        [Key]
        public int EventoId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del evento no debe exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "La fecha del evento debe ser una fecha válida.")]
        public DateTime FechaEvento { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 500 caracteres.")]
        public string Descripcion { get; set; }

        [StringLength(200, ErrorMessage = "La ubicación no puede exceder los 200 caracteres.")]
        public string Ubicacion { get; set; }

        [Url(ErrorMessage = "La URL de la imagen debe ser una URL válida.")]
        public string ImagenUrl { get; set; }

        public virtual List<Ticket> Tickets { get; set; } = new List<Ticket>();
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}
