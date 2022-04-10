using Dominio.DAO.Interfaces;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class MovimentoImplDAO : BaseDao, MovimentoDAO
    {
        public MovimentoImplDAO() : base()
        {
        }

        public bool Atualizar(TbMovimento movimento)
        {
            try
            {
                TbMovimento MovimentoSalvo = RecuperarPorId(movimento.Idmovimento);
                if (MovimentoSalvo != null)
                {
                   MovimentoSalvo.Idmovimento = movimento.Idmovimento;
                   MovimentoSalvo.Descricao = movimento.Descricao;
                   MovimentoSalvo.Tipo = movimento.Tipo;
                   MovimentoSalvo.DataMovimento = movimento.DataMovimento;
                    MovimentoSalvo.Valor = movimento.Valor;
                    MovimentoSalvo.Idusuario = movimento.Idusuario;
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
                TbMovimento MovimentoSalvo = RecuperarPorId(id);
                if (MovimentoSalvo != null)
                {
                    _db.TbMovimentos.Remove(MovimentoSalvo);
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

        public bool Inserir(TbMovimento movimento)
        {
            try
            {
                _db.TbMovimentos.Add(movimento);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TbMovimento RecuperarPorId(int id)
        {
            try
            {
                TbMovimento MovimentoSalvo = _db.TbMovimentos
                .Where(x => x.Idmovimento == id).
                FirstOrDefault();
                return MovimentoSalvo;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public TbMovimento RecuperarPorNome(string nome)
        {
            try
            {
                TbMovimento MovimentoSalvo = _db.TbMovimentos
                .Where(x => x.Descricao == nome)
                .FirstOrDefault();
                return MovimentoSalvo;
            }

            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
