using Entity;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsGraficos
{
    public partial class TendenciaCentral : Form
    {
        private readonly List<TablaFrecuencia_E> DataFinal;
        private readonly string[] arraydata;
        public TendenciaCentral(List<TablaFrecuencia_E> Data,string[] data)
        {
            DataFinal = Data;
            arraydata = data;
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            DatosTotales_E dt = new DatosTotales_E();
            //media
            foreach (var item in DataFinal)
            {
                dt.sumatotal += item.xi * item.fi;
                dt.cantidatotal += item.fi;
            }

            txtMedia.Text = Convert.ToString(Math.Round(dt.sumatotal / dt.cantidatotal, 2));

            //moda
            dt.maximafrecuencia = DataFinal.Select(x => x.fi).Max();
            var ltfrecuencoa =  DataFinal.Where(x => x.fi == dt.maximafrecuencia).Select(y => y).FirstOrDefault();
            
            bool isNumeric = int.TryParse(ltfrecuencoa.xi.ToString(), out int n);

            if (isNumeric)
            {
                txtModa.Text = Convert.ToString(ltfrecuencoa.xi);
            }
            else if (!isNumeric)
            {
                txtModa.Text = Convert.ToString(ltfrecuencoa.xi + " (" + ltfrecuencoa.strxi + ")");
            }

            //mediana
            dt.nummediana = dt.cantidatotal / 2;

            if ((dt.cantidatotal % 2) == 0)
            {
                dt.ltmediana = arraydata.OrderBy(x => x).Select((x, i) =>
                              new Mediana_E { index = i, xi = Convert.ToDecimal(x) }).ToList();
                var tmpmediana = dt.ltmediana.Where(i => i.index == dt.nummediana-1 || i.index == dt.nummediana).ToList();

                decimal summediana = 0;
                foreach (var item in tmpmediana)
                {
                    summediana += item.xi;
                }
                txtMediana.Text = Convert.ToString(summediana / 2);

            }
            else
            {
               dt.ltmediana = arraydata.OrderBy(x => x).Select((x, i) =>
                              new Mediana_E { index = i, xi = Convert.ToDecimal(x) }).ToList();
                txtMediana.Text = dt.ltmediana.Where(i => i.index == dt.nummediana).Select(x => x.xi).FirstOrDefault().ToString();
            }

            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
