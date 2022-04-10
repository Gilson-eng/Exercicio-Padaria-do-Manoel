using System;
using Dominio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    interface PerfilDAO
    {
        public bool Inserir(TbPerfil Perfil);
        public TbPerfil RecuperarPorNome(string nome);
        public TbPerfil RecuperarPorId(int id);
        public bool Atualizar(TbPerfil perfil);
        public bool Deletar(int id);
        
    }
}
