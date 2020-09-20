using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pedidos.Models;

namespace Pedidos.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Pedidos.Models.Usuario> Usuario { get; set; }
        //public DbSet<Rol> Roles { get; set; }
        //public DbSet<Calificacion> Calificaciones { get; set; }
        //public DbSet<Categoria> Categorias { get; set; }
        //public DbSet<Chat> Chats { get; set; }
        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Detalle_Pedido> Detalles_Pedidos { get; set; }
        //public DbSet<Estado_Pedido> Estados_Pedidos { get; set; }
        //public DbSet<Localizacion> Localizaciones { get; set; }
        //public DbSet<Notificacion> Notificaciones { get; set; }
        //public DbSet<Pedido_Usuario> Pedidos_Usuarios { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        //public DbSet<Personal_Entrega> Personales_Entregas { get; set; }
        //public DbSet<Producto> Productos { get; set; }
        //public DbSet<Tipo_Vehiculo> Tipos_Vehiculos { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Vehiculo> Vehiculos { get; set; }
        //public DbSet<Vendedor> Vendedores { get; set; }
    }
}
