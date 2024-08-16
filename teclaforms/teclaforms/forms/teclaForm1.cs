using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teclaforms.forms
{
    public partial class teclaForm1 : Form
    {
        public teclaForm1()
        {
            InitializeComponent();
        }

        private void consonanteTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            char tecla = char.ToLower((char)e.KeyCode);

            
            if ("bcdfghjklmnpqrstvwxyz".Contains(tecla))
            {
                
                resultadoLabel2.Text = $"Se presionó la consonante: {tecla}";
            }
            if ("aeiuo".Contains(tecla))
            {

                resultadoLabel2.Text = $"Se presionó la vocal: {tecla}";
            }
            if ("123456789".Contains(tecla))
            {

                resultadoLabel2.Text = $"Se presionó el numero: {tecla}";
            }
            else 
            {
                resultadoLabel2.Text = $"no es  consonante: {tecla}";
            }
        }
    }
}
