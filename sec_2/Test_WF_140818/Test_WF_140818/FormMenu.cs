using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Test_WF_140818 {
    public partial class FormMenu : Form {
        private Data d;
                
        public FormMenu() {
            InitializeComponent();

            d = new Data();

            StartPosition = FormStartPosition.CenterScreen;

            // para que no se pueda editar
            cboMarca.DropDownStyle = ComboBoxStyle.DropDownList;

            // vichual
            chkNuevo.Checked = true;
            
            // lista con datos en un cbo
            cboMarca.DataSource = d.GetMarcas();

            cboMarca.DisplayMember = "nombre";
            cboMarca.ValueMember = "id";
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            Computador c = new Computador();

            c.Codigo = txtCodigo.Text;
            c.Marca = (int) cboMarca.SelectedValue;
            c.Modelo = txtModelo.Text;
            c.Precio = int.Parse(txtPrecio.Text);
            c.Nuevo = chkNuevo.Checked;

            d.AddComputador(c);
            d.Imprimir();

            limpiarForm();

            txtCodigo.Focus();
            MessageBox.Show("Compu Registrado!");
        }

        private void limpiarForm() {
            txtCodigo.ResetText();
            txtModelo.ResetText();
            txtPrecio.ResetText();

            cboMarca.SelectedIndex = 1;
            chkNuevo.Checked = true;
        }
    }
}
