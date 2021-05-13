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
        public TendenciaCentral(List<TablaFrecuencia_E> Data, string[] data)
        {
            DataFinal = Data;
            arraydata = data;
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos() {
            DatosTotales_E dt = new DatosTotales_E();
            TendeciaCentral_E objtc = new TendeciaCentral_E();

            //media
            foreach (var item in DataFinal)
            {
                dt.sumatotal += item.xi * item.fi;
                dt.cantidatotal += item.fi;
            }

            objtc.media = Math.Round(dt.sumatotal / dt.cantidatotal, 2);


            //mediana
            dt.nummediana = dt.cantidatotal / 2;

            if ((dt.cantidatotal % 2) == 0)
            {
                dt.ltmediana = arraydata.OrderBy(x => x).Select((x, i) =>
                              new Mediana_E { index = i, xi = Convert.ToDecimal(x) }).ToList();
                var tmpmediana = dt.ltmediana.Where(i => i.index == dt.nummediana - 1 || i.index == dt.nummediana).ToList();

                decimal summediana = 0;
                foreach (var item in tmpmediana)
                {
                    summediana += item.xi;
                }
                objtc.mediana = summediana / 2;
            }
            else
            {
                dt.ltmediana = arraydata.OrderBy(x => x).Select((x, i) =>
                               new Mediana_E { index = i, xi = Convert.ToDecimal(x) }).ToList();
                objtc.mediana = dt.ltmediana.Where(i => i.index == dt.nummediana).Select(x => x.xi).FirstOrDefault();
            }

            //moda
            dt.maximafrecuencia = DataFinal.Select(x => x.fi).Max();
            var ltfrecuencia = DataFinal.Where(x => x.fi == dt.maximafrecuencia).Select(y => y).FirstOrDefault();
            string msj = "";


            if (string.IsNullOrEmpty(ltfrecuencia.strxi))
            {
                objtc.moda = ltfrecuencia.xi;
            }
            else 
            {
                objtc.moda = ltfrecuencia.xi;
                msj = ltfrecuencia.xi + " (" + ltfrecuencia.strxi + ")";
            }          

            txtMedia.Text = objtc.media.ToString();
            txtMediana.Text = objtc.mediana.ToString();
            txtModa.Text = msj == "" ? objtc.moda.ToString() : msj;

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
