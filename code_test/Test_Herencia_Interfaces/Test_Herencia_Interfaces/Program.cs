using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// using necesario
using Test_Herencia_Interfaces.herencia;
using Test_Herencia_Interfaces.interfaces;
using Test_Herencia_Interfaces.DAO;

namespace Test_Herencia_Interfaces {
    class Program {
        static void Main(string[] args) {
            // Lectura sugerida
            // https://thatcsharpguy.com/post/var-en-c-sharp/
            Trabajador t = new Trabajador();

            t.Rut = "11-1";
            t.Nombre = "Nombre 1";
            t.Edad = 30;
            t.Sueldo = 450000;
            t.TipoContrato = "Plazo fijo";

            Docente d = new Docente();

            d.Rut = "22-2";
            d.Nombre = "Nombre 2";
            d.Edad = 34;
            d.Sueldo = 980000;
            d.TipoContrato = "Plazo fijo";
            d.Titulo = "Psicólogo";
            
            if (d is Persona) {
                Console.WriteLine("Es persona..");
            }

            if (d is Trabajador) {
                Console.WriteLine("Es trabajador...");
            }

            if (d is Docente) {
                Console.WriteLine("Es docente...");
            }


            // Figuras de interfaces
            Cuadrado c = new Cuadrado();
            Rectangulo r = new Rectangulo();

            c.Lado = 23;

            r.Alto = 2;
            r.Ancho = 12;

            Console.WriteLine("Área del cuadrado lado {0}: {1}", c.Lado, c.GetArea());
            Console.WriteLine("Perímetro del cuadrado lado {0}: {1}", c.Lado, c.GetPerimetro());

            Console.WriteLine("Área del rectangulo ancho {0} y alto {1} es: {2}"
                , r.Ancho, r.Alto, r.GetArea());
            Console.WriteLine("Perímetro del rectangulo ancho {0} y alto {1} es: {2}"
                , r.Ancho, r.Alto, r.GetPerimetro());





            // DAO Persona
            DAO_Persona dp = new DAO_Persona();

            dp.Create(new Persona() { Nombre = "Nombre 3" });
            List<Persona> lista = dp.Read();
            dp.Update(new Persona() { Nombre = "Nombre 2"});
            dp.Delete(1);

            Console.ReadLine();
        }
    }
}
