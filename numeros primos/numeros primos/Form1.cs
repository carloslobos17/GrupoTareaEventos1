namespace numeros_primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertLabel_Click(object sender, EventArgs e)
        {

        }

        

        private void resultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal number = Convert.ToDecimal(numberTextBox.Text);
                decimal total = number % 2;
                if (total != 0)
                {
                    resultsLabel.Text = "Su numero es primo";
                }
                else
                {
                    resultsLabel.Text = "Su numero no es primo, es par";
                }
            }
            catch(FormatException ex)
            {
				errorProvider.SetError(numberTextBox, "Inserte un numero valido");
				resultsLabel.Text = "Inserte un numero valido";
                numberTextBox.Focus();
            }
            catch(Exception ex) 
            {
				resultsLabel.Text= ex.Message;

			}
		}

    }
}
