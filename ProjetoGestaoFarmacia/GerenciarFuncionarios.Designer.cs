namespace ProjetoGestaoFarmacia
{
    partial class GerenciarFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarFuncionarios));
            this.FuncionariosTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.AdicionarFuncionario = new System.Windows.Forms.Button();
            this.DemitirFuncionario = new System.Windows.Forms.Button();
            this.AlterarDadosFuncionario = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosTable)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncionariosTable
            // 
            this.FuncionariosTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FuncionariosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FuncionariosTable.Location = new System.Drawing.Point(12, 109);
            this.FuncionariosTable.Name = "FuncionariosTable";
            this.FuncionariosTable.RowTemplate.Height = 25;
            this.FuncionariosTable.Size = new System.Drawing.Size(776, 237);
            this.FuncionariosTable.TabIndex = 0;
            this.FuncionariosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(257, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Gerenciar Funcionários";
            // 
            // AdicionarFuncionario
            // 
            this.AdicionarFuncionario.BackColor = System.Drawing.Color.Lime;
            this.AdicionarFuncionario.FlatAppearance.BorderSize = 0;
            this.AdicionarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdicionarFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.AdicionarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("AdicionarFuncionario.Image")));
            this.AdicionarFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdicionarFuncionario.Location = new System.Drawing.Point(12, 38);
            this.AdicionarFuncionario.Name = "AdicionarFuncionario";
            this.AdicionarFuncionario.Size = new System.Drawing.Size(160, 65);
            this.AdicionarFuncionario.TabIndex = 10;
            this.AdicionarFuncionario.Text = "Adicionar Novo Funcionário";
            this.AdicionarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdicionarFuncionario.UseVisualStyleBackColor = false;
            this.AdicionarFuncionario.Click += new System.EventHandler(this.RealizarVenda_Click);
            // 
            // DemitirFuncionario
            // 
            this.DemitirFuncionario.BackColor = System.Drawing.Color.Red;
            this.DemitirFuncionario.FlatAppearance.BorderSize = 0;
            this.DemitirFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DemitirFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DemitirFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.DemitirFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("DemitirFuncionario.Image")));
            this.DemitirFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DemitirFuncionario.Location = new System.Drawing.Point(178, 38);
            this.DemitirFuncionario.Name = "DemitirFuncionario";
            this.DemitirFuncionario.Size = new System.Drawing.Size(160, 65);
            this.DemitirFuncionario.TabIndex = 11;
            this.DemitirFuncionario.Text = "Demitir  funcionário";
            this.DemitirFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DemitirFuncionario.UseVisualStyleBackColor = false;
            this.DemitirFuncionario.Click += new System.EventHandler(this.DemitirFuncionario_Click);
            // 
            // AlterarDadosFuncionario
            // 
            this.AlterarDadosFuncionario.BackColor = System.Drawing.Color.Goldenrod;
            this.AlterarDadosFuncionario.FlatAppearance.BorderSize = 0;
            this.AlterarDadosFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarDadosFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlterarDadosFuncionario.ForeColor = System.Drawing.SystemColors.Control;
            this.AlterarDadosFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("AlterarDadosFuncionario.Image")));
            this.AlterarDadosFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlterarDadosFuncionario.Location = new System.Drawing.Point(344, 38);
            this.AlterarDadosFuncionario.Name = "AlterarDadosFuncionario";
            this.AlterarDadosFuncionario.Size = new System.Drawing.Size(217, 65);
            this.AlterarDadosFuncionario.TabIndex = 12;
            this.AlterarDadosFuncionario.Text = "Alterar dados de um funcionário";
            this.AlterarDadosFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AlterarDadosFuncionario.UseVisualStyleBackColor = false;
            this.AlterarDadosFuncionario.Click += new System.EventHandler(this.AlterarDadosFuncionario_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.Color.Black;
            this.BotaoFechar.Location = new System.Drawing.Point(760, 1);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 13;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // GerenciarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.AlterarDadosFuncionario);
            this.Controls.Add(this.DemitirFuncionario);
            this.Controls.Add(this.AdicionarFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FuncionariosTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Funcionarios";
            this.Load += new System.EventHandler(this.GerenciarFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionariosTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView FuncionariosTable;
        private Label label5;
        private Button AdicionarFuncionario;
        private Button DemitirFuncionario;
        private Button AlterarDadosFuncionario;
        private Button BotaoFechar;
    }
}