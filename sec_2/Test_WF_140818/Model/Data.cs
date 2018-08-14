using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Data {
        private List<Computador> compus;
        private List<Marca> marcas;

        public Data() {
            compus = new List<Computador>();
            marcas = new List<Marca>();

            marcas.Add(new Marca() { Id = 1, Nombre = "MSI"});
            marcas.Add(new Marca() { Id = 2, Nombre = "Samsung"});
            marcas.Add(new Marca() { Id = 3, Nombre = "HP"});

            compus.Add(new Computador() {
                Codigo = "11",
                Marca = 1,
                Modelo = "2QE",
                Precio = 1200000,
                Nuevo = true
            });

            compus.Add(new Computador() {
                Codigo = "22",
                Marca = 2,
                Modelo = "Serie 5",
                Precio = 650000,
                Nuevo = false
            });
        }

        public List<Computador> GetComputadores() {
            return this.compus;
        }

        public List<Marca> GetMarcas() {
            return this.marcas;
        }

        public void Imprimir() {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Listado de computadores");
            Console.WriteLine("--------------------------");
            foreach (Computador c in compus) {
                Console.WriteLine((c.Nuevo ? "[Nuevo]" : "[Usado]")+" {0} - {1} - {2} - {3}", 
                    c.Codigo, c.Marca, c.Modelo, c.Precio);
            }
            Console.WriteLine("--------------------------");
        }

        public void AddComputador(Computador c) {
            compus.Add(c);
        }
    }
}
