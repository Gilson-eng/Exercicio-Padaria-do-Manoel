using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    interface ItemComandumDAO
    {
        public bool Inserir(TbItemComandum itemComandum);
        public TbItemComandum RecuperarPorId(int id);
        public bool Deletar(int id);
    }
}
