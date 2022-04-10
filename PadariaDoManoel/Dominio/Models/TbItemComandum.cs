using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbItemComandum
    {
        public int IditemComanda { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Idcomanda { get; set; }
        public int Idproduto { get; set; }

        public virtual TbComandum IdcomandaNavigation { get; set; }
        public virtual TbProduto IdprodutoNavigation { get; set; }
    }
}
