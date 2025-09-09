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
    public partial class Matriz2x2 : Form
    {
        public Matriz2x2()
        {
            InitializeComponent();
            MessageBox.Show("A continuación, ingrese los valores que se les solicita", "Ingrese datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal menu = new Principal();
            MessageBox.Show("Regresando al menú principal", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            menu.Show();
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show
               ("¿Ha verificado bien sus datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
                return;
            else
            {
                MessageBox.Show("Datos registrados exitosamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
