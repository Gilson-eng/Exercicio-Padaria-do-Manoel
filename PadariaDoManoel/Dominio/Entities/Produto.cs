using System;


namespace PadariaDoManoel.Entities
{
    class Produto
    {
        private int idProduto;
        private string descricao;
        private double quantidade;
        private int codigoBarras;
        private double quantidadeMinima;
        private Categoria categoria;
        private UnidadeMedida unidadeMedida;

        public Produto() { }

        public Produto(int idProduto, string descricao, double quantidade, 
            int codigoBarras, double quantidadeMinima, 
            Categoria categoria, UnidadeMedida unidadeMedida)
        {
            this.IdProduto = idProduto;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.CodigoBarras = codigoBarras;
            this.QuantidadeMinima = quantidadeMinima;
            this.Categoria = categoria;
            this.UnidadeMedida = unidadeMedida;
        }

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public int CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public double QuantidadeMinima { get => quantidadeMinima; set => quantidadeMinima = value; }
        internal Categoria Categoria { get => categoria; set => categoria = value; }
        internal UnidadeMedida UnidadeMedida { get => unidadeMedida; set => unidadeMedida = value; }
    }
}
