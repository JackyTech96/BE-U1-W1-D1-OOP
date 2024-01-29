using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Atleti
    {
        private string _sport;
        public string Sport 
        { 
            get { return _sport; }
            set { _sport = value; } 
        }
        public string SvolgiAllenamento()
        {
           return $"L'atleta sta svolgendo l'allenamento nel campo di {Sport}.";
        }

    }
}
