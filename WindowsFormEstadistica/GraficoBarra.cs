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
    public partial class GraficoBarra : Form
    {
        private readonly List<TablaFrecuencia_E> DataFinal;

        public GraficoBarra(List<TablaFrecuencia_E> Data)
        {
            DataFinal = Data;
            InitializeComponent();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (var reader = ObjectReader.Create(DataFinal))
            {
                dt.Load(reader);
            }

            Grafico.Titles.Clear();
            Grafico.Series.Clear();
            Grafico.ChartAreas.Clear();
            Grafico.Palette = ChartColorPalette.Pastel;

            ChartArea areagrafica = new ChartArea();
            Grafico.ChartAreas.Add(areagrafica);

            Title titulo = new Title("Grafica de Barra");
            titulo.Font = new Font("Arial", 10, FontStyle.Bold);
            Grafico.Titles.Add(titulo);               

            foreach (DataRow dr in dt.Rows)
            {
                string strserie = string.IsNullOrEmpty(dr.ItemArray[4].ToString()) ? dr.ItemArray[5].ToString() : dr.ItemArray[4].ToString();
                Series serie = Grafico.Series.Add(strserie);
                serie.Label = dr.ItemArray[0].ToString();
                serie.Points.Add(Convert.ToDouble(dr.ItemArray[0]));
            }                      

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
