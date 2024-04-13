using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASE_SOBRECARGA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var America = new Equipo("Americano", new DateTime(2024,02,15), 5, 122000);
            var Argentino = new Equipo("Argentino", new DateTime(2000,10,1), 5, 200);
            var Chileno = new Equipo("Chileno", new DateTime(2003,11,30), 5, 3000);
           
            Console.WriteLine(America);
            Console.WriteLine(Argentino);
            Console.WriteLine(Chileno);
           
            if (Argentino > Chileno)
            {
                Console.WriteLine(America);
            }

            else
            {
                Console.WriteLine(Argentino);
                Console.WriteLine(Chileno);
            }
                
            
        }
    }
}
