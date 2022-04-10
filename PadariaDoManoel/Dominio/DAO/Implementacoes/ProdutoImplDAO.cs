using Dominio.DAO.Interfaces;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class ProdutoImplDAO : BaseDao, ProdutoDAO
    {
        public ProdutoImplDAO() : base()
        {
        }
        
        public bool Atualizar(TbProduto produto)
        {
            try
            {
                TbProduto ProdutoSalvo = RecuperarPorId(produto.Idproduto);
                if (ProdutoSalvo!=null){
                    ProdutoSalvo.Idproduto = produto.Idproduto;
                    ProdutoSalvo.Descricao = produto.Descricao;
                    ProdutoSalvo.IdunidadeMedida = produto.IdunidadeMedida;
                    ProdutoSalvo.Idcategoria = produto.Idcategoria;
                    ProdutoSalvo.CodigoDeBarras = produto.CodigoDeBarras;
                    ProdutoSalvo.Quantidade = produto.Quantidade;
                    ProdutoSalvo.QuantidadeMinima = produto.QuantidadeMinima;
                    ProdutoSalvo.ValorUnitario = produto.ValorUnitario;
                    _db.SaveChanges();
                    return true;
                }

                return false;

            }

            catch(Exception ex)
            {

                return false;

            }

        }

        public bool Deletar(int id)
        {
           try
            {
                TbProduto ProdutoSalvo = RecuperarPorId(id);
                if (ProdutoSalvo != null)
                {
                    _db.TbProdutos.Remove(ProdutoSalvo);
                    _db.SaveChanges();
                    return true;
                }

                return false;
            }

            catch(Exception ex)
            {
                return false;
            }
            
        }

        public bool Inserir(TbProduto Produto)
        {
            try
            {
                _db.TbProdutos.Add(Produto);
                _db.SaveChanges();
                return true;
            }



            catch(Exception ex)
            {

                return false;
            }
        }

        public TbProduto RecuperarPorId(int id)
        {
            try
            {
                TbProduto ProdutoSalvo = _db.TbProdutos
                    .Where(X => X.Idproduto == id).FirstOrDefault();
                return ProdutoSalvo;
            }

            catch(Exception ex)
            {
                return null;
            }

        }

        public TbProduto RecuperarPorNome(string nome)
        {
            try
            {
                TbProduto ProdutoSalvo = _db.TbProdutos
                    .Where(X => X.Descricao == nome).FirstOrDefault();
                return ProdutoSalvo;
             }
            catch(Exception ex)
            {
                return null;
            }
           
        }
    }
}
