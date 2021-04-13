namespace WizardTest.View
{
    partial class FrmFuncionarioWizard
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.pnCorpo = new System.Windows.Forms.Panel();
            this.uc4 = new WizardTest.View.ucWizard4();
            this.uc3 = new WizardTest.View.ucWizard3();
            this.uc2 = new WizardTest.View.ucWizard2();
            this.uc1 = new WizardTest.View.ucWizard1();
            this.pnCorpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(249, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Enabled = false;
            this.btnAvancar.Location = new System.Drawing.Point(330, 415);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // pnCorpo
            // 
            this.pnCorpo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCorpo.Controls.Add(this.uc1);
            this.pnCorpo.Controls.Add(this.uc2);
            this.pnCorpo.Controls.Add(this.uc3);
            this.pnCorpo.Controls.Add(this.uc4);
            this.pnCorpo.Location = new System.Drawing.Point(12, 12);
            this.pnCorpo.Name = "pnCorpo";
            this.pnCorpo.Size = new System.Drawing.Size(630, 390);
            this.pnCorpo.TabIndex = 2;
            // 
            // uc4
            // 
            this.uc4.Location = new System.Drawing.Point(0, 0);
            this.uc4.Name = "uc4";
            this.uc4.Size = new System.Drawing.Size(630, 390);
            this.uc4.TabIndex = 0;
            this.uc4.Visible = false;
            // 
            // uc3
            // 
            this.uc3.Location = new System.Drawing.Point(0, 0);
            this.uc3.Name = "uc3";
            this.uc3.Size = new System.Drawing.Size(630, 390);
            this.uc3.TabIndex = 1;
            this.uc3.Visible = false;
            // 
            // uc2
            // 
            this.uc2.CPF = null;
            this.uc2.Id = 0;
            this.uc2.Location = new System.Drawing.Point(0, 0);
            this.uc2.Name = "uc2";
            this.uc2.Nome = null;
            this.uc2.Size = new System.Drawing.Size(630, 390);
            this.uc2.TabIndex = 2;
            this.uc2.Telefone = null;
            this.uc2.Visible = false;
            // 
            // uc1
            // 
            this.uc1.Location = new System.Drawing.Point(0, 0);
            this.uc1.Name = "uc1";
            this.uc1.Size = new System.Drawing.Size(630, 390);
            this.uc1.TabIndex = 3;
            // 
            // FrmFuncionarioWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.pnCorpo);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "FrmFuncionarioWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Funcionário";
            this.pnCorpo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Panel pnCorpo;
        private ucWizard4 uc4;
        private ucWizard1 uc1;
        private ucWizard2 uc2;
        private ucWizard3 uc3;
    }
}