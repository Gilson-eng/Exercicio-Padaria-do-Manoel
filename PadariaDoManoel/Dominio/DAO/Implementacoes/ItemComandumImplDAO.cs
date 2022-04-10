using Dominio.DAO.Interfaces;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class ItemComandumImplDAO : BaseDao, ItemComandumDAO
    {
        public ItemComandumImplDAO() : base()
        {
        }

        public bool Atualizar(TbItemComandum itemComandum)
        {
            try
            {
                TbItemComandum TbItemComandumSalvo = RecuperarPorId(itemComandum.IditemComanda);
                if (TbItemComandumSalvo != null)
                {
                    TbItemComandumSalvo.IditemComanda = itemComandum.IditemComanda;
                    TbItemComandumSalvo.Quantidade = itemComandum.Quantidade;
                    TbItemComandumSalvo.ValorUnitario = itemComandum.ValorUnitario;
                    TbItemComandumSalvo.Idcomanda = itemComandum.Idcomanda;
                    TbItemComandumSalvo.Idproduto = itemComandum.Idproduto;
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
                TbItemComandum TbItemComandumSalvo = RecuperarPorId(id);
                if (TbItemComandumSalvo != null)
                {
                    _db.TbItemComanda.Remove(TbItemComandumSalvo);
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

        public bool Inserir(TbItemComandum itemComandum)
        {
            try
            {
                _db.TbItemComanda.Add(itemComandum);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TbItemComandum RecuperarPorId(int id)
        {
            try
            {
                TbItemComandum ItemComandumSalvo = _db.TbItemComanda
                .Where(x => x.IditemComanda == id).
                FirstOrDefault();
                return ItemComandumSalvo;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        }
    }

