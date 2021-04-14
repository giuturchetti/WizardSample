using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardTest.Entities;

namespace WizardTest.View
{
    public partial class ucFuncionario : UserControl
    {
        private Funcionario Funcionario;

        public ucFuncionario(Funcionario funcionario)
        {
            InitializeComponent();
            Funcionario = funcionario;
            PreencherComponentes();
        }

        private void PreencherComponentes()
        {
            lblNome.Text = Funcionario.Nome;
            lblCPF.Text = Funcionario.CPF;
            lblTelefone.Text = Funcionario.Telefone;
            lblDep.Text = Funcionario.Dep.ToString();
            lblSalarioBase.Text = Funcionario.SalarioBase.ToString();
            //if (Funcionario.Contratos.Count > 0)
                bsContratos.DataSource = Funcionario.Contratos;
            lblSalarioFinal.Text = Funcionario.SalarioFinal.ToString();
        }
    }
}
