using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animali
    {
        private string _specie;
        public string Specie {
            get { return _specie; } 
            set { _specie = value; }
        }
        public string Alimentazione(string cibo) 
        {
            switch (cibo.ToLower()) 
                {
                case "carnivoro":
                    return "Carnivoro";
                case "onnivoro":
                    return "Onnivoro";
                case "vegetariano":
                    return "Vegetariano";
                default:
                    return "Tipo alimentazione sconosciuto";
            }
                }
    }
}
