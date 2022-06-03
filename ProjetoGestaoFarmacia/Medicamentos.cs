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
    public partial class Medicamentos : Form
    {
        public int FarmaciaID;
        public Medicamentos(int FarmaciaId)
        {
            InitializeComponent();
            this.FarmaciaID = FarmaciaId;
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Medicamentos_Load(object sender, EventArgs e)
        {

        }

        private void GerenciarFuncionarios_Click(object sender, EventArgs e)
        {
            CadastrarMedicamento cadastrarMedicamento = new CadastrarMedicamento(FarmaciaID);
            cadastrarMedicamento.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarMedicamento consultarMedicamento = new ConsultarMedicamento(FarmaciaID);
            consultarMedicamento.ShowDialog();
        }
    }
}
