using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Herencia_Interfaces_DAO.herencia;

namespace Test_Herencia_Interfaces_DAO.DAO {
    class DAO_Persona : IDAO<Persona> {
        private List<Persona> lista;

        public DAO_Persona() {
            lista = new List<Persona>();
        }

        public void Create(Persona ob) {
            lista.Add(ob);
        }

        public void Delete(string id) {
            lista.RemoveAll(p => p.Id == id);
        }

        public List<Persona> Read() {
            return lista;
        }

        public void Update(Persona ob) {
            // ??? desarrollar!!!
        }
    }
}
