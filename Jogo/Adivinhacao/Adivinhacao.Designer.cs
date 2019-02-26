namespace Adivinhacao
{
    partial class Adivinhacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adivinhacao));
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnPlacar = new System.Windows.Forms.Button();
            this.lblTentativa = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(15, 110);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnPlacar
            // 
            this.btnPlacar.Location = new System.Drawing.Point(136, 110);
            this.btnPlacar.Name = "btnPlacar";
            this.btnPlacar.Size = new System.Drawing.Size(75, 23);
            this.btnPlacar.TabIndex = 0;
            this.btnPlacar.Text = "Placar";
            this.btnPlacar.UseVisualStyleBackColor = true;
            this.btnPlacar.Click += new System.EventHandler(this.btnPlacar_Click);
            // 
            // lblTentativa
            // 
            this.lblTentativa.AutoSize = true;
            this.lblTentativa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTentativa.Location = new System.Drawing.Point(22, 80);
            this.lblTentativa.Name = "lblTentativa";
            this.lblTentativa.Size = new System.Drawing.Size(63, 15);
            this.lblTentativa.TabIndex = 1;
            this.lblTentativa.Text = "Tentativa: ";
            this.lblTentativa.Click += new System.EventHandler(this.lblTentativa_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(91, 80);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(14, 15);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "0";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(136, 41);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(22, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblValor.Location = new System.Drawing.Point(140, 25);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 15);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // Adivinhacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(254, 163);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTentativa);
            this.Controls.Add(this.btnPlacar);
            this.Controls.Add(this.btnJogar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adivinhacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Adivinhação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnPlacar;
        private System.Windows.Forms.Label lblTentativa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
    }
}