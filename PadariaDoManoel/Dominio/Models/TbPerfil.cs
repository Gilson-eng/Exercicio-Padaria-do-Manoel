using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbPerfil
    {
        public TbPerfil()
        {
            TbUsuarios = new HashSet<TbUsuario>();
        }

        public int Idperfil { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TbUsuario> TbUsuarios { get; set; }
    }
}
