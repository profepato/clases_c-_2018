using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces_DAO.interfaces {
    class Cuadrado : IFigura {
        private int lado;

        public int Lado { get => lado; set => lado = value; }

        public int GetArea() {
            return lado * lado;
        }

        public int GetPerimetro() {
            return lado * 4;
        }
    }
}
