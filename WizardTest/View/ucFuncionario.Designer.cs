namespace WizardTest.View
{
    partial class ucFuncionario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.lblSalarioFinal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.identificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFinalContratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContratos = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSalarioFinal);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvContratos);
            this.panel1.Controls.Add(this.lblSalarioBase);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblDep);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 218);
            this.panel1.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(18, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(152, 18);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Funcionário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(49, 46);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(70, 15);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(188, 46);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 15);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "00000000000";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(105, 69);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(101, 15);
            this.lblDep.TabIndex = 6;
            this.lblDep.Text = "Desenvolvimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Departamento:";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(118, 94);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(52, 15);
            this.lblSalarioBase.TabIndex = 8;
            this.lblSalarioBase.Text = "0000,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salário Base:  R$";
            // 
            // dgvContratos
            // 
            this.dgvContratos.AutoGenerateColumns = false;
            this.dgvContratos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificadorDataGridViewTextBoxColumn,
            this.valorHoraDataGridViewTextBoxColumn,
            this.qtdeHorasDataGridViewTextBoxColumn,
            this.valorFinalContratoDataGridViewTextBoxColumn});
            this.dgvContratos.DataSource = this.bsContratos;
            this.dgvContratos.Location = new System.Drawing.Point(22, 120);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.RowHeadersVisible = false;
            this.dgvContratos.ShowEditingIcon = false;
            this.dgvContratos.Size = new System.Drawing.Size(250, 68);
            this.dgvContratos.TabIndex = 9;
            // 
            // lblSalarioFinal
            // 
            this.lblSalarioFinal.AutoSize = true;
            this.lblSalarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFinal.Location = new System.Drawing.Point(168, 195);
            this.lblSalarioFinal.Name = "lblSalarioFinal";
            this.lblSalarioFinal.Size = new System.Drawing.Size(52, 15);
            this.lblSalarioFinal.TabIndex = 11;
            this.lblSalarioFinal.Text = "0000,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salário Final:  R$";
            // 
            // identificadorDataGridViewTextBoxColumn
            // 
            this.identificadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identificadorDataGridViewTextBoxColumn.DataPropertyName = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.HeaderText = "Id.";
            this.identificadorDataGridViewTextBoxColumn.Name = "identificadorDataGridViewTextBoxColumn";
            // 
            // valorHoraDataGridViewTextBoxColumn
            // 
            this.valorHoraDataGridViewTextBoxColumn.DataPropertyName = "ValorHora";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.valorHoraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorHoraDataGridViewTextBoxColumn.HeaderText = "Valor/h";
            this.valorHoraDataGridViewTextBoxColumn.Name = "valorHoraDataGridViewTextBoxColumn";
            this.valorHoraDataGridViewTextBoxColumn.Width = 60;
            // 
            // qtdeHorasDataGridViewTextBoxColumn
            // 
            this.qtdeHorasDataGridViewTextBoxColumn.DataPropertyName = "QtdeHoras";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qtdeHorasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.qtdeHorasDataGridViewTextBoxColumn.HeaderText = "Qt.Horas";
            this.qtdeHorasDataGridViewTextBoxColumn.Name = "qtdeHorasDataGridViewTextBoxColumn";
            this.qtdeHorasDataGridViewTextBoxColumn.Width = 70;
            // 
            // valorFinalContratoDataGridViewTextBoxColumn
            // 
            this.valorFinalContratoDataGridViewTextBoxColumn.DataPropertyName = "ValorFinalContrato";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.valorFinalContratoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorFinalContratoDataGridViewTextBoxColumn.HeaderText = "Final";
            this.valorFinalContratoDataGridViewTextBoxColumn.Name = "valorFinalContratoDataGridViewTextBoxColumn";
            this.valorFinalContratoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorFinalContratoDataGridViewTextBoxColumn.Width = 60;
            // 
            // bsContratos
            // 
            this.bsContratos.DataSource = typeof(WizardTest.Entities.Contrato);
            // 
            // ucFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucFuncionario";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(310, 234);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalarioFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.BindingSource bsContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFinalContratoDataGridViewTextBoxColumn;
    }
}
