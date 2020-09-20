﻿using System;
using System.Collections.Generic;

namespace Pedidos.Models
{
    public partial class DetallePedido
    {
        public DetallePedido()
        {
            DetalleFactura = new HashSet<DetalleFactura>();
        }

        public long Id { get; set; }
        public long IdPedido { get; set; }
        public long IdProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal SubMonto { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
    }
}
