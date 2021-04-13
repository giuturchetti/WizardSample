using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardTest.View
{
    public partial class ucWizard1 : UserControl
    {
        public bool Concorda { get; private set; } = false;

        public event Action<bool> ConcordoChanged;
        
        public ucWizard1()
        {
            InitializeComponent();
        }

        private void chbConcordo_CheckedChanged(object sender, EventArgs e)
        {
            Concorda = chbConcordo.Checked;
            ConcordoChanged?.Invoke(Concorda);
        }
    }
}
