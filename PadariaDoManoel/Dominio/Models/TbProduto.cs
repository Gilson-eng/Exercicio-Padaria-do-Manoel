using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbProduto
    {
        public TbProduto()
        {
            TbItemComanda = new HashSet<TbItemComandum>();
        }

        public int Idproduto { get; set; }
        public string Descricao { get; set; }
        public int IdunidadeMedida { get; set; }
        public int Idcategoria { get; set; }
        public string CodigoDeBarras { get; set; }
        public decimal Quantidade { get; set; }
        public decimal QuantidadeMinima { get; set; }
        public decimal ValorUnitario { get; set; }

        public virtual TbCategorium IdcategoriaNavigation { get; set; }
        public virtual TbUnidadeMedidum IdunidadeMedidaNavigation { get; set; }
        public virtual ICollection<TbItemComandum> TbItemComanda { get; set; }
    }
}
