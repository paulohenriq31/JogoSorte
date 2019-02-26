namespace ImparPar
{
    partial class ImparPar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImparPar));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rdbPar = new System.Windows.Forms.RadioButton();
            this.rdbImpar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnPlacar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(131, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 0;
            // 
            // rdbPar
            // 
            this.rdbPar.AutoSize = true;
            this.rdbPar.Location = new System.Drawing.Point(6, 19);
            this.rdbPar.Name = "rdbPar";
            this.rdbPar.Size = new System.Drawing.Size(41, 17);
            this.rdbPar.TabIndex = 1;
            this.rdbPar.TabStop = true;
            this.rdbPar.Text = "Par";
            this.rdbPar.UseVisualStyleBackColor = true;
            // 
            // rdbImpar
            // 
            this.rdbImpar.AutoSize = true;
            this.rdbImpar.Location = new System.Drawing.Point(53, 19);
            this.rdbImpar.Name = "rdbImpar";
            this.rdbImpar.Size = new System.Drawing.Size(51, 17);
            this.rdbImpar.TabIndex = 1;
            this.rdbImpar.TabStop = true;
            this.rdbImpar.Text = "Impar";
            this.rdbImpar.UseVisualStyleBackColor = true;
            this.rdbImpar.CheckedChanged += new System.EventHandler(this.rdbImpar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbImpar);
            this.groupBox1.Controls.Add(this.rdbPar);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(12, 164);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(82, 41);
            this.btnJogar.TabIndex = 3;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(91, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome do Jogador";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(128, 88);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // btnPlacar
            // 
            this.btnPlacar.Location = new System.Drawing.Point(131, 164);
            this.btnPlacar.Name = "btnPlacar";
            this.btnPlacar.Size = new System.Drawing.Size(82, 41);
            this.btnPlacar.TabIndex = 5;
            this.btnPlacar.Text = "Placar";
            this.btnPlacar.UseVisualStyleBackColor = true;
            this.btnPlacar.Click += new System.EventHandler(this.btnPlacar_Click);
            // 
            // ImparPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 230);
            this.Controls.Add(this.btnPlacar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImparPar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Impar Par";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rdbPar;
        private System.Windows.Forms.RadioButton rdbImpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnPlacar;
    }
}