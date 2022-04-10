using Dominio.DAO.Interfaces;
using Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO.Implementacoes
{
    class UsuarioImplDAO : BaseDao, UsuarioDAO
    {
        public UsuarioImplDAO() : base()
        {

        }


        public bool Atualizar(TbUsuario usuario)
        {
            try
            {
                TbUsuario UsuarioSalvo = RecuperarPorId(usuario.Idusuario);
                if (UsuarioSalvo != null)
                {
                    UsuarioSalvo.Nome = usuario.Nome;
                    UsuarioSalvo.Senha = usuario.Senha;
                    UsuarioSalvo.Status = usuario.Status;
                    UsuarioSalvo.Idperfil = usuario.Idperfil;
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

        public bool Deletar(int Id)
        {
            try
            {
                TbUsuario UsuarioSalvo = RecuperarPorId(Id);
                if (UsuarioSalvo!=null)
                {
                    _db.TbUsuarios.Remove(UsuarioSalvo);
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

        public bool Inserir(TbUsuario usuario)
        {
            try
            {
                _db.TbUsuarios.Add(usuario);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TbUsuario RecuperarPorId(int id)
        {
            try
            {
                TbUsuario UsuarioSalvo = _db.TbUsuarios
                                            .Where(x => x.Idusuario == id)
                                            .FirstOrDefault();

                return UsuarioSalvo;
            }

            catch(Exception ex)
            {
                return null;

            }
        }

        public TbUsuario RecuperarPorNome(string nome)
        {
            try
            {
                TbUsuario UsuarioSalvo = _db.TbUsuarios
                    .Where(x => x.Nome == nome)
                    .FirstOrDefault();

                return UsuarioSalvo;

            }

            catch (Exception ex)
            {
                return null;

            }
        }
    }
}
