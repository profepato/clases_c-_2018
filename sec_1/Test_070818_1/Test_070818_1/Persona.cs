using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_070818_1 {
    class Persona {
        private String rut;
        private String nombre;
        private int edad;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

       
        public override string ToString() {
            return this.rut + " - " + this.Nombre;
        }

        public String GetNombre() {
            return this.nombre;
        }


    }
}
