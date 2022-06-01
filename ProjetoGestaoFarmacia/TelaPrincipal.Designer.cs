namespace ProjetoGestaoFarmacia
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Administrativo = new System.Windows.Forms.Button();
            this.DadosFinanceiros = new System.Windows.Forms.Button();
            this.VerificarReceitas = new System.Windows.Forms.Button();
            this.ControleNF = new System.Windows.Forms.Button();
            this.ConsultarMedicamentos = new System.Windows.Forms.Button();
            this.RealizarVenda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FarmaciaNome = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NomeDoUsuario = new System.Windows.Forms.Label();
            this.FarmaciaCNPJ = new System.Windows.Forms.Label();
            this.FarmaciaEndereco = new System.Windows.Forms.Label();
            this.FarmaciaTelefone = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.Color.Black;
            this.BotaoFechar.Location = new System.Drawing.Point(1311, 0);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 8;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Administrativo);
            this.panel1.Controls.Add(this.DadosFinanceiros);
            this.panel1.Controls.Add(this.VerificarReceitas);
            this.panel1.Controls.Add(this.ControleNF);
            this.panel1.Controls.Add(this.ConsultarMedicamentos);
            this.panel1.Controls.Add(this.RealizarVenda);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1351, 648);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Administrativo
            // 
            this.Administrativo.BackColor = System.Drawing.Color.SteelBlue;
            this.Administrativo.FlatAppearance.BorderSize = 0;
            this.Administrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Administrativo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Administrativo.ForeColor = System.Drawing.Color.White;
            this.Administrativo.Image = ((System.Drawing.Image)(resources.GetObject("Administrativo.Image")));
            this.Administrativo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administrativo.Location = new System.Drawing.Point(331, 317);
            this.Administrativo.Name = "Administrativo";
            this.Administrativo.Size = new System.Drawing.Size(265, 116);
            this.Administrativo.TabIndex = 13;
            this.Administrativo.Text = "Administrativo";
            this.Administrativo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Administrativo.UseVisualStyleBackColor = false;
            this.Administrativo.Click += new System.EventHandler(this.button5_Click);
            // 
            // DadosFinanceiros
            // 
            this.DadosFinanceiros.BackColor = System.Drawing.Color.SteelBlue;
            this.DadosFinanceiros.FlatAppearance.BorderSize = 0;
            this.DadosFinanceiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DadosFinanceiros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DadosFinanceiros.ForeColor = System.Drawing.Color.White;
            this.DadosFinanceiros.Image = ((System.Drawing.Image)(resources.GetObject("DadosFinanceiros.Image")));
            this.DadosFinanceiros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DadosFinanceiros.Location = new System.Drawing.Point(60, 317);
            this.DadosFinanceiros.Name = "DadosFinanceiros";
            this.DadosFinanceiros.Size = new System.Drawing.Size(265, 116);
            this.DadosFinanceiros.TabIndex = 12;
            this.DadosFinanceiros.Text = "Dados Financeiros";
            this.DadosFinanceiros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DadosFinanceiros.UseVisualStyleBackColor = false;
            // 
            // VerificarReceitas
            // 
            this.VerificarReceitas.BackColor = System.Drawing.Color.SteelBlue;
            this.VerificarReceitas.FlatAppearance.BorderSize = 0;
            this.VerificarReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerificarReceitas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VerificarReceitas.ForeColor = System.Drawing.Color.White;
            this.VerificarReceitas.Image = ((System.Drawing.Image)(resources.GetObject("VerificarReceitas.Image")));
            this.VerificarReceitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VerificarReceitas.Location = new System.Drawing.Point(331, 177);
            this.VerificarReceitas.Name = "VerificarReceitas";
            this.VerificarReceitas.Size = new System.Drawing.Size(265, 116);
            this.VerificarReceitas.TabIndex = 11;
            this.VerificarReceitas.Text = "Verificar receitas médicas";
            this.VerificarReceitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VerificarReceitas.UseVisualStyleBackColor = false;
            // 
            // ControleNF
            // 
            this.ControleNF.BackColor = System.Drawing.Color.SteelBlue;
            this.ControleNF.FlatAppearance.BorderSize = 0;
            this.ControleNF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControleNF.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ControleNF.ForeColor = System.Drawing.Color.White;
            this.ControleNF.Image = ((System.Drawing.Image)(resources.GetObject("ControleNF.Image")));
            this.ControleNF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ControleNF.Location = new System.Drawing.Point(60, 177);
            this.ControleNF.Name = "ControleNF";
            this.ControleNF.Size = new System.Drawing.Size(265, 116);
            this.ControleNF.TabIndex = 10;
            this.ControleNF.Text = "Controle de NF/CF";
            this.ControleNF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ControleNF.UseVisualStyleBackColor = false;
            // 
            // ConsultarMedicamentos
            // 
            this.ConsultarMedicamentos.BackColor = System.Drawing.Color.SteelBlue;
            this.ConsultarMedicamentos.FlatAppearance.BorderSize = 0;
            this.ConsultarMedicamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarMedicamentos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsultarMedicamentos.ForeColor = System.Drawing.Color.White;
            this.ConsultarMedicamentos.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarMedicamentos.Image")));
            this.ConsultarMedicamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarMedicamentos.Location = new System.Drawing.Point(331, 36);
            this.ConsultarMedicamentos.Name = "ConsultarMedicamentos";
            this.ConsultarMedicamentos.Size = new System.Drawing.Size(265, 116);
            this.ConsultarMedicamentos.TabIndex = 9;
            this.ConsultarMedicamentos.Text = "Consultar Medicamentos";
            this.ConsultarMedicamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarMedicamentos.UseVisualStyleBackColor = false;
            // 
            // RealizarVenda
            // 
            this.RealizarVenda.BackColor = System.Drawing.Color.SteelBlue;
            this.RealizarVenda.FlatAppearance.BorderSize = 0;
            this.RealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RealizarVenda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RealizarVenda.ForeColor = System.Drawing.Color.White;
            this.RealizarVenda.Image = ((System.Drawing.Image)(resources.GetObject("RealizarVenda.Image")));
            this.RealizarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RealizarVenda.Location = new System.Drawing.Point(60, 36);
            this.RealizarVenda.Name = "RealizarVenda";
            this.RealizarVenda.Size = new System.Drawing.Size(265, 116);
            this.RealizarVenda.TabIndex = 8;
            this.RealizarVenda.Text = " Realizar uma venda";
            this.RealizarVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RealizarVenda.UseVisualStyleBackColor = false;
            this.RealizarVenda.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.FarmaciaTelefone);
            this.panel3.Controls.Add(this.FarmaciaEndereco);
            this.panel3.Controls.Add(this.FarmaciaCNPJ);
            this.panel3.Controls.Add(this.FarmaciaNome);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(883, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 197);
            this.panel3.TabIndex = 0;
            // 
            // FarmaciaNome
            // 
            this.FarmaciaNome.AutoSize = true;
            this.FarmaciaNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FarmaciaNome.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FarmaciaNome.Location = new System.Drawing.Point(79, 48);
            this.FarmaciaNome.Name = "FarmaciaNome";
            this.FarmaciaNome.Size = new System.Drawing.Size(40, 21);
            this.FarmaciaNome.TabIndex = 9;
            this.FarmaciaNome.Text = "Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label9.Location = new System.Drawing.Point(12, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label8.Location = new System.Drawing.Point(12, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(93, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dados da sua farmácia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(209, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "com excelência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(111, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "A gestão da sua farmácia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(192, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdealFarma";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.NomeDoUsuario);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BotaoFechar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1351, 101);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1103, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Olá,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoGestaoFarmacia.Properties.Resources.external_pharmacy_hospital_and_healthcare_xnimrodx_lineal_color_xnimrodx;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NomeDoUsuario
            // 
            this.NomeDoUsuario.AutoSize = true;
            this.NomeDoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeDoUsuario.Location = new System.Drawing.Point(1103, 61);
            this.NomeDoUsuario.Name = "NomeDoUsuario";
            this.NomeDoUsuario.Size = new System.Drawing.Size(141, 21);
            this.NomeDoUsuario.TabIndex = 10;
            this.NomeDoUsuario.Text = "Nome do usuario";
            this.NomeDoUsuario.Click += new System.EventHandler(this.NomeDoUsuario_Click);
            // 
            // FarmaciaCNPJ
            // 
            this.FarmaciaCNPJ.AutoSize = true;
            this.FarmaciaCNPJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FarmaciaCNPJ.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FarmaciaCNPJ.Location = new System.Drawing.Point(74, 80);
            this.FarmaciaCNPJ.Name = "FarmaciaCNPJ";
            this.FarmaciaCNPJ.Size = new System.Drawing.Size(40, 21);
            this.FarmaciaCNPJ.TabIndex = 10;
            this.FarmaciaCNPJ.Text = "Info";
            // 
            // FarmaciaEndereco
            // 
            this.FarmaciaEndereco.AutoSize = true;
            this.FarmaciaEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FarmaciaEndereco.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FarmaciaEndereco.Location = new System.Drawing.Point(107, 116);
            this.FarmaciaEndereco.Name = "FarmaciaEndereco";
            this.FarmaciaEndereco.Size = new System.Drawing.Size(40, 21);
            this.FarmaciaEndereco.TabIndex = 11;
            this.FarmaciaEndereco.Text = "Info";
            // 
            // FarmaciaTelefone
            // 
            this.FarmaciaTelefone.AutoSize = true;
            this.FarmaciaTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FarmaciaTelefone.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FarmaciaTelefone.Location = new System.Drawing.Point(98, 153);
            this.FarmaciaTelefone.Name = "FarmaciaTelefone";
            this.FarmaciaTelefone.Size = new System.Drawing.Size(40, 21);
            this.FarmaciaTelefone.TabIndex = 12;
            this.FarmaciaTelefone.Text = "Info";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BotaoFechar;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Label NomeDoUsuario;
        private PictureBox pictureBox1;
        private Label label1;
        private Button RealizarVenda;
        private Button ConsultarMedicamentos;
        private Button Administrativo;
        private Button DadosFinanceiros;
        private Button VerificarReceitas;
        private Button ControleNF;
        private Label FarmaciaNome;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label FarmaciaTelefone;
        private Label FarmaciaEndereco;
        private Label FarmaciaCNPJ;
    }
}