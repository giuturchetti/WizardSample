using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardTest.Entities
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public string Identificador { get; set; }
        public double ValorHora { get; set; }
        public int QtdeHoras { get; set; }
        public double ValorFinalContrato
        {
            get
            {
                return ValorHora * QtdeHoras;
            }
        }
                

        public Contrato(string identificador, double valorHora, int qtdeHoras)
        {
            Data = DateTime.Now;
            Identificador = identificador;
            ValorHora = valorHora;
            QtdeHoras = qtdeHoras;
        }
    }
}
