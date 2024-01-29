using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {Atleti atleta1 = new Atleti();
            atleta1.Sport = "Tennis";
            Console.WriteLine("Atleta1: " + atleta1.Sport);
            Console.WriteLine("\n");
            Atleti atleta2 = new Atleti();
            atleta2.Sport = "Calcio";
            Console.WriteLine("Atleta2: " + atleta2.Sport);
            Console.WriteLine("\n");
            string allenamento = atleta1.SvolgiAllenamento();
            Console.WriteLine(allenamento);
            Console.WriteLine("\n");

            Animali animale1= new Animali();
            animale1.Specie = "Leone";
            Console.WriteLine("Animale1 è: " + animale1.Specie );
            Console.WriteLine("\n");
            Animali animale2= new Animali();
            animale2.Specie = "Giraffa";
            Console.WriteLine("Animale2 è: " + animale2.Specie );
            string tipoAlimentazione = animale1.Alimentazione("carnivoro");
            Console.WriteLine(tipoAlimentazione);
            string tipoAlimentazione2 = animale2.Alimentazione("vegetariano");


            Veicoli veicolo1 = new Veicoli();
            veicolo1.Tipo = "Auto";
            Console.WriteLine("Veicolo1: " +  veicolo1.Tipo);
            Console.WriteLine("\n");
            Veicoli veicolo2= new Veicoli();
            veicolo2.Tipo = "Moto";
            Console.WriteLine("Veicolo2: " + veicolo2.Tipo);
            Console.WriteLine("\n");
            string competizione = veicolo1.PuòGareggiare(160);
            Console.WriteLine("Il veicolo1: " + competizione);
            string altraCompetizione = veicolo2.PuòGareggiare(120);
            Console.WriteLine("Il veicolo2: " + altraCompetizione);

            Console.ReadLine();
        }

    }
}
