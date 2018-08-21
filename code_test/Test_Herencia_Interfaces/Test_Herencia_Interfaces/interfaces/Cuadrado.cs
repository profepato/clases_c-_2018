using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces.interfaces {
    class Cuadrado : IFigura {
        private int lado;

        public int Lado { get => lado; set => lado = value; }

        public int GetArea() {
            return Lado * Lado;
        }

        public int GetPerimetro() {
            return 4 * Lado;
        }
    }
}
