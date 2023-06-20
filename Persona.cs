using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Persona
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona()
        {
            Console.WriteLine("Ingrese nombre de la persona: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad de la persona: ");
            Edad = int.Parse(Console.ReadLine());
        }

    }
}
