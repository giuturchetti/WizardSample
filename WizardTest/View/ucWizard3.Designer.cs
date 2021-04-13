namespace WizardTest.View
{
    partial class ucWizard3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblSalarioBase = new System.Windows.Forms.Label();
            this.btnCriarContrato = new System.Windows.Forms.Button();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.bsContratos = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdeHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorFinalContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salário Base:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionario.Location = new System.Drawing.Point(126, 36);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(160, 20);
            this.lblFuncionario.TabIndex = 5;
            this.lblFuncionario.Text = "Nome do Funcionário";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(143, 70);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(184, 20);
            this.lblDepartamento.TabIndex = 6;
            this.lblDepartamento.Text = "Design/Desenvolvimento";
            // 
            // lblSalarioBase
            // 
            this.lblSalarioBase.AutoSize = true;
            this.lblSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBase.Location = new System.Drawing.Point(129, 105);
            this.lblSalarioBase.Name = "lblSalarioBase";
            this.lblSalarioBase.Size = new System.Drawing.Size(92, 20);
            this.lblSalarioBase.TabIndex = 7;
            this.lblSalarioBase.Text = "R$ 0000,00";
            // 
            // btnCriarContrato
            // 
            this.btnCriarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarContrato.Location = new System.Drawing.Point(190, 149);
            this.btnCriarContrato.Name = "btnCriarContrato";
            this.btnCriarContrato.Size = new System.Drawing.Size(244, 31);
            this.btnCriarContrato.TabIndex = 8;
            this.btnCriarContrato.Text = "Criar novo Contrato de Trabalho";
            this.btnCriarContrato.UseVisualStyleBackColor = true;
            this.btnCriarContrato.Click += new System.EventHandler(this.btnCriarContrato_Click);
            // 
            // dgvContratos
            // 
            this.dgvContratos.AllowUserToResizeColumns = false;
            this.dgvContratos.AutoGenerateColumns = false;
            this.dgvContratos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.identificadorDataGridViewTextBoxColumn,
            this.valorHoraDataGridViewTextBoxColumn,
            this.qtdeHorasDataGridViewTextBoxColumn,
            this.ValorFinalContrato});
            this.dgvContratos.DataSource = this.bsContratos;
            this.dgvContratos.Location = new System.Drawing.Point(19, 220);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.Size = new System.Drawing.Size(590, 150);
            this.dgvContratos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contratos:";
            // 
            // bsContratos
            // 
            this.bsContratos.DataSource = typeof(WizardTest.Entities.Contrato);
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // identificadorDataGridViewTextBoxColumn
            // 
            this.identificadorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.identificadorDataGridViewTextBoxColumn.DataPropertyName = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.HeaderText = "Identificador";
            this.identificadorDataGridViewTextBoxColumn.Name = "identificadorDataGridViewTextBoxColumn";
            // 
            // valorHoraDataGridViewTextBoxColumn
            // 
            this.valorHoraDataGridViewTextBoxColumn.DataPropertyName = "ValorHora";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.valorHoraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorHoraDataGridViewTextBoxColumn.FillWeight = 90F;
            this.valorHoraDataGridViewTextBoxColumn.HeaderText = "Valor Hora";
            this.valorHoraDataGridViewTextBoxColumn.Name = "valorHoraDataGridViewTextBoxColumn";
            this.valorHoraDataGridViewTextBoxColumn.Width = 90;
            // 
            // qtdeHorasDataGridViewTextBoxColumn
            // 
            this.qtdeHorasDataGridViewTextBoxColumn.DataPropertyName = "QtdeHoras";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qtdeHorasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtdeHorasDataGridViewTextBoxColumn.FillWeight = 90F;
            this.qtdeHorasDataGridViewTextBoxColumn.HeaderText = "Qtde Horas";
            this.qtdeHorasDataGridViewTextBoxColumn.Name = "qtdeHorasDataGridViewTextBoxColumn";
            this.qtdeHorasDataGridViewTextBoxColumn.Width = 90;
            // 
            // ValorFinalContrato
            // 
            this.ValorFinalContrato.DataPropertyName = "ValorFinalContrato";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.ValorFinalContrato.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorFinalContrato.HeaderText = "Valor Contrato";
            this.ValorFinalContrato.Name = "ValorFinalContrato";
            // 
            // ucWizard3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvContratos);
            this.Controls.Add(this.btnCriarContrato);
            this.Controls.Add(this.lblSalarioBase);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucWizard3";
            this.Size = new System.Drawing.Size(630, 390);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblSalarioBase;
        private System.Windows.Forms.Button btnCriarContrato;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bsContratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdeHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorFinalContrato;
    }
}
