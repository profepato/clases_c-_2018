using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Ciudad {
        private int id;
        private String nombre;

        public Ciudad(int id, String nombre) {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
