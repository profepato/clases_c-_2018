using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto {
    class Jugador {
        private int id;
        private String nombre;
        private int dorsal;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Dorsal { get => dorsal; set => dorsal = value; }

        public override string ToString() {
            return nombre + " - " + dorsal;
        }

        /*public String GetNombre() {
            return this.nombre;
        }

        public void PegarBalon() {
            Console.WriteLine("GOL!");
        }*/
    }
}
