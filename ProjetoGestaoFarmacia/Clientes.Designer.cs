namespace ProjetoGestaoFarmacia
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.label5 = new System.Windows.Forms.Label();
            this.CadastrarCliente = new System.Windows.Forms.Button();
            this.ConsultarClientes = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(135, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Clientes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CadastrarCliente
            // 
            this.CadastrarCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CadastrarCliente.FlatAppearance.BorderSize = 0;
            this.CadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadastrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CadastrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("CadastrarCliente.Image")));
            this.CadastrarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CadastrarCliente.Location = new System.Drawing.Point(45, 61);
            this.CadastrarCliente.Name = "CadastrarCliente";
            this.CadastrarCliente.Size = new System.Drawing.Size(309, 88);
            this.CadastrarCliente.TabIndex = 15;
            this.CadastrarCliente.Text = "Cadastrar Cliente";
            this.CadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CadastrarCliente.UseVisualStyleBackColor = false;
            this.CadastrarCliente.Click += new System.EventHandler(this.CadastrarCliente_Click);
            // 
            // ConsultarClientes
            // 
            this.ConsultarClientes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ConsultarClientes.FlatAppearance.BorderSize = 0;
            this.ConsultarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsultarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsultarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConsultarClientes.Image = ((System.Drawing.Image)(resources.GetObject("ConsultarClientes.Image")));
            this.ConsultarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarClientes.Location = new System.Drawing.Point(45, 155);
            this.ConsultarClientes.Name = "ConsultarClientes";
            this.ConsultarClientes.Size = new System.Drawing.Size(309, 88);
            this.ConsultarClientes.TabIndex = 16;
            this.ConsultarClientes.Text = "Consultar Clientes";
            this.ConsultarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarClientes.UseVisualStyleBackColor = false;
            this.ConsultarClientes.Click += new System.EventHandler(this.ConsultarClientes_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.Color.Black;
            this.BotaoFechar.Location = new System.Drawing.Point(363, 2);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 33;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(404, 255);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.ConsultarClientes);
            this.Controls.Add(this.CadastrarCliente);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Button CadastrarCliente;
        private Button ConsultarClientes;
        private Button BotaoFechar;
    }
}