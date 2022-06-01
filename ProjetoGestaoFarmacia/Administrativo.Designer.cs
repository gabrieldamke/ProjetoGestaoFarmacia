namespace ProjetoGestaoFarmacia
{
    partial class Administrativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrativo));
            this.label5 = new System.Windows.Forms.Label();
            this.GerenciarFuncionarios = new System.Windows.Forms.Button();
            this.AlterarDados = new System.Windows.Forms.Button();
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(94, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Administrativo";
            // 
            // GerenciarFuncionarios
            // 
            this.GerenciarFuncionarios.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GerenciarFuncionarios.FlatAppearance.BorderSize = 0;
            this.GerenciarFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GerenciarFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GerenciarFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GerenciarFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("GerenciarFuncionarios.Image")));
            this.GerenciarFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GerenciarFuncionarios.Location = new System.Drawing.Point(56, 62);
            this.GerenciarFuncionarios.Name = "GerenciarFuncionarios";
            this.GerenciarFuncionarios.Size = new System.Drawing.Size(309, 88);
            this.GerenciarFuncionarios.TabIndex = 9;
            this.GerenciarFuncionarios.Text = "Gerenciar Funcionários";
            this.GerenciarFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GerenciarFuncionarios.UseVisualStyleBackColor = false;
            this.GerenciarFuncionarios.Click += new System.EventHandler(this.RealizarVenda_Click);
            // 
            // AlterarDados
            // 
            this.AlterarDados.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AlterarDados.FlatAppearance.BorderSize = 0;
            this.AlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarDados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AlterarDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AlterarDados.Image = ((System.Drawing.Image)(resources.GetObject("AlterarDados.Image")));
            this.AlterarDados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlterarDados.Location = new System.Drawing.Point(56, 156);
            this.AlterarDados.Name = "AlterarDados";
            this.AlterarDados.Size = new System.Drawing.Size(309, 88);
            this.AlterarDados.TabIndex = 10;
            this.AlterarDados.Text = "Alterar dados da farmácia";
            this.AlterarDados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AlterarDados.UseVisualStyleBackColor = false;
            this.AlterarDados.Click += new System.EventHandler(this.AlterarDados_Click);
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.Color.Black;
            this.BotaoFechar.Location = new System.Drawing.Point(379, 2);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 11;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(420, 294);
            this.Controls.Add(this.BotaoFechar);
            this.Controls.Add(this.AlterarDados);
            this.Controls.Add(this.GerenciarFuncionarios);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo";
            this.Load += new System.EventHandler(this.Administrativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Button GerenciarFuncionarios;
        private Button AlterarDados;
        private Button BotaoFechar;
    }
}