using System.Windows.Forms;
using Area_y_perimetro2.clases;

namespace Area_y_perimetro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OctagonPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void octagonPerimeterButton_Click(object sender, EventArgs e)
        {
            try
            {

                double side = double.Parse(octagonSideTextBox.Text);

                Octagon octagon1 = new Octagon(side);

                resultsLabel.Text = $"El perimetro del octagono es {octagon1.CalculatePerimeter()}";
            }
                catch (FormatException ex)
            {
                resultsLabel.Text = "Inserte un numero valido";
            }
            catch (Exception ex)
            {
                resultsLabel.Text = ex.Message;

            }
        }

        private void octagonAreaButton_Click(object sender, EventArgs e)
        {
            try
            { double side = double.Parse(octagonSideTextBox.Text);

                Octagon octagon1 = new Octagon(side);

                resultsLabel.Text = $"El area del octagono es {octagon1.CalculateArea()}";
            }
            catch (FormatException ex)
            {
                resultsLabel.Text = "Inserte un numero valido";
            }
            catch (Exception ex)
            {
                resultsLabel.Text = ex.Message;

            }
        }

        private void trianglePerimeterButton_Click(object sender, EventArgs e)
        {
            try {
                double baase = double.Parse(baseTextBox.Text);

                TrianglePerimeter triangle1 = new TrianglePerimeter(baase);

                resultsLabel.Text = $"El perimetro del triangulo es {triangle1.CalculatePerimeter()}";
            }
            catch (FormatException ex)
            {
                resultsLabel.Text = "Inserte un numero valido";
            }
            catch (Exception ex)
            {
                resultsLabel.Text = ex.Message;

            }
        }

        private void triangleAreaButton_Click(object sender, EventArgs e)
        {
            try {
                double baase = double.Parse(baseTextBox.Text);
                double height = double.Parse(heightTextBox.Text);

                TriangleArea triangle1 = new TriangleArea(baase, height);

                resultsLabel.Text = $"El area del triangulo es {triangle1.CalculateArea()}";
            }
            catch (FormatException ex)
            {
                resultsLabel.Text = "Inserte un numero valido";
            }
            catch (Exception ex)
            {
                resultsLabel.Text = ex.Message;

            }
        }
       
    }
}