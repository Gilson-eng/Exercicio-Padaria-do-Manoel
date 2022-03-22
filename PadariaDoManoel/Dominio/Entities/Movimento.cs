using System;


namespace PadariaDoManoel.Entities
{
    class Movimento
    {
        private int idMovimento;
        private string tipoMovimento;
        private DateTime dataMovimento;
        private double valor;
        private Usuario usuario;

        public Movimento(int idMovimento, string tipoMovimento, 
            DateTime dataMovimento, double valor, Usuario usuario)
        {
            this.IdMovimento = idMovimento;
            this.TipoMovimento = tipoMovimento;
            this.DataMovimento = dataMovimento;
            this.Valor = valor;
            this.Usuario = usuario;
        }

        public int IdMovimento { get => idMovimento; set => idMovimento = value; }
        public string TipoMovimento { get => tipoMovimento; set => tipoMovimento = value; }
        public DateTime DataMovimento { get => dataMovimento; set => dataMovimento = value; }
        public double Valor { get => valor; set => valor = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
