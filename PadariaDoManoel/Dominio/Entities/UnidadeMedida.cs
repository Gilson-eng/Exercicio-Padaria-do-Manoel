using System;


namespace PadariaDoManoel.Entities
{
    class UnidadeMedida
    {
        private int idUnidadeMedida;
        private string descricao;

        public UnidadeMedida(int idUnidadeMedida, string descricao)
        {
            this.IdUnidadeMedida = idUnidadeMedida;
            this.Descricao = descricao;
        }

        public int IdUnidadeMedida { get => idUnidadeMedida; set => idUnidadeMedida = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
