namespace ProjetoGestaoFarmacia
{
    partial class DetalhesMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesMedicamento));
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrecisaDeReceita = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DescricaoMedicamento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ValorMedicamento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NomeMedicamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.QuantidadeEstoque = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AdicionarEstoque = new System.Windows.Forms.Button();
            this.RemoverEstoque = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Detalhes do medicamento";
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(525, 0);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 32;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.PrecisaDeReceita);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(318, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 45);
            this.panel1.TabIndex = 38;
            // 
            // PrecisaDeReceita
            // 
            this.PrecisaDeReceita.AutoCheck = false;
            this.PrecisaDeReceita.AutoSize = true;
            this.PrecisaDeReceita.Location = new System.Drawing.Point(40, 14);
            this.PrecisaDeReceita.Name = "PrecisaDeReceita";
            this.PrecisaDeReceita.Size = new System.Drawing.Size(163, 19);
            this.PrecisaDeReceita.TabIndex = 37;
            this.PrecisaDeReceita.Text = "Receita médica necessária";
            this.PrecisaDeReceita.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.DescricaoMedicamento);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(33, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 45);
            this.panel5.TabIndex = 39;
            // 
            // DescricaoMedicamento
            // 
            this.DescricaoMedicamento.AutoSize = true;
            this.DescricaoMedicamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescricaoMedicamento.ForeColor = System.Drawing.Color.Black;
            this.DescricaoMedicamento.Location = new System.Drawing.Point(134, 12);
            this.DescricaoMedicamento.Name = "DescricaoMedicamento";
            this.DescricaoMedicamento.Size = new System.Drawing.Size(40, 21);
            this.DescricaoMedicamento.TabIndex = 42;
            this.DescricaoMedicamento.Text = "Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Descricão:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Controls.Add(this.ValorMedicamento);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.pictureBox9);
            this.panel9.Location = new System.Drawing.Point(33, 149);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(279, 45);
            this.panel9.TabIndex = 37;
            // 
            // ValorMedicamento
            // 
            this.ValorMedicamento.AutoSize = true;
            this.ValorMedicamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValorMedicamento.ForeColor = System.Drawing.Color.Black;
            this.ValorMedicamento.Location = new System.Drawing.Point(101, 12);
            this.ValorMedicamento.Name = "ValorMedicamento";
            this.ValorMedicamento.Size = new System.Drawing.Size(40, 21);
            this.ValorMedicamento.TabIndex = 43;
            this.ValorMedicamento.Text = "Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(47, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Valor:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(10, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(24, 24);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.NomeMedicamento);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Location = new System.Drawing.Point(33, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 45);
            this.panel2.TabIndex = 36;
            // 
            // NomeMedicamento
            // 
            this.NomeMedicamento.AutoSize = true;
            this.NomeMedicamento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NomeMedicamento.ForeColor = System.Drawing.Color.Black;
            this.NomeMedicamento.Location = new System.Drawing.Point(101, 12);
            this.NomeMedicamento.Name = "NomeMedicamento";
            this.NomeMedicamento.Size = new System.Drawing.Size(40, 21);
            this.NomeMedicamento.TabIndex = 41;
            this.NomeMedicamento.Text = "Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nome:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(10, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(24, 24);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.QuantidadeEstoque);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(33, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 45);
            this.panel3.TabIndex = 38;
            // 
            // QuantidadeEstoque
            // 
            this.QuantidadeEstoque.AutoSize = true;
            this.QuantidadeEstoque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuantidadeEstoque.ForeColor = System.Drawing.Color.Black;
            this.QuantidadeEstoque.Location = new System.Drawing.Point(250, 12);
            this.QuantidadeEstoque.Name = "QuantidadeEstoque";
            this.QuantidadeEstoque.Size = new System.Drawing.Size(40, 21);
            this.QuantidadeEstoque.TabIndex = 44;
            this.QuantidadeEstoque.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(35, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Quantidade em estoque:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // AdicionarEstoque
            // 
            this.AdicionarEstoque.BackColor = System.Drawing.Color.SteelBlue;
            this.AdicionarEstoque.FlatAppearance.BorderSize = 0;
            this.AdicionarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdicionarEstoque.ForeColor = System.Drawing.Color.White;
            this.AdicionarEstoque.Location = new System.Drawing.Point(33, 251);
            this.AdicionarEstoque.Name = "AdicionarEstoque";
            this.AdicionarEstoque.Size = new System.Drawing.Size(138, 51);
            this.AdicionarEstoque.TabIndex = 40;
            this.AdicionarEstoque.Text = "Adicionar ao Estoque";
            this.AdicionarEstoque.UseVisualStyleBackColor = false;
            this.AdicionarEstoque.Click += new System.EventHandler(this.AdicionarEstoque_Click);
            // 
            // RemoverEstoque
            // 
            this.RemoverEstoque.BackColor = System.Drawing.Color.Brown;
            this.RemoverEstoque.FlatAppearance.BorderSize = 0;
            this.RemoverEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoverEstoque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoverEstoque.ForeColor = System.Drawing.Color.White;
            this.RemoverEstoque.Location = new System.Drawing.Point(174, 251);
            this.RemoverEstoque.Name = "RemoverEstoque";
            this.RemoverEstoque.Size = new System.Drawing.Size(138, 51);
            this.RemoverEstoque.TabIndex = 41;
            this.RemoverEstoque.Text = "Remover do Estoque";
            this.RemoverEstoque.UseVisualStyleBackColor = false;
            // 
            // DetalhesMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(564, 344);
            this.Controls.Add(this.RemoverEstoque);
            this.Controls.Add(this.AdicionarEstoque);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalhesMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalhesMedicamento";
            this.Load += new System.EventHandler(this.DetalhesMedicamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BotaoFechar;
        private Panel panel1;
        private CheckBox PrecisaDeReceita;
        private PictureBox pictureBox1;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Panel panel9;
        private PictureBox pictureBox9;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox7;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label DescricaoMedicamento;
        private Label label3;
        private Label ValorMedicamento;
        private Label label5;
        private Label NomeMedicamento;
        private Label QuantidadeEstoque;
        private Label label4;
        private Button AdicionarEstoque;
        private Button RemoverEstoque;
    }
}