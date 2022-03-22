using System;
using System.Collections.Generic;


namespace PadariaDoManoel.Entities
{
    class Vendas
    {
        private double valorVenda;
        private DateTime dataVenda;
        private Comanda comanda;
        public List<Vendas> ListVendas { get; set; } = new List<Vendas>();
        
    }
}
