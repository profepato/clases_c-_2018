using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces.herencia {
    class Docente : Trabajador {
        private String titulo;

        public string Titulo { get => titulo; set => titulo = value; }
    }
}
