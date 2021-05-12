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

        public static void SoloDecimales(TextBox textBox, KeyPressEventArgs v)
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
            else if (textBox.Text.Length >= 1 && v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static int NumeroCaracteresDecimales(TextBox textBox,int maxnumeros,KeyPressEventArgs v)
        {
            char serapador = '.';
            string[] strarray = textBox.Text.Split(serapador);

            int numero = 0;
            if (textBox.Text.Length == 0)
            {
                numero = maxnumeros;
            }
            else if (textBox.Text.Contains(".") || textBox.Text.Length >= maxnumeros)
            {
                numero = strarray[0].Length;
            }

            return numero;
        }

        public static void MaximoCaracteresDecimales(TextBox textBox, int enteros, int decimales, KeyPressEventArgs v)
        {
            decimales = enteros + 1 + decimales;
            if (textBox.Text.Length == enteros && !v.KeyChar.ToString().Equals(".") && v.KeyChar != Convert.ToChar(Keys.Back))
            {
                v.Handled = true;
            }
            else if (textBox.Text.Length == decimales && textBox.Text.Contains(".")  && v.KeyChar != Convert.ToChar(Keys.Back))
            {
                    v.Handled = true;
            }       
           
        }

        public static void MaximoCaracteresEnteros(TextBox textBox, int enteros, KeyPressEventArgs v)
        {
            if (textBox.Text.Length == enteros && v.KeyChar != Convert.ToChar(Keys.Back))
            {
                v.Handled = true;
            }
        }

    }
}

