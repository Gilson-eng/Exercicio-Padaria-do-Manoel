using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    interface ComandumDAO
    {
        public bool Inserir(TbComandum comanda);
        public TbComandum RecuperarPorId(int id);
        public bool Atualizar(TbComandum comanda);
        public bool Deletar(int id);
    }
}
