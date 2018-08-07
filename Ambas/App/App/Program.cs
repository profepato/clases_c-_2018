using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace App {
    class Program {
        static void Main(string[] args) {
            Deporte futbol = new Deporte();
            Deporte basket = new Deporte();

            futbol.Id = 1;
            futbol.Nombre = "Futbol";
            futbol.Popularidad = 95;

            basket = new Deporte() {
                Popularidad = 60,
                Id = 2,
                Nombre = "Baskett"
            };

            Deporte d = new Deporte();

            d.Id = 3;
            Console.Write("Nombre deporte: ");
            d.Nombre = Console.ReadLine();

            Console.Write("Popularidad: ");
            d.Popularidad = int.Parse(Console.ReadLine());

            Console.WriteLine(d.Id);
            Console.WriteLine(d.Nombre);
            Console.WriteLine(d.Popularidad);


            List<Deporte> deportes = new List<Deporte>();

            deportes.Add(futbol);
            deportes.Add(basket);
            deportes.Add(d);

            Console.WriteLine("Cantidad: "+deportes.Count);

            foreach (Deporte dep in deportes) {
                Console.WriteLine("{0} - {1} - {2}", 
                    dep.Id, dep.Nombre, dep.Popularidad);
            }

            if (d.Popularidad > 50) {
                Console.WriteLine(d.Nombre+" es popular");
            }
            


            Console.Write("Presione una tecla...");
            Console.ReadLine();
        }
    }
}
