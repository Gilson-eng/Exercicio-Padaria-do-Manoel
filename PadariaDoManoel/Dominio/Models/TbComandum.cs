using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbComandum
    {
        public TbComandum()
        {
            TbItemComanda = new HashSet<TbItemComandum>();
        }

        public int Idcomanda { get; set; }
        public DateTime? DataComanda { get; set; }

        public virtual ICollection<TbItemComandum> TbItemComanda { get; set; }
    }
}
