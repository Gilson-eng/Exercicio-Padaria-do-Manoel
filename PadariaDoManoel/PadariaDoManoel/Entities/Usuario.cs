using System;


namespace PadariaDoManoel.Entities
{
    class Usuario
    {
        private int idUsuario;
        private string nomeUsuario;
        private string senha;
        private Perfil perfil;

        public Usuario(int idUsuario, 
            string nomeUsuario, string senha, Perfil perfil)
        {
            this.IdUsuario = idUsuario;
            this.NomeUsuario = nomeUsuario;
            this.Senha = senha;
            this.Perfil = perfil;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NomeUsuario { get => nomeUsuario; set => nomeUsuario = value; }
        public string Senha { get => senha; set => senha = value; }
        internal Perfil Perfil { get => perfil; set => perfil = value; }
    }
}
