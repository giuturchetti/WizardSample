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

namespace WizardTest.View
{
    public partial class ucWizard2 : UserControl
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public ucWizard2()
        {
            InitializeComponent();
            cmbDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedItem is Departamento)
            {
                MessageBox.Show(cmbDepartamento.SelectedItem.ToString());
                MessageBox.Show((cmbDepartamento.SelectedItem is Departamento).ToString());
            }
        }
    }
}
