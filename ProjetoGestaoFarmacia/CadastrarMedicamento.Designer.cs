namespace ProjetoGestaoFarmacia
{
    partial class CadastrarMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarMedicamento));
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InserirNome = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.InserirValor = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.InserirDescricao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrecisaDeReceita = new System.Windows.Forms.CheckBox();
            this.BotaoRegistrar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(109, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastrar novo medicamento";
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(524, 0);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 32;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.InserirNome);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Location = new System.Drawing.Point(26, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 45);
            this.panel2.TabIndex = 33;
            // 
            // InserirNome
            // 
            this.InserirNome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InserirNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InserirNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InserirNome.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.InserirNome.Location = new System.Drawing.Point(47, 12);
            this.InserirNome.MaxLength = 50;
            this.InserirNome.Name = "InserirNome";
            this.InserirNome.PlaceholderText = "Nome";
            this.InserirNome.Size = new System.Drawing.Size(298, 20);
            this.InserirNome.TabIndex = 5;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Controls.Add(this.pictureBox9);
            this.panel9.Controls.Add(this.InserirValor);
            this.panel9.Location = new System.Drawing.Point(26, 157);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(239, 45);
            this.panel9.TabIndex = 34;
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
            // InserirValor
            // 
            this.InserirValor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InserirValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InserirValor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InserirValor.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.InserirValor.Location = new System.Drawing.Point(47, 12);
            this.InserirValor.Name = "InserirValor";
            this.InserirValor.PlaceholderText = "Valor";
            this.InserirValor.Size = new System.Drawing.Size(127, 20);
            this.InserirValor.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.InserirDescricao);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(26, 105);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(494, 45);
            this.panel5.TabIndex = 35;
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
            // InserirDescricao
            // 
            this.InserirDescricao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InserirDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InserirDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InserirDescricao.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.InserirDescricao.Location = new System.Drawing.Point(47, 12);
            this.InserirDescricao.MaxLength = 50;
            this.InserirDescricao.Name = "InserirDescricao";
            this.InserirDescricao.PlaceholderText = "Descrição";
            this.InserirDescricao.Size = new System.Drawing.Size(298, 20);
            this.InserirDescricao.TabIndex = 6;
            this.InserirDescricao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.PrecisaDeReceita);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(271, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 45);
            this.panel1.TabIndex = 35;
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
            // PrecisaDeReceita
            // 
            this.PrecisaDeReceita.AutoSize = true;
            this.PrecisaDeReceita.Location = new System.Drawing.Point(40, 14);
            this.PrecisaDeReceita.Name = "PrecisaDeReceita";
            this.PrecisaDeReceita.Size = new System.Drawing.Size(163, 19);
            this.PrecisaDeReceita.TabIndex = 37;
            this.PrecisaDeReceita.Text = "Receita médica necessária";
            this.PrecisaDeReceita.UseVisualStyleBackColor = true;
            // 
            // BotaoRegistrar
            // 
            this.BotaoRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.BotaoRegistrar.FlatAppearance.BorderSize = 0;
            this.BotaoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoRegistrar.ForeColor = System.Drawing.Color.White;
            this.BotaoRegistrar.Location = new System.Drawing.Point(185, 219);
            this.BotaoRegistrar.Name = "BotaoRegistrar";
            this.BotaoRegistrar.Size = new System.Drawing.Size(199, 51);
            this.BotaoRegistrar.TabIndex = 36;
            this.BotaoRegistrar.Text = "Cadastrar";
            this.BotaoRegistrar.UseVisualStyleBackColor = false;
            this.BotaoRegistrar.Click += new System.EventHandler(this.BotaoRegistrar_Click);
            // 
            // CadastrarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(564, 295);
            this.Controls.Add(this.BotaoRegistrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarMedicamento";
            this.Load += new System.EventHandler(this.CadastrarMedicamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BotaoFechar;
        private Panel panel2;
        private TextBox InserirNome;
        private PictureBox pictureBox7;
        private Panel panel9;
        private PictureBox pictureBox9;
        private TextBox InserirValor;
        private Panel panel5;
        private PictureBox pictureBox4;
        private TextBox InserirDescricao;
        private Panel panel1;
        private CheckBox PrecisaDeReceita;
        private PictureBox pictureBox1;
        private Button BotaoRegistrar;
    }
}