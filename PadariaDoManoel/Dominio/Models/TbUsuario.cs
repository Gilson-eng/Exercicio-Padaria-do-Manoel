using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbUsuario
    {
        public TbUsuario()
        {
            TbMovimentos = new HashSet<TbMovimento>();
        }

        public int Idusuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Status { get; set; }
        public int Idperfil { get; set; }

        public virtual TbPerfil IdperfilNavigation { get; set; }
        public virtual ICollection<TbMovimento> TbMovimentos { get; set; }
    }
}
