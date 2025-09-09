using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
            string resultado = ""; // PROBLEMA 1 CORREGIDO: Variable declarada en el ámbito correcto

            try
            {
                // PROBLEMA 2 CORREGIDO: Usar TextBox en lugar de archivos
                // Asumiendo que tienes TextBoxes llamados txtA1, txtA2, txtB1, txtB2
                double a1 = double.Parse(txtA1.Text);
                double a2 = double.Parse(txtA2.Text);
                double b1 = double.Parse(txtB1.Text);
                double b2 = double.Parse(txtB2.Text);

                // PROBLEMA 3 CORREGIDO: Validación mejorada
                // No es necesario que a1 sea diferente de cero para calcular la inversa
                // Lo importante es que el determinante no sea cero

                // Matriz original
                double[,] matriz = { { a1, a2 }, { b1, b2 } };

                // Calcular determinante
                double det = a1 * b2 - a2 * b1;

                // PROBLEMA 4 CORREGIDO: Usar Math.Abs para comparar con tolerancia
                if (Math.Abs(det) < 1e-12) // Tolerancia para errores de punto flotante
                {
                    MessageBox.Show($"La matriz no tiene inversa (determinante ≈ 0).\nDeterminante calculado: {det:E}",
                                  "Matriz Singular", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calcular inversa usando la fórmula para matrices 2x2
                double[,] inversa = {
                    { b2 / det, -a2 / det },
                    { -b1 / det, a1 / det }
                };

                // PROBLEMA 5 CORREGIDO: Mostrar todos los elementos de la matriz inversa
                txtX1.Text = inversa[0, 0].ToString("F6"); // Elemento (0,0)
                txtX2.Text = inversa[0, 1].ToString("F6"); // Elemento (0,1)

                resultado = $"=== MATRIZ INVERSA CALCULADA ===\n\n";
                resultado += $"Matriz original A:\n";
                resultado += $"| {a1:F4}  {a2:F4} |\n";
                resultado += $"| {b1:F4}  {b2:F4} |\n\n";
                resultado += $"Determinante: {det:F6}\n\n";
                resultado += $"Matriz inversa A⁻¹:\n";
                resultado += $"| {inversa[0, 0]:F6}  {inversa[0, 1]:F6} |\n";
                resultado += $"| {inversa[1, 0]:F6}  {inversa[1, 1]:F6} |\n\n";


            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Por favor ingrese valores numéricos válidos en todos los campos.",
                              "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // PROBLEMA 6 CORREGIDO: Return para evitar continuar
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Error: No se pudo encontrar el archivo: {ex.FileName}",
                              "Archivo No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // PROBLEMA 7 CORREGIDO: Lógica del diálogo mejorada
            DialogResult confirmacion = MessageBox.Show(
                "¿Desea ver los detalles del cálculo de la matriz inversa?",
                "Mostrar Detalles",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                MessageBox.Show(resultado, "Detalles del Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            MessageBox.Show("Matriz inversa calculada exitosamente",
                          "Operación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
