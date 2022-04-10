using Dominio.DAO.Interfaces;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class CategoriumImplDAO : BaseDao, CategoriumDAO
    {
        public bool Atualizar(TbCategorium categoria)
        {
            try
            {
                TbCategorium TbCategoriumSalvo = RecuperarPorId(categoria.Idcategoria);
                if (TbCategoriumSalvo != null)
                {
                    TbCategoriumSalvo.Idcategoria = categoria.Idcategoria;
                    TbCategoriumSalvo.Descricao = categoria.Descricao;
                    _db.SaveChanges();
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Deletar(int id)
        {
            try
            {
                TbCategorium TbCategoriumSalvo = RecuperarPorId(id);
                if (TbCategoriumSalvo != null)
                {
                    _db.TbCategoria.Remove(TbCategoriumSalvo);
                    _db.SaveChanges();
                    return true;

                }
                return false;
            }

            catch (Exception ex)
            {
                return false;

            }
        }

        public bool Inserir(TbCategorium categoria)
        {
            try
            {
                _db.TbCategoria.Add(categoria);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TbCategorium RecuperarPorDescricao(string descricao)
        {
            try
            {
                TbCategorium TbCategoriumSalvo = _db.TbCategoria
                .Where(x => x.Descricao == descricao)
                .FirstOrDefault();
                return TbCategoriumSalvo;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public TbCategorium RecuperarPorId(int id)
        {
            try
            {
                TbCategorium TbCategoriumSalvo = _db.TbCategoria
                .Where(x => x.Idcategoria == id).
                FirstOrDefault();
                return TbCategoriumSalvo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
