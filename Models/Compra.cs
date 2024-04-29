using System;
using System.ComponentModel.DataAnnotations;

namespace TicketProyectoP1.Models
{
    public class Compra
    {
        [Key]
        public int CompraId { get; set; }

        [Required]
        public string UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; } 

        [Required(ErrorMessage = "La fecha de la compra es obligatoria.")]
        public DateTime FechaCompra { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El total de la compra es obligatorio.")]
        [Range(0.01, 5.00, ErrorMessage = "El total debe ser mayor que cero y no más de 5.")]
        public decimal Total { get; set; }

    }
}
