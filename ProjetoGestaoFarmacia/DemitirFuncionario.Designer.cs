namespace ProjetoGestaoFarmacia
{
    partial class DemitirFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemitirFuncionario));
            this.label1 = new System.Windows.Forms.Label();
            this.FuncionariosTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InserirIdFarmaceutico = new System.Windows.Forms.TextBox();
            this.BotaoRegistrar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosTable)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Demitir um funcionário";
            // 
            // FuncionariosTable
            // 
            this.FuncionariosTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionariosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosTable.Location = new System.Drawing.Point(12, 46);
            this.FuncionariosTable.Name = "FuncionariosTable";
            this.FuncionariosTable.RowTemplate.Height = 25;
            this.FuncionariosTable.Size = new System.Drawing.Size(540, 263);
            this.FuncionariosTable.TabIndex = 8;
            this.FuncionariosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FuncionariosTable_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.InserirIdFarmaceutico);
            this.panel4.Location = new System.Drawing.Point(22, 317);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 52);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            // InserirIdFarmaceutico
            // 
            this.InserirIdFarmaceutico.BackColor = System.Drawing.Color.LightCyan;
            this.InserirIdFarmaceutico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InserirIdFarmaceutico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InserirIdFarmaceutico.ForeColor = System.Drawing.Color.Red;
            this.InserirIdFarmaceutico.Location = new System.Drawing.Point(40, 12);
            this.InserirIdFarmaceutico.Name = "InserirIdFarmaceutico";
            this.InserirIdFarmaceutico.PlaceholderText = "Digite o ID do funcionário";
            this.InserirIdFarmaceutico.Size = new System.Drawing.Size(219, 20);
            this.InserirIdFarmaceutico.TabIndex = 5;
            // 
            // BotaoRegistrar
            // 
            this.BotaoRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.BotaoRegistrar.FlatAppearance.BorderSize = 0;
            this.BotaoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoRegistrar.ForeColor = System.Drawing.Color.White;
            this.BotaoRegistrar.Location = new System.Drawing.Point(290, 317);
            this.BotaoRegistrar.Name = "BotaoRegistrar";
            this.BotaoRegistrar.Size = new System.Drawing.Size(154, 51);
            this.BotaoRegistrar.TabIndex = 17;
            this.BotaoRegistrar.Text = "Confirmar";
            this.BotaoRegistrar.UseVisualStyleBackColor = false;
            this.BotaoRegistrar.Click += new System.EventHandler(this.BotaoRegistrar_Click);
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
            this.BotaoFechar.TabIndex = 18;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // DemitirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(564, 383);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.BotaoRegistrar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.FuncionariosTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DemitirFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DemitirFuncionario";
            this.Load += new System.EventHandler(this.DemitirFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView FuncionariosTable;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox InserirIdFarmaceutico;
        private Button BotaoRegistrar;
        private Button BotaoFechar;
    }
}