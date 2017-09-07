using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAula2.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public  Cliente Clientes { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime? DataEnvio { get; set; }
        public DateTime? DataEntrega { get; set; }
        public List<ItemDoPedido> Itens { get; set; }
    }
}