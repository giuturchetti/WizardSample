using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardTest.Entities.Tipos;

namespace WizardTest.View
{
    public partial class FrmFuncionarioWizard : Form
    {
        private TelaWizard _tela;


        private TelaWizard TelaAtual
        {
            get
            {
                return _tela;
            }
            set
            {
                if (_tela != value)
                {
                    _tela = value;
                    HabilitarDesabilitarBotoes();
                }
            }
        }

        public FrmFuncionarioWizard()
        {
            InitializeComponent();
            uc1.ConcordoChanged += Uc1_ConcordoChanged;
            TelaAtual = TelaWizard.Um;
        }

        private void Uc1_ConcordoChanged(bool concorda)
        {
            btnAvancar.Enabled = concorda;
        }

        private void HabilitarDesabilitarBotoes()
        {
            if (TelaAtual == TelaWizard.Um)
            {
                btnVoltar.Enabled = false;
                btnAvancar.Enabled = false;
            }
            else if (TelaAtual == TelaWizard.Dois)
            {
                btnVoltar.Enabled = true;
                btnAvancar.Enabled = true;
            }
            else if (TelaAtual == TelaWizard.Tres)
            {
                btnVoltar.Enabled = true;
                btnAvancar.Enabled = true;
            }
            else if (TelaAtual == TelaWizard.Quatro)
            {
                btnVoltar.Enabled = true;
                btnAvancar.Enabled = true;
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (TelaAtual == TelaWizard.Um)
            {
                uc1.Visible = false;
                uc2.Visible = true;
                TelaAtual = TelaWizard.Dois;
            }
            else if (TelaAtual == TelaWizard.Dois)
            {
                //uc2.Salvar();
                uc2.Visible = false;
                uc3.Visible = true;
                TelaAtual = TelaWizard.Tres;
            }
            else if (TelaAtual == TelaWizard.Tres)
            {
                uc3.Visible = false;
                uc4.Visible = true;
                btnAvancar.Text = "Concluir";
                TelaAtual = TelaWizard.Quatro;
            }
            else if (TelaAtual == TelaWizard.Quatro)
            {
                Close();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (TelaAtual == TelaWizard.Dois)
            {
                uc2.Visible = false;
                uc1.Visible = true;
                TelaAtual = TelaWizard.Um;
            }
            else if (TelaAtual == TelaWizard.Tres)
            {
                uc3.Visible = false;
                uc2.Visible = true;
                TelaAtual = TelaWizard.Dois;
            }
            else if (TelaAtual == TelaWizard.Quatro)
            {
                uc4.Visible = false;
                uc3.Visible = true;
                btnAvancar.Text = "Avançar";
                TelaAtual = TelaWizard.Tres;
            }
        }
    }
}
