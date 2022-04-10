using System;
using Dominio.Models;
using Dominio.DAO.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class PerfilImplDAO : BaseDao, PerfilDAO
    {
        public PerfilImplDAO() : base()
        {
        }


        public bool Atualizar(TbPerfil perfil)
        {
            try
            {
                TbPerfil PerfilSalvo = RecuperarPorId(perfil.Idperfil);
                if (PerfilSalvo != null)
                {
                    PerfilSalvo.Idperfil = perfil.Idperfil;
                    PerfilSalvo.Descricao = perfil.Descricao;
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
                TbPerfil PerfilSalvo = RecuperarPorId(id);
                if(PerfilSalvo != null)
                {
                    _db.TbPerfils.Remove(PerfilSalvo);
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

        public bool Inserir(TbPerfil Perfil)
        {
            try
            {
                _db.TbPerfils.Add(Perfil);
                _db.SaveChanges();
                return true;

            }
           catch(Exception ex)
            {
                return false;
            }
        }

        public TbPerfil RecuperarPorId(int id)
        {
            try
            {
                TbPerfil PerfilSalvo = _db.TbPerfils
                .Where(x => x.Idperfil == id).
                FirstOrDefault();
                return PerfilSalvo;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        public TbPerfil RecuperarPorNome(string nome)
        {
            try
            {
                TbPerfil PerfilSalvo = _db.TbPerfils
                .Where(x => x.Descricao == nome)
                .FirstOrDefault();
                return PerfilSalvo;
            }

            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
