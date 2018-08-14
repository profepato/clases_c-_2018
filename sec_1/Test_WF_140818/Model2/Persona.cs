using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2 {
    public class Persona {
        private String rut;
        private String nombre;
        private int fk_ciudad;
        private String sexo;

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fk_ciudad { get => fk_ciudad; set => fk_ciudad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
