using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketProyectoP1.Models;

namespace TicketProyectoP1.Data
{
    public class TicketProyectoP1Context : DbContext
    {
        public TicketProyectoP1Context (DbContextOptions<TicketProyectoP1Context> options)
            : base(options)
        {
        }

        public DbSet<TicketProyectoP1.Models.Comentario> Comentario { get; set; } = default!;
        public DbSet<TicketProyectoP1.Models.Compra> Compra { get; set; } = default!;
        public DbSet<TicketProyectoP1.Models.Evento> Evento { get; set; } = default!;
        public DbSet<TicketProyectoP1.Models.Ticket> Ticket { get; set; } = default!;
        public DbSet<TicketProyectoP1.Models.Usuario> Usuario { get; set; } = default!;
    }
}
