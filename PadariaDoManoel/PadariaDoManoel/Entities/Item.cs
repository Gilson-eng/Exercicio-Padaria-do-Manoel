using System;


namespace PadariaDoManoel.Entities
{
    class Item
    {
        private int idItem;
        private double quantidade;
        private double valorUnitario;

        public Item(int idItem, double quantidade, double valorUnitario)
        {
            this.IdItem = idItem;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }

        public int IdItem { get => idItem; set => idItem = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
    }
}
