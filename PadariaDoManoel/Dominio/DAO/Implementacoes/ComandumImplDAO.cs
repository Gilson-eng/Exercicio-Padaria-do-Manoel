using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Interfaces
{
    class ComandumImplDAO : BaseDao, ComandumDAO
    {
        public ComandumImplDAO() : base()
        {
        }
        public bool Atualizar(TbComandum comanda)
        {
            try
            {
                TbComandum TbComandumSalvo = RecuperarPorId(comanda.Idcomanda);
                if (TbComandumSalvo != null)
                {
                    TbComandumSalvo.Idcomanda = comanda.Idcomanda;
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
                TbComandum TbComandumSalvo = RecuperarPorId(id);
                if (TbComandumSalvo != null)
                {
                    _db.TbComanda.Remove(TbComandumSalvo);
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

        public bool Inserir(TbComandum comanda)
        {
            try
            {
                _db.TbComanda.Add(comanda);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TbComandum RecuperarPorId(int id)
        {
            try
            {
                TbComandum TbComandumSalvo = _db.TbComanda
                .Where(x => x.Idcomanda == id).
                FirstOrDefault();
                return TbComandumSalvo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
