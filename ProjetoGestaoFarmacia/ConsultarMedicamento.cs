﻿using System;
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
    public partial class ConsultarMedicamento : Form
    {
        public ConsultarMedicamento()
        {
            InitializeComponent();
        }

        private void BotaoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}