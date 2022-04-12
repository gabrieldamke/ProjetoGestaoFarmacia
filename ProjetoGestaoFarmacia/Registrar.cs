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
    public partial class Registrar1 : Form
    {
        public Registrar1()
        {
            InitializeComponent();
        }

        private void InserirUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrar1_Load(object sender, EventArgs e)
        {

        }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {
            Registrar2 TelaSplash = new Registrar2();
            this.Hide();
            TelaSplash.ShowDialog();
            
        }
    }
}
