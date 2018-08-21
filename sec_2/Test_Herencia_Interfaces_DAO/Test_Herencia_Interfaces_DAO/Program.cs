using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Herencia_Interfaces_DAO.DAO;
using Test_Herencia_Interfaces_DAO.herencia;
using Test_Herencia_Interfaces_DAO.interfaces;

namespace Test_Herencia_Interfaces_DAO {
    class Program {
        static void Main(string[] args) {
            DAO_Persona dp = new DAO_Persona();
            // DAO_Trabajador dt = new DAO_Trabajador();
            
            Console.Write("Cuantas Personas?: ");
            int vueltas = int.Parse(Console.ReadLine());

            for (int i = 0; i < vueltas; i++) {
                Persona per = new Persona();

                Console.Write("ID: ");
                per.Id = Console.ReadLine();
                Console.Write("Rut: ");
                per.Rut = Console.ReadLine();
                Console.Write("Nombre: ");
                per.Nombre = Console.ReadLine();
                Console.Write("Edad: ");
                per.Edad = int.Parse(Console.ReadLine());

                dp.Create(per);
            }

            foreach (Persona p in dp.Read()) {
                Console.WriteLine("------------------------");
                Console.WriteLine("ID       :  " + p.Id);
                Console.WriteLine("Rut      :  " + p.Rut);
                Console.WriteLine("Nombre   :  " + p.Nombre);
                Console.WriteLine("Edad     :  " + p.Edad);
                Console.WriteLine("------------------------");
            }

            /*Docente doc = new Docente();

            doc.Id              = "1";
            doc.Edad            = 56;
            doc.Nombre          = "Ricardo Soto";
            doc.Rut             = "11-1";
            doc.Sueldo          = 980000;
            doc.TipoContrato    = "Plazo fijo";
            doc.Titulo          = "Psicólogo";

            Console.WriteLine("------------------------");
            Console.WriteLine("RUT   :  "+doc.Rut       );
            Console.WriteLine("Nombre:  "+doc.Nombre    );
            Console.WriteLine("Título:  "+doc.Titulo    );
            Console.WriteLine("Sueldo:  "+doc.Sueldo    );
            Console.WriteLine("------------------------");

            Rectangulo rec = new Rectangulo();

            Console.Write("Ingrese el ancho del rectángulo: ");
            rec.Ancho = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el alto del rectángulo: ");
            rec.Alto = int.Parse(Console.ReadLine());

            Console.WriteLine("El área del rectángulo" +
                " [{0},{1}] es {2}",
                rec.Alto, rec.Ancho, rec.GetArea());

            Console.WriteLine("El perímetro del rectángulo" +
                " [{0},{1}] es {2}",
                rec.Alto, rec.Ancho, rec.GetPerimetro());
            */

            // Pause
            Console.Write("Presione una tecla para continuar...");
            Console.ReadLine();
            // Pause
        }
    }
}
