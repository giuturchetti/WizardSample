using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WizardTest.Entities.Tipos;

namespace WizardTest.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        private Departamento _dep;
        public Departamento Dep 
        {
            get
            {
                return _dep;
            }
            set
            {                
                _dep = value;

                if (Dep == Departamento.Desenvolvimento)
                {
                    SalarioBase = 3000.00;
                }
                else if (Dep == Departamento.Design)
                {
                    SalarioBase = 2800.00;
                }
            }
        }
        public double SalarioBase { get; private set; }
        public List<Contrato> Contratos { get; set; }
        public double SalarioFinal { get; set; }

        public Funcionario()
        {
            Dep = Departamento.Design;
        }

        public Funcionario(int id, string nome, string cPF, string telefone, Departamento dep, List<Contrato> contratos)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
            Dep = dep;
        }

        public void AdicionarContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double CalcularSalarioFinal()
        {
            var salarioFinal = SalarioBase;
            foreach (Contrato contrato in Contratos)
            {
                salarioFinal += contrato.ValorFinalContrato;
            }

            return salarioFinal;
        }

        public override string ToString()
        {
            //foreach....

            var contratos = string.Join(", ", Contratos.Select(c => c.ToString()));

            return $"Id: {Id} - " +
                $"Funcionário: {Nome} - " +
                $"CPF: {CPF} - " +
                $"Telefone: {Telefone} - " +
                $"Departamento: {Dep} - " +
                $"Salário Base: {SalarioBase} - " +
                $"Contratos: {contratos} - " +
                $"Salário Final: {SalarioFinal}";
        }
    }
}
