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
    public partial class GraficoPie : Form
    {
        private readonly List<FrecuenciaRelativa_E> DataFinal;
        public GraficoPie(List<FrecuenciaRelativa_E> Data)
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
            areagrafica.Area3DStyle.Enable3D = true;
            areagrafica.Area3DStyle.Inclination = 25;
            Grafico.ChartAreas.Add(areagrafica);

            Title titulo = new Title("Grafica de Pie");
            titulo.Font = new Font("Arial", 15, FontStyle.Bold);
            Grafico.Titles.Add(titulo);
            


            string nombreserie = "GraficoPie";
            Grafico.Series.Add(nombreserie);
            Grafico.Series[nombreserie].ChartType = SeriesChartType.Pie;
            Grafico.Series[nombreserie].XValueMember = "Meses";
            Grafico.Series[nombreserie].YValueMembers = "Meses";
            Grafico.Series[nombreserie].IsValueShownAsLabel = true;
            Grafico.Series[nombreserie].LabelFormat = "#.##%";

            foreach (DataRow dr in dt.Rows)
            {
                Grafico.Series[nombreserie].Points.AddXY(dr.ItemArray[4],dr.ItemArray[2]);
            }            

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
