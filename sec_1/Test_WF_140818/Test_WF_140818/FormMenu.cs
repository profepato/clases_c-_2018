using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model2;

namespace Test_WF_140818 {
    public partial class FormMenu : Form {
        private List<Persona> lisPersonas;

        public FormMenu() {
            InitializeComponent();

            lisPersonas = new List<Persona>();

            List<Ciudad> lista = new List<Ciudad>();

            lista.Add(new Ciudad() { Id = 1, Nombre = "Ciudad 1"});
            lista.Add(new Ciudad() { Id = 2, Nombre = "Ciudad 2"});
            lista.Add(new Ciudad() { Id = 3, Nombre = "Ciudad 3"});
            lista.Add(new Ciudad() { Id = 4, Nombre = "Ciudad 4"});

            cboCiudad.DataSource = lista;

            // no sea editable
            cboCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
            
            cboCiudad.DisplayMember = "Nombre";
            cboCiudad.ValueMember = "Id";
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            Persona p = new Persona();

            p.Rut = txtRut.Text;
            p.Nombre = txtNombre.Text;
            p.Fk_ciudad = (int)cboCiudad.SelectedValue;

            if (opFemenino.Checked)
                p.Sexo = "Femenino";
            else
                p.Sexo = "Masculino";

            lisPersonas.Add(p);

            // Limpiar el formulario
            txtNombre.Text = "";
            txtRut.Text = "";
            cboCiudad.SelectedIndex = 0;
            opFemenino.Checked = true;

            txtRut.Focus();

            Console.WriteLine("------------------------");
            Console.WriteLine("Listado de personas");
            Console.WriteLine("------------------------");
            foreach (Persona per in lisPersonas) {
                Console.WriteLine("{0} - {1} - {2} - {3}", 
                    per.Rut, per.Nombre, per.Fk_ciudad, per.Sexo);
            }
            Console.WriteLine("------------------------");

            MessageBox.Show("Persona registrada!");
            
            // DataGridView

        }
    }
}
