using System;
using Dominio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    interface UnidadeMedidaDAO
    {
        public bool Inserir(TbUnidadeMedidum UnidadeMedida);
        public TbUnidadeMedidum RecuperarPorNome(string nome);
        public TbUnidadeMedidum RecuperarPorId(int id);
        public bool Atualizar(TbUnidadeMedidum unidadeMedidum);
        public bool Deletar(int id);
    }
}
