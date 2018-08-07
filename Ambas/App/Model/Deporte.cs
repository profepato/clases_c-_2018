using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Deporte {
        private int id;
        private String nombre;
        private int popularidad;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Popularidad { get => popularidad; set => popularidad = value; }
    }
}
