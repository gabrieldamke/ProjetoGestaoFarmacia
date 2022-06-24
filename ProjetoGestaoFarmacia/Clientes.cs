using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGestaoFarmacia
{
    public partial class Clientes : Form
    {
        public int FarmaciaID;
        public Clientes(int FarmaciaId)
        {
            InitializeComponent();
            this.FarmaciaID = FarmaciaId;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente(FarmaciaID);
            cadastrarCliente.ShowDialog();
            this.Close();
            this.Hide();
        }

        private void ConsultarClientes_Click(object sender, EventArgs e)
        {
            ConsultarClientes consultarClientes = new ConsultarClientes(FarmaciaID);
            consultarClientes.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
