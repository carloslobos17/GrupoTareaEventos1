using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mauseforms.forms
{
    public partial class mauseForm1 : Form
    {
        public mauseForm1()
        {
            InitializeComponent();
        }

        private void calcularbutton1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Obtener el valor del número 
                double number = Convert.ToDouble(ingresarnumbertextBox1.Text);

                // Validar que el número que el usuario ingreso
                if (number < 0)
                {
                    MessageBox.Show("Por favor, ingresa un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // calcular la raiz
                double result = Math.Sqrt(number);

                //resultado que el usuario ingrese en el apartado
                resultadoLabel1.Text = $"La raíz cuadrada de {number} es {result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
