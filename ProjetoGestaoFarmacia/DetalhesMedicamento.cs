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
    public partial class DetalhesMedicamento : Form
    {
        public int MedicamentoID;
        public int FarmaciaID;
        public DetalhesMedicamento(int medicamentoId, int FarmaciaId)
        {
            InitializeComponent();
            MedicamentoID = medicamentoId;
            FarmaciaID = FarmaciaId;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DetalhesMedicamento_Load(object sender, EventArgs e)
        {

        }

        private void AdicionarEstoque_Click(object sender, EventArgs e)
        {
            AdicionarEstoque adicionarestoque = new AdicionarEstoque(MedicamentoID, FarmaciaID);
        }
    }
}
