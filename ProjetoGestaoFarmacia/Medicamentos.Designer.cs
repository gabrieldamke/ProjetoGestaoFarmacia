namespace ProjetoGestaoFarmacia
{
    partial class Medicamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicamentos));
            this.BotaoFechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GerenciarFuncionarios = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoFechar
            // 
            this.BotaoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoFechar.FlatAppearance.BorderSize = 0;
            this.BotaoFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoFechar.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotaoFechar.ForeColor = System.Drawing.Color.Black;
            this.BotaoFechar.Location = new System.Drawing.Point(364, -1);
            this.BotaoFechar.Name = "BotaoFechar";
            this.BotaoFechar.Size = new System.Drawing.Size(40, 40);
            this.BotaoFechar.TabIndex = 12;
            this.BotaoFechar.Text = "X";
            this.BotaoFechar.UseVisualStyleBackColor = true;
            this.BotaoFechar.Click += new System.EventHandler(this.BotaoFechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label5.Location = new System.Drawing.Point(84, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "Medicamentos";
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
            this.GerenciarFuncionarios.Location = new System.Drawing.Point(38, 36);
            this.GerenciarFuncionarios.Name = "GerenciarFuncionarios";
            this.GerenciarFuncionarios.Size = new System.Drawing.Size(309, 88);
            this.GerenciarFuncionarios.TabIndex = 14;
            this.GerenciarFuncionarios.Text = "Cadastrar medicamento";
            this.GerenciarFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GerenciarFuncionarios.UseVisualStyleBackColor = false;
            this.GerenciarFuncionarios.Click += new System.EventHandler(this.GerenciarFuncionarios_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(38, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 88);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar medicamentos";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(404, 255);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GerenciarFuncionarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BotaoFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicamentos";
            this.Load += new System.EventHandler(this.Medicamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BotaoFechar;
        private Label label5;
        private Button GerenciarFuncionarios;
        private Button button1;
    }
}