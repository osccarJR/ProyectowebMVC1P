using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TicketProyectoP1.Models
{
    public class Usuario
    {
        [Key]
        public string UsuarioId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public List<Compra> Compras { get; set; } = new List<Compra>();
    }
}
