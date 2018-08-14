using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_WF_140818 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e) {
            FormMenu fm = new FormMenu();
            fm.Show();
            /*aslkdjalksjdlksa*/
            // comentarios
            /*MessageBox.Show(
                "Hola", 
                "Titulo", 
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Error
                );*/
        }

        private void abrirMenúToolStripMenuItem_Click(object sender, EventArgs e) {
            FormMenu fm = new FormMenu();
            fm.Show();
        }
    }
}
