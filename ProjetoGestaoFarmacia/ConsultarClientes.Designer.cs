namespace ProjetoGestaoFarmacia
{
    partial class ConsultarClientes
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
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientesTable = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BotaoSelecionar = new System.Windows.Forms.Button();
            this.InserirCliente = new System.Windows.Forms.TextBox();
            this.BotaoConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BotaoFechar.Location = new System.Drawing.Point(559, 0);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 22;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Clientes";
            // 
            // ClientesTable
            // 
            this.ClientesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesTable.Location = new System.Drawing.Point(12, 46);
            this.ClientesTable.Name = "ClientesTable";
            this.ClientesTable.RowTemplate.Height = 25;
            this.ClientesTable.Size = new System.Drawing.Size(575, 302);
            this.ClientesTable.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.BotaoSelecionar);
            this.panel5.Controls.Add(this.InserirCliente);
            this.panel5.Controls.Add(this.BotaoConsultar);
            this.panel5.Location = new System.Drawing.Point(12, 354);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(575, 45);
            this.panel5.TabIndex = 25;
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
            this.BotaoSelecionar.Text = "Ver mais";
            this.BotaoSelecionar.UseVisualStyleBackColor = false;
            this.BotaoSelecionar.Click += new System.EventHandler(this.BotaoSelecionar_Click);
            // 
            // InserirCliente
            // 
            this.InserirCliente.Location = new System.Drawing.Point(3, 12);
            this.InserirCliente.Name = "InserirCliente";
            this.InserirCliente.PlaceholderText = "Insira o ID do cliente";
            this.InserirCliente.Size = new System.Drawing.Size(393, 23);
            this.InserirCliente.TabIndex = 1;
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
            this.BotaoConsultar.Text = "Editar";
            this.BotaoConsultar.UseVisualStyleBackColor = false;
            this.BotaoConsultar.Click += new System.EventHandler(this.BotaoConsultar_Click);
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(599, 412);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ClientesTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarClientes";
            this.Load += new System.EventHandler(this.ConsultarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotaoFechar;
        private Label label1;
        private DataGridView ClientesTable;
        private Panel panel5;
        private Button BotaoSelecionar;
        private TextBox InserirCliente;
        private Button BotaoConsultar;
    }
}