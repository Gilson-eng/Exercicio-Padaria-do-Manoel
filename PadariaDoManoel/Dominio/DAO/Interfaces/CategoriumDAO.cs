using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    interface CategoriumDAO
    {
        public bool Inserir(TbCategorium categoria);
        public TbCategorium RecuperarPorDescricao(string descricao);
        public TbCategorium RecuperarPorId(int id);
        public bool Atualizar(TbCategorium categoria);
        public bool Deletar(int id);
        
    }
}
