using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces.herencia {
    class Trabajador : Persona {
        private long sueldo;
        private String tipoContrato;

        public long Sueldo { get => sueldo; set => sueldo = value; }
        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
    }
}
