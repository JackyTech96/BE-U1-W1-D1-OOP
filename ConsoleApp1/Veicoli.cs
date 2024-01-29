using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Veicoli
    {
        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string PuòGareggiare(int cavalli)
        {if (cavalli>150)
            { return "Può gareggiare!"; }
            else { return "Non può gareggiare"; }
        }
    }
}
