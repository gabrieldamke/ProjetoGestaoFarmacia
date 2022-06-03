namespace ProjetoGestaoFarmacia
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
            this.label1 = new System.Windows.Forms.Label();
            this.InserirMedicamento = new System.Windows.Forms.TextBox();
            this.MedicamentosTable = new System.Windows.Forms.DataGridView();
            this.BotaoConsultar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BotaoSelecionar = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentosTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Medicamentos";
            // 
            // InserirMedicamento
            // 
            this.InserirMedicamento.Location = new System.Drawing.Point(3, 12);
            this.InserirMedicamento.Name = "InserirMedicamento";
            this.InserirMedicamento.PlaceholderText = "Insira o nome do medicamento ou deixe em branco para consultar todos";
            this.InserirMedicamento.Size = new System.Drawing.Size(393, 23);
            this.InserirMedicamento.TabIndex = 1;
            // 
            // MedicamentosTable
            // 
            this.MedicamentosTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicamentosTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicamentosTable.Location = new System.Drawing.Point(12, 46);
            this.MedicamentosTable.Name = "MedicamentosTable";
            this.MedicamentosTable.RowTemplate.Height = 25;
            this.MedicamentosTable.Size = new System.Drawing.Size(575, 302);
            this.MedicamentosTable.TabIndex = 3;
            this.MedicamentosTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaMedicamentos_CellContentClick);
            // 
            // BotaoConsultar
            // 
            this.BotaoConsultar.BackColor = System.Drawing.Color.SteelBlue;
            this.BotaoConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoConsultar.ForeColor = System.Drawing.Color.White;
            this.BotaoConsultar.Location = new System.Drawing.Point(401, 3);
            this.BotaoConsultar.Name = "BotaoConsultar";
            this.BotaoConsultar.Size = new System.Drawing.Size(80, 39);
            this.BotaoConsultar.TabIndex = 18;
            this.BotaoConsultar.Text = "Consultar";
            this.BotaoConsultar.UseVisualStyleBackColor = false;
            this.BotaoConsultar.Click += new System.EventHandler(this.BotaoRegistrar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.BotaoSelecionar);
            this.panel5.Controls.Add(this.InserirMedicamento);
            this.panel5.Controls.Add(this.BotaoConsultar);
            this.panel5.Location = new System.Drawing.Point(12, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 45);
            this.panel5.TabIndex = 19;
            // 
            // BotaoSelecionar
            // 
            this.BotaoSelecionar.BackColor = System.Drawing.Color.SteelBlue;
            this.BotaoSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoSelecionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoSelecionar.ForeColor = System.Drawing.Color.White;
            this.BotaoSelecionar.Location = new System.Drawing.Point(487, 3);
            this.BotaoSelecionar.Name = "BotaoSelecionar";
            this.BotaoSelecionar.Size = new System.Drawing.Size(85, 39);
            this.BotaoSelecionar.TabIndex = 19;
            this.BotaoSelecionar.Text = "Selecionar";
            this.BotaoSelecionar.UseVisualStyleBackColor = false;
            this.BotaoSelecionar.Click += new System.EventHandler(this.BotaoSelecionar_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(556, 0);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 20;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click_1);
            // 
            // ConsultarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(599, 412);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.MedicamentosTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarMedicamento";
            this.Load += new System.EventHandler(this.ConsultarMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicamentosTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox InserirMedicamento;
        private DataGridView MedicamentosTable;
        private Button BotaoConsultar;
        private Panel panel5;
        private Button BotaoFechar;
        private Button BotaoSelecionar;
    }
}