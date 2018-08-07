using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto {
    class Program {
        static void Main(string[] args) {
            /*Jugador vidal = new Jugador();

            // Vidal
            vidal.Id = 1;
            vidal.Nombre = "Arturo Vidal";
            vidal.Dorsal = 0;

            Console.WriteLine(vidal);
            */

            List<Jugador> lista = new List<Jugador>();

            int cont = 1;
            Jugador j;
            while (true) {
                j = new Jugador();
                Console.Write("Ingrese nombre: ");
                j.Nombre = Console.ReadLine();

                Console.Write("Ingrese dorsal: ");


                if (cont == 3) {
                    break;
                }
                cont++;
            }

            Console.ReadLine();
        }
    }
}
