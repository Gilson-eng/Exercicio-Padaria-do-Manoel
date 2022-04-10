using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    interface MovimentoDAO
    {
        public bool Inserir(TbMovimento movimento);
        public TbMovimento RecuperarPorNome(string nome);
        public TbMovimento RecuperarPorId(int id);
        public bool Atualizar(TbMovimento movimento);
        public bool Deletar(int id);
    }
}
