using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbUnidadeMedidum
    {
        public TbUnidadeMedidum()
        {
            TbProdutos = new HashSet<TbProduto>();
        }

        public int IdunidadeMedida { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TbProduto> TbProdutos { get; set; }
    }
}
