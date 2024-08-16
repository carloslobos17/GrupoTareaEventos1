using System.Globalization;

namespace Conversor_De_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conversor conversor = new();

                string inputText = textBoxGrados.Text.Trim();
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    label5.Text = "Ingrese un valor en el campo de grados.";
                    return;
                }

                if (!double.TryParse(inputText, NumberStyles.Any, CultureInfo.CurrentCulture, out double inputTemp))
                {
                    label5.Text = "Ingrese un número válido.";
                    return;
                }

                double resultado;

                if (comboBox1.SelectedItem != null)
                {
                    if (comboBox1.SelectedItem.ToString() == "Celsius a Fahrenheit")
                    {
                        resultado = conversor.CelsiusAFahrenheit(inputTemp);
                        label5.Text = $"{inputTemp} °C son {resultado} °F";
                    }
                    else if (comboBox1.SelectedItem.ToString() == "Fahrenheit a Celsius")
                    {
                        resultado = conversor.FahrenheitACelsius(inputTemp);
                        label5.Text = $"{inputTemp} °F son {resultado} °C";
                    }
                    else
                    {
                        label5.Text = "Opción de conversión no reconocida.";
                    }
                }
                else
                {
                    label5.Text = "Seleccione una opción de conversión.";
                }
            }
            catch (Exception ex)
            {
                label5.Text = $"Error: {ex.Message}";
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGrados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGrados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
