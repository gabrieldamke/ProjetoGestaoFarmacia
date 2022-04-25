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
    public partial class Registrar2 : Form
    {
        public Registrar2()
        {
            InitializeComponent();
        }
        int r = 252;
        int g = 240;
        int b = 240;
        int r2 = 70;
        int g2 = 130;
        int b2 = 180;
        public string Nome = "";
        public string Senha = "";
        public string Email = "";
        public Registrar2(string nome, string senha, string email) : this()
        {
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
        }

        private void Registrar2_Load(object sender, EventArgs e)
        {


            this.BackColor = Color.FromArgb(r, g, b);
            timerR.Start();
            timerNext.Start();
        }
        // 1ª instância de mudança de cor 
        private void timerR_Tick(object sender, EventArgs e)
        {
            g += 5;
            g2 += 5;
            this.BackColor = Color.FromArgb(r, g, b);
            label5.ForeColor = Color.FromArgb(r2, g2, b2);
            if (g >= 252 || g2 >= 252)
            {
                timerR.Stop();
                timerG.Start();
            }
        }
        private void timerG_Tick(object sender, EventArgs e)
        {
            r = r - 5;
            r2 = r2 + 5;
            this.BackColor = Color.FromArgb(r, g, b);
            label5.ForeColor = Color.FromArgb(r2, g2, b2);
            if (r <= 3 || r2 >= 240)
            {
                timerG.Stop();
                timerB.Start();
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            b += 5;
            b2 += 5;
            this.BackColor = Color.FromArgb(r, g, b);
            label5.ForeColor = Color.FromArgb(r2, g2, b2);
            if (b >= 240 || b2 >= 240)
            {
                timerB.Stop();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timerNext_Tick(object sender, EventArgs e)
        {
            Registrar3 SeguirRegistro = new Registrar3(Nome, Senha, Email);
            timerNext.Stop();
            Hide();
            SeguirRegistro.ShowDialog();
           
        }
    }
}
