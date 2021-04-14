using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WizardTest.Entities;
using WizardTest.View;

namespace WizardTest
{
    public partial class Form1 : Form
    {
        private Funcionario Funcionario;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new FrmFuncionarioWizard())
            {
                f.ShowDialog();
                if (f.Concluiu)
                {
                    Funcionario = f.Funcionario;
                    label1.Text = Funcionario.ToString();
                    pnFuncionarios.Controls.Add(new ucFuncionario(Funcionario));
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
