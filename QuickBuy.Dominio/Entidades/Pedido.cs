using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        //Pedido deve ter pelo menos um pedido ou muitos pedidos.
        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}
