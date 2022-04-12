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

        private void Registrar2_Load(object sender, EventArgs e)
        {
     

            this.BackColor = Color.FromArgb(r, g, b);
            timerR.Start();
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            g += 5;
            this.BackColor =  Color.FromArgb(r, g, b);
            if (g >=252)
            {
                timerR.Stop();
                timerG.Start();
            }
        }
        private void timerG_Tick(object sender, EventArgs e)
        {
            r -= 5;
            this.BackColor =  Color.FromArgb(r, g, b);
            if (r <= 3)
            {
                timerG.Stop();
                timerB.Start();
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            b += 5;
            this.BackColor  = Color.FromArgb(r, g, b);
           if (b >= 240)
            {
                timerB.Stop();
               // timerG.Start();
            } 
        }
    }
}
