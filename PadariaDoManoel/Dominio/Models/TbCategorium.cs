using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbCategorium
    {
        public TbCategorium()
        {
            TbProdutos = new HashSet<TbProduto>();
        }

        public int Idcategoria { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TbProduto> TbProdutos { get; set; }
    }
}
