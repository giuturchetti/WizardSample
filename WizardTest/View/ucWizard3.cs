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
    public partial class ucWizard3 : UserControl
    {
        private List<Contrato> _contratos = new List<Contrato>();

        public ucWizard3()
        {
            InitializeComponent();
        }

        private void btnCriarContrato_Click(object sender, EventArgs e)
        {
            using (var f = new FrmContrato())
            {
                f.ShowDialog();
                var contrato = new Contrato(
                    f.Identificador,
                    f.ValorHora,
                    f.QtdeHora
                );

                _contratos.Add(contrato);

                bsContratos.DataSource = _contratos;
            }

            bsContratos.ResetBindings(false);
        }
    }
}
