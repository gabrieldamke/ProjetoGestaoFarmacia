namespace ProjetoGestaoFarmacia
{
    partial class EditarFuncionarioTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionarioTabela));
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.FuncionariosTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoRegistrar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.InserirIdFarmaceutico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosTable)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(526, -2);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 19;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // FuncionariosTable
            // 
            this.FuncionariosTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionariosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosTable.Location = new System.Drawing.Point(10, 51);
            this.FuncionariosTable.Name = "FuncionariosTable";
            this.FuncionariosTable.RowTemplate.Height = 25;
            this.FuncionariosTable.Size = new System.Drawing.Size(540, 263);
            this.FuncionariosTable.TabIndex = 21;
            this.FuncionariosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FuncionariosTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(93, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Escolha um funcionário para editar";
            // 
            // BotaoRegistrar
            // 
            this.BotaoRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.BotaoRegistrar.FlatAppearance.BorderSize = 0;
            this.BotaoRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoRegistrar.ForeColor = System.Drawing.Color.White;
            this.BotaoRegistrar.Location = new System.Drawing.Point(309, 320);
            this.BotaoRegistrar.Name = "BotaoRegistrar";
            this.BotaoRegistrar.Size = new System.Drawing.Size(154, 51);
            this.BotaoRegistrar.TabIndex = 23;
            this.BotaoRegistrar.Text = "Confirmar";
            this.BotaoRegistrar.UseVisualStyleBackColor = false;
            this.BotaoRegistrar.Click += new System.EventHandler(this.BotaoRegistrar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.InserirIdFarmaceutico);
            this.panel4.Location = new System.Drawing.Point(41, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 52);
            this.panel4.TabIndex = 22;
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
            // EditarFuncionarioTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(564, 383);
            this.Controls.Add(this.BotaoRegistrar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.FuncionariosTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarFuncionarioTabela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarFuncionarioTabela";
            this.Load += new System.EventHandler(this.EditarFuncionarioTabela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotaoFechar;
        private DataGridView FuncionariosTable;
        private Label label1;
        private Button BotaoRegistrar;
        private Panel panel4;
        private PictureBox pictureBox3;
        private TextBox InserirIdFarmaceutico;
    }
}