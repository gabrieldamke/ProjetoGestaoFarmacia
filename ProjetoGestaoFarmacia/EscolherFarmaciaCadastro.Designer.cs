namespace ProjetoGestaoFarmacia
{
    partial class EscolherFarmaciaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscolherFarmaciaCadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.BotaoRegistrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InserirIdFarmacia = new System.Windows.Forms.TextBox();
            this.FarmaciasTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmaciasTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Controls.Add(this.BotaoFechar);
            this.panel1.Controls.Add(this.BotaoRegistrar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.FarmaciasTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 436);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(31, 410);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(67, 15);
            this.StatusLabel.TabIndex = 16;
            this.StatusLabel.Text = "StatusLabel";
            this.StatusLabel.Visible = false;
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(557, 0);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 16;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // BotaoRegistrar
            // 
            this.BotaoRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.BotaoRegistrar.FlatAppearance.BorderSize = 0;
            this.BotaoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoRegistrar.ForeColor = System.Drawing.Color.White;
            this.BotaoRegistrar.Location = new System.Drawing.Point(300, 350);
            this.BotaoRegistrar.Name = "BotaoRegistrar";
            this.BotaoRegistrar.Size = new System.Drawing.Size(154, 51);
            this.BotaoRegistrar.TabIndex = 15;
            this.BotaoRegistrar.Text = "Confirmar";
            this.BotaoRegistrar.UseVisualStyleBackColor = false;
            this.BotaoRegistrar.Click += new System.EventHandler(this.BotaoRegistrar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.InserirIdFarmacia);
            this.panel4.Location = new System.Drawing.Point(21, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 51);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // InserirIdFarmacia
            // 
            this.InserirIdFarmacia.BackColor = System.Drawing.Color.LightCyan;
            this.InserirIdFarmacia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InserirIdFarmacia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InserirIdFarmacia.ForeColor = System.Drawing.Color.Red;
            this.InserirIdFarmacia.Location = new System.Drawing.Point(40, 12);
            this.InserirIdFarmacia.Name = "InserirIdFarmacia";
            this.InserirIdFarmacia.PlaceholderText = "Digite o ID da sua farmácia";
            this.InserirIdFarmacia.Size = new System.Drawing.Size(219, 20);
            this.InserirIdFarmacia.TabIndex = 5;
            this.InserirIdFarmacia.TextChanged += new System.EventHandler(this.InserirRG_TextChanged);
            // 
            // FarmaciasTable
            // 
            this.FarmaciasTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FarmaciasTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FarmaciasTable.Location = new System.Drawing.Point(21, 50);
            this.FarmaciasTable.Name = "FarmaciasTable";
            this.FarmaciasTable.RowTemplate.Height = 25;
            this.FarmaciasTable.Size = new System.Drawing.Size(550, 294);
            this.FarmaciasTable.TabIndex = 6;
            this.FarmaciasTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolha sua farmácia";
            // 
            // EscolherFarmaciaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EscolherFarmaciaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolherFarmaciaCadastro";
            this.Load += new System.EventHandler(this.EscolherFarmaciaCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FarmaciasTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView FarmaciasTable;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox InserirIdFarmacia;
        private Button BotaoRegistrar;
        private Button BotaoFechar;
        private Label StatusLabel;
    }
}