using System;


namespace PadariaDoManoel.Entities
{
    class Perfil
    {
        private int idPerfil;
        private string descricao;

        public Perfil(int idPerfil, string descricao)
        {
            this.IdPerfil = idPerfil;
            this.Descricao = descricao;
        }

        public int IdPerfil { get => idPerfil; set => idPerfil = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
