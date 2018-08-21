using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces_DAO.interfaces {
    class Rectangulo : IFigura {
        private int ancho;
        private int alto;

        public int Ancho { get => ancho; set => ancho = value; }
        public int Alto { get => alto; set => alto = value; }

        public int GetArea() {
            return Ancho * Alto;
        }

        public int GetPerimetro() {
            return (2 * Ancho) + (2 * Alto);
        }
    }
}
