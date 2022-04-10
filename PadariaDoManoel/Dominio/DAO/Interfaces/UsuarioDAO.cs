using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Models;

namespace Dominio.DAO.Interfaces
{
    interface UsuarioDAO
    {
        public bool Inserir(TbUsuario usuario);
        public TbUsuario RecuperarPorNome(string nome);
        public TbUsuario RecuperarPorId(int id);
        public bool Atualizar(TbUsuario usuario);
        public bool Deletar(int Id);







    }
}
