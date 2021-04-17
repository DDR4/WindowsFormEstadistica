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
        public TendenciaCentral(List<TablaFrecuencia_E> Data)
        {
            DataFinal = Data;
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            DatosTotales_E dt = new DatosTotales_E();
            foreach (var item in DataFinal)
            {
                dt.sumatotal += item.xi * item.fi;
                dt.cantidatotal += item.fi;
            }

            int mf = DataFinal.Select(x => x.fi).Max();
            dt.maximafrecuencia = DataFinal.Where(x => x.fi == mf).Select(y => y.xi).FirstOrDefault();           

            if ((dt.cantidatotal % 2) == 0)
            {
                dt.nummediana = dt.cantidatotal / 2;
                //dt.ltmediana = DataFinal.OrderBy(x => x.xi).Select((x, i) =>
                //              new Mediana_E { index = i, xi = x.xi }).ToList();
                //txtMediana.Text = dt.ltmediana.Select(x => x.xi).Where(i => i == dt.nummediana)
                //                  .FirstOrDefault().ToString();
            }

            //int i = 0;
          

            txtMedia.Text = Convert.ToString(dt.sumatotal/dt.cantidatotal);
            txtModa.Text = Convert.ToString(dt.maximafrecuencia);




        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
