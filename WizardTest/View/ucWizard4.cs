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
    public partial class ucWizard4 : UserControl
    {
        public Funcionario Funcionario;
        
        public ucWizard4()
        {
            InitializeComponent();
            Funcionario = new Funcionario();
            Funcionario.Contratos = new List<Contrato>();
        }

        public void AtualizarFuncionario(Funcionario func)
        {
            Funcionario = func;
        }

        private void ucWizard4_VisibleChanged(object sender, EventArgs e)
        {
            lblFuncionario.Text = Funcionario.Nome;
            lblDepartamento.Text = Funcionario.Dep.ToString();
            lblSalarioBase.Text = Funcionario.SalarioBase.ToString();

            var salarioFinal = Funcionario.SalarioBase;
            foreach (Contrato c in Funcionario.Contratos)
            {
                salarioFinal += c.ValorFinalContrato;
            }

            Funcionario.SalarioFinal = salarioFinal;
            lblSalarioFinal.Text = salarioFinal.ToString();
        }

        public Funcionario Salvar()
        {
            return Funcionario;
        }
    }
}
