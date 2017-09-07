using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAula2.Models
{
   public class Cliente
    {
        public int ClienteID { get; set; }
        public String Nome { get; set; }
        public int Idade { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
    }
}