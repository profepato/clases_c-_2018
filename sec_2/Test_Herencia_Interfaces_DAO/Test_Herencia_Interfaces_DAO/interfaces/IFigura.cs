using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces_DAO.interfaces {
    interface IFigura {
        // Defino lo qué debo hacer
        // pero no cómo
        // no es necesario el modificador de acceso
        int GetArea();
        int GetPerimetro();
    }
}
