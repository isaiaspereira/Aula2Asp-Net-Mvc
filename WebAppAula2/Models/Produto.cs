﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAula2.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categorias { get; set; }
        public String Descricao { get; set; }
        public decimal Valor { get; set; }
        public List<ItemDoPedido> Itens { get; set; }

    }
}