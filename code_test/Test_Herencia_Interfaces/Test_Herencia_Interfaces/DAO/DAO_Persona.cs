using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Necesario
using Test_Herencia_Interfaces.herencia;

namespace Test_Herencia_Interfaces.DAO {
    class DAO_Persona : Conexion, DAO<Persona> {
        public void Create(Persona ob) {
            base.Ejecutar("INSERT: "+ob.Nombre);
        }

        public void Delete(int id) {
            base.Ejecutar("DELETE: "+id);
        }

        public List<Persona> Read() {
            List<Persona> lista = new List<Persona>();

            base.Ejecutar("SELECT * ");

            return lista;
        }

        public void Update(Persona ob) {
            base.Ejecutar("DELETE: "+ob.Nombre);
        }
    }
}
