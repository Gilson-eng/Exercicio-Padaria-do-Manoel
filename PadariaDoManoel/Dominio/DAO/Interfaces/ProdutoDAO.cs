using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    interface ProdutoDAO
    {
        public bool Inserir(TbProduto produto);
        public TbProduto RecuperarPorNome(string nome);
        public TbProduto RecuperarPorId(int id);
        public bool Atualizar(TbProduto produto);
        public bool Deletar(int id);

    }
}
