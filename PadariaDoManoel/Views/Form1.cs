using System;
using System.Windows.Forms;
using Dominio.Models;

namespace Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            string username = TxtUsuario.Text;
            string senha = TxtSenha.Text;
            TbUsuario


        }
    }
}
