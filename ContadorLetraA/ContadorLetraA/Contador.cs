using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorLetraA
{
    public class Contador
    {
        public int ContarAs(string texto)
        {
            int contadorDeAs = 0;
            foreach (char c in texto)
            {
                if (c == 'a' || c == 'A')
                {
                    contadorDeAs++;
                }
            }
            return contadorDeAs;
        }
    }


}
