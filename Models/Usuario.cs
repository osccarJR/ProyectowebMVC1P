using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace TicketProyectoP1.Models
{
    public class Usuario
    {
        [Key]
        [RegularExpression("^[0-9]*$", ErrorMessage = "El ID del usuario solo debe contener números.")]
        public string UsuarioId { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "El apellido solo puede contener letras y espacios.")]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression("^[^\\s@]+@[^\\s@]+\\.[^\\s@]{2,}$", ErrorMessage = "El correo electrónico no debe contener espacios.")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "La contraseña solo puede contener letras y números.")]
        public string Password { get; set; }

        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();
        public List<Compra> Compras { get; set; } = new List<Compra>();
    }
}
