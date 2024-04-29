using System;
using System.ComponentModel.DataAnnotations;

namespace TicketProyectoP1.Models
{
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }

        [Required]
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } 

        [Required]
        public int EventoId { get; set; }
        public virtual Evento Evento { get; set; } 

        [Required]
        [StringLength(1000, ErrorMessage = "El comentario no puede exceder los 1000 caracteres.")]
        public string Texto { get; set; }

        public DateTime FechaComentario { get; set; } = DateTime.Now; 

        [Range(1, 5, ErrorMessage = "La calificación debe estar entre 1 y 5.")]
        public int? Calificacion { get; set; }
    }
}
