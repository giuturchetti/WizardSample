using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardTest.View
{
    public partial class FrmContrato : Form
    {
        public string Identificador { get; private set; }
        public double ValorHora { get; private set; }
        public int QtdeHora { get; private set; }

        public FrmContrato()
        {
            InitializeComponent();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Identificador = txtIdentificador.Text;
            ValorHora = Double.Parse(txtValorHora.Text);
            QtdeHora = int.Parse(txtQtdeHoras.Text);

            Close();
        }
    }
}
