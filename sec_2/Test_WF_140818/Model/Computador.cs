using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Computador {
        private String codigo;
        private int marca;
        private String modelo;
        private int precio;
        private bool nuevo;

        public string Codigo { get => codigo; set => codigo = value; }
        public int Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Precio { get => precio; set => precio = value; }
        public bool Nuevo { get => nuevo; set => nuevo = value; }
    }
}
