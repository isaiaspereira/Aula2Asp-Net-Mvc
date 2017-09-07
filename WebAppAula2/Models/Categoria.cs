using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAula2.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public String Descricao { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}