using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Herencia_Interfaces_DAO.herencia;

namespace Test_Herencia_Interfaces_DAO.DAO {
    class DAO_Trabajador : IDAO<Trabajador> {
        private List<Trabajador> lista;

        public DAO_Trabajador() {
            lista = new List<Trabajador>();
        }

        public void Create(Trabajador ob) {
            lista.Add(ob);
        }

        public void Delete(string id) {
            lista.RemoveAll(t => t.Id == id);
        }

        public List<Trabajador> Read() {
            return lista;
        }

        public void Update(Trabajador ob) {
            // 25% para usted
            // ob --> ya viene con los datos nuevos
            // NO HACER! -> acá leer los datos nuevos (NAh QUE VER)
        }
    }
}
