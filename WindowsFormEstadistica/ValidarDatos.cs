using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEstadistica
{
    public class ValidarDatos
    {
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static void SoloDecimales(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals(","))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static int NumeroCaracteres(TextBox textBox,int maxnumeros,KeyPressEventArgs v)
        {
            char serapador = ',';
            string[] strarray = textBox.Text.Split(serapador);

            int numero = 0;
            if (textBox.Text.Length == 0)
            {
                numero = maxnumeros;
            }
            else if (v.KeyChar.ToString().Equals(",") || textBox.Text.Length >= maxnumeros)
            {
                numero = strarray[0].Length;
            }

            return numero;
        }

        public static void MaximoCaracteres(TextBox textBox, int enteros, int decimales, KeyPressEventArgs v)
        {
            decimales = enteros + 1 + decimales;
            if (textBox.Text.Length == enteros && !v.KeyChar.ToString().Equals(",") && v.KeyChar != Convert.ToChar(Keys.Back))
            {
                v.Handled = true;
            }
            else if (textBox.Text.Length == decimales && v.KeyChar != Convert.ToChar(Keys.Back))
            {
                v.Handled = true;
            }
        }

    }
}

