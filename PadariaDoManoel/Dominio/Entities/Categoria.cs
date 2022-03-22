using System;


namespace PadariaDoManoel.Entities
{
    class Categoria
    {
        private int idCategoria;
        private string descricao;

        public Categoria() { }

        public Categoria(int idCategoria, string descricao)
        {
            IdCategoria = idCategoria;
            Descricao = descricao;
        }

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
