using System;
using System.Collections.Generic;

#nullable disable

namespace Dominio.Models
{
    public partial class TbMovimento
    {
        public int Idmovimento { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal Valor { get; set; }
        public int Idusuario { get; set; }

        public virtual TbUsuario IdusuarioNavigation { get; set; }
    }
}
