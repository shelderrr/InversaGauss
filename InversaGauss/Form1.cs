using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InversaGauss
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        //Los métodos img3x3 y 2x2 son para hacer que al presionar la imagen se rellene la opcion
        private void img3x3_Click(object sender, EventArgs e)
        {
            rbtnMatriz3x3.Checked = true;
        }

        private void img2x2_Click(object sender, EventArgs e)
        {
            rbtn2x2.Checked = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (rbtnMatriz3x3.Checked == true)
            {
                MessageBox.Show("Usted ha seleccionado la matriz 3x3.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Matriz3x3 formulario3x3 = new Matriz3x3();
                formulario3x3.Show();
                //Esconde el menú para abrir el otro 
                this.Hide();
            }
            else if (rbtn2x2.Checked == true)
            {          
                MessageBox.Show("Usted ha seleccionado la matriz 2x2.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Matriz2x2 formulario2x2 = new Matriz2x2();
                formulario2x2.Show();
                this.Hide();
            }
        }
    }
}
