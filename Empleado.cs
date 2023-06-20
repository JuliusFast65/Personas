using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
  
    public partial class Empleado : Persona
    {

        public double Sueldo { get; set; }

        public Empleado()
        {
            Console.WriteLine("Ingrese el sueldo del profesor: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());
        }
  
    }
}
