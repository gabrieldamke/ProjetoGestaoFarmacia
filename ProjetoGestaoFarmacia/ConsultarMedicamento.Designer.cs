﻿namespace ProjetoGestaoFarmacia
{
    partial class ConsultarMedicamento
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TabelaMedicamentos = new System.Windows.Forms.DataGridView();
            this.ConsultaMedicamento = new System.Windows.Forms.Button();
            this.InserirMedicamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(98, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "com excelência";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(0, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "A gestão da sua farmácia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "IdealFarma";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotaoFechar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 92);
            this.panel1.TabIndex = 12;
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(756, 4);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 9;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.TabelaMedicamentos);
            this.panel2.Controls.Add(this.ConsultaMedicamento);
            this.panel2.Controls.Add(this.InserirMedicamento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 576);
            this.panel2.TabIndex = 13;
            // 
            // TabelaMedicamentos
            // 
            this.TabelaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaMedicamentos.Location = new System.Drawing.Point(12, 198);
            this.TabelaMedicamentos.Name = "TabelaMedicamentos";
            this.TabelaMedicamentos.RowTemplate.Height = 25;
            this.TabelaMedicamentos.Size = new System.Drawing.Size(776, 364);
            this.TabelaMedicamentos.TabIndex = 3;
            // 
            // ConsultaMedicamento
            // 
            this.ConsultaMedicamento.BackColor = System.Drawing.Color.Red;
            this.ConsultaMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultaMedicamento.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsultaMedicamento.Location = new System.Drawing.Point(305, 133);
            this.ConsultaMedicamento.Name = "ConsultaMedicamento";
            this.ConsultaMedicamento.Size = new System.Drawing.Size(344, 59);
            this.ConsultaMedicamento.TabIndex = 2;
            this.ConsultaMedicamento.Text = "Consultar";
            this.ConsultaMedicamento.UseVisualStyleBackColor = false;
            this.ConsultaMedicamento.Click += new System.EventHandler(this.button1_Click);
            // 
            // InserirMedicamento
            // 
            this.InserirMedicamento.Location = new System.Drawing.Point(156, 104);
            this.InserirMedicamento.Name = "InserirMedicamento";
            this.InserirMedicamento.PlaceholderText = "                                     Inserir o nome do Medicamento ou deixe em br" +
    "anco para consultar todos";
            this.InserirMedicamento.Size = new System.Drawing.Size(610, 23);
            this.InserirMedicamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(143, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Medicamentos";
            // 
            // ConsultarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarMedicamento";
            this.Text = "ConsultarMedicamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaMedicamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label2;
        private Panel panel1;
        private Button BotaoFechar;
        private Panel panel2;
        private Label label1;
        private DataGridView TabelaMedicamentos;
        private Button ConsultaMedicamento;
        private TextBox InserirMedicamento;
    }
}