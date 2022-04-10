using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class UnidadeMedidaImplDAO : BaseDao, UnidadeMedidaDAO
    {

        public UnidadeMedidaImplDAO() : base()
        {
        }

        public bool Atualizar(TbUnidadeMedidum unidadeMedidum)
        {
            try
            {
                TbUnidadeMedidum UnidadeMedidumSalvo = RecuperarPorId(unidadeMedidum.IdunidadeMedida);
                if (UnidadeMedidumSalvo != null)
                {
                    UnidadeMedidumSalvo.IdunidadeMedida = unidadeMedidum.IdunidadeMedida;
                    UnidadeMedidumSalvo.Descricao = unidadeMedidum.Descricao;
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
                TbUnidadeMedidum UnidadeMedidumSalvo = RecuperarPorId(id);
                if (UnidadeMedidumSalvo != null)
                {
                    _db.TbUnidadeMedida.Remove(UnidadeMedidumSalvo);
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

        public bool Inserir(TbUnidadeMedidum UnidadeMedida)
        {
            try
            {
                _db.TbUnidadeMedida.Add(UnidadeMedida);
                _db.SaveChanges();
                return true;
            }

            catch(Exception ex)
            {
                return false;
            }
        }

        public TbUnidadeMedidum RecuperarPorId(int id)
        {
            try
            {
                TbUnidadeMedidum UnidadeMedidumSalvo = _db.TbUnidadeMedida
                    .Where(X => X.IdunidadeMedida == id).
                    FirstOrDefault();
                return UnidadeMedidumSalvo;
                
            }

            catch(Exception ex)
            {
                return null;

            }
            
        }

        public TbUnidadeMedidum RecuperarPorNome(string nome)
        {
            try
            {
                TbUnidadeMedidum UnidadeMedidaSalvo = _db.TbUnidadeMedida
                    .Where(X => X.Descricao == nome).FirstOrDefault();
                return UnidadeMedidaSalvo;
            }

            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
