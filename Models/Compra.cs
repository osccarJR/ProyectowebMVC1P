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

        [Required]
        public DateTime FechaCompra { get; set; } = DateTime.Now; 

        [Required]
        public decimal Total { get; set; }

    }
}
