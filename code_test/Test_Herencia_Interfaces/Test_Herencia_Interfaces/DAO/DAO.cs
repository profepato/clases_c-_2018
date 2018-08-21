using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Herencia_Interfaces.DAO {
    interface DAO<T> {
        void Create(T ob);
        List<T> Read();
        void Update(T ob);
        void Delete(int id);
    }
}
