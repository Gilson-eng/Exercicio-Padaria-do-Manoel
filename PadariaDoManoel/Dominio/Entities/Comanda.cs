using System;


namespace PadariaDoManoel.Entities
{
    class Comanda
    {
        private int idComanda;
        private int numero;

        public Comanda(int idComanda, int numero)
        {
            this.IdComanda = idComanda;
            this.Numero = numero;
        }

        public int IdComanda { get => idComanda; set => idComanda = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
