using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public string ProdutoId { get; set; }
        public string Quantidade { get; set; }

        /// <summary>
        /// Um Usuario Pode ter nenhum ou muitos pedidos
        /// </summary>

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
