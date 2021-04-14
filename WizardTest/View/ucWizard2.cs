using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardTest.Entities.Tipos;
using WizardTest.Entities;

namespace WizardTest.View
{
    public partial class ucWizard2 : UserControl
    {
        public Funcionario Funcionario;        

        public ucWizard2()
        {
            InitializeComponent();
            Funcionario = new Funcionario();
            Funcionario.Contratos = new List<Contrato>();
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            cmbDepartamento.SelectedIndex = 0;
        }

        public Funcionario Salvar()
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text))
                Funcionario.Id = int.Parse(txtId.Text);
            Funcionario.Nome = txtNome.Text;
            Funcionario.CPF = txtCPF.Text;
            Funcionario.Telefone = txtTelefone.Text;
            if (cmbDepartamento.SelectedItem is Departamento)
            {
                Funcionario.Dep = (Departamento)cmbDepartamento.SelectedItem;
            }

            return Funcionario;
        }
    }
}
