using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Profesor : Empleado
    {
        public string Titulo { get; set; }
        public int AñosAntiguedad { get; set; }

        public Profesor()
        {
            Console.WriteLine("Ingrese el titulo del profesor: ");
            this.Titulo = Console.ReadLine();
            Console.WriteLine("Ingrese Años del profesor: ");
            this.AñosAntiguedad = int.Parse(Console.ReadLine());
        }

        public string ObtEstadoAntiguedad()
        {
            if (this.AñosAntiguedad < 1)
            {
                return "Temporal";
            }
            else
            {
                if (this.AñosAntiguedad >= 1 && this.AñosAntiguedad < 5)
                {
                    return "Permanente";
                }
                else
                {
                    if (this.AñosAntiguedad >= 5 && this.AñosAntiguedad < 10)
                    {
                        return "Senior";
                    }
                    else
                    {
                        return "Pro";
                    }
                }
            }
        }
    }
}


