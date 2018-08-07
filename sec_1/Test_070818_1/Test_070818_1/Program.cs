using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Test_070818_1 {
    class Program {
        static void Main(string[] args) {
            Persona p = new Persona();

            p.Rut = "11-1";
            p.Nombre = "Pablo Pérez";
            p.Edad = 20;

            Console.WriteLine("Rut: "+p.Rut);
            Console.WriteLine("Nombre: " + p.Nombre);
            Console.WriteLine("Edad: " + p.Edad);

            List<Persona> lista = new List<Persona>();

            Persona p2 = new Persona();

            p2.Rut = "22-2";
            p2.Nombre = "Matías Díaz";
            p2.Edad = 22;

            Persona p3 = new Persona();

            p3.Rut = "33-3";
            p3.Nombre = "Eduardo Rubio";
            p3.Edad = 24;

            lista.Add(p);
            lista.Add(p2);
            lista.Add(p3);
            lista.Add(new Persona() {
                Rut = "44-4",
                Nombre = "Aranda",
                Edad =26}
            );

            Console.WriteLine("Lista de personas");
            foreach (Persona per in lista) {
                Console.WriteLine(per);
            }

            Ciudad ciu = new Ciudad(1, "Rancagua");

            // Console.WriteLine(ciu.Id + " - "+ ciu.Nombre);
            Console.WriteLine("{0} - {1}", ciu.Id, ciu.Nombre);

            Console.Write("Presione una tecla...");
            Console.ReadLine();
        }
    }
}
