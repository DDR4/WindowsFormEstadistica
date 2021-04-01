using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEstadistica
{
    public partial class FrecuenciaRelativa : Form
    {
        public FrecuenciaRelativa()
        {
            InitializeComponent();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    char serapador = '\\';
                    string ruta = openFileDialog.FileName;

                    string[] strarray = ruta.Split(serapador);
                    int maxstrarray = strarray.Length;
                    txtRuta.Text = strarray[maxstrarray - 1];

                    dtgvFrecuenciaRelativa.Rows.Clear();
                    string[] data = File.ReadAllLines(ruta);

                    List<decimal> datadecimal = new List<decimal>();

                    foreach (string item in data)
                    {
                        datadecimal.Add(decimal.Parse(item));
                    }

                    List<FrecuenciaRelativa_E> xi_fi = new List<FrecuenciaRelativa_E>();

                    if (rbnSinIntervalo.Checked)
                    {
                        xi_fi = datadecimal.GroupBy(x => x)
                                .Select(y => new FrecuenciaRelativa_E { xi = y.Key, fi = y.Count() })
                                .OrderBy(z => z.xi).AsEnumerable().ToList();
                    }

                    if (rbnConIntervalo.Checked)
                    {
                        int numintervalo = Convert.ToInt32(txtInvertavalos.Text);
                        decimal intervalo = Convert.ToDecimal(txtIntervaloSuperior.Text) - Convert.ToDecimal(txtIntervaloInferior.Text);


                        decimal intinf = Convert.ToDecimal(txtIntervaloInferior.Text);
                        decimal intsup = Convert.ToDecimal(txtIntervaloSuperior.Text);
                        int fi = 0;
                        for (int i = 0; i < numintervalo; i++)
                        {
                            List<FrecuenciaRelativa_E> aux_xi_fi = new List<FrecuenciaRelativa_E>();
                            aux_xi_fi = datadecimal.GroupBy(x => x)
                                    .Select(y => new FrecuenciaRelativa_E { xi = y.Key, fi = y.Count() })
                                    .Where(z => z.xi >= intinf && z.xi <= intsup).ToList();

                            fi = aux_xi_fi.Select(x => x).Count();
                            
                            FrecuenciaRelativa_E xi = new FrecuenciaRelativa_E
                            {
                                strxi = string.Concat(intinf, " - ", intsup),
                                fi = fi
                            };
                            intinf = intsup;
                            intsup += intervalo;
                                
                            xi_fi.Add(xi);
                        }                      
                    }

                    int xicount = xi_fi.Select(x => x.fi).Sum();

                    var hi = xi_fi.Select(x => new { x.strxi, x.xi, x.fi, hi = Math.Round((decimal)x.fi/xicount,3) }).ToList();

                    List<FrecuenciaRelativa_E> DataFinal = new List<FrecuenciaRelativa_E>();

                    int Fi = 0; decimal Hi = 0;
                    for (int i = 0; i < hi.Count; i++)
                    {
                        FrecuenciaRelativa_E obj = new FrecuenciaRelativa_E();
                        dtgvFrecuenciaRelativa.Rows.Add();
                        int y = 0;                       
                        if (rbnSinIntervalo.Checked)
                        {
                            dtgvFrecuenciaRelativa[y++, i].Value = hi[i].xi;
                            obj.xi = Convert.ToInt32(hi[i].xi);
                        }

                        if (rbnConIntervalo.Checked)
                        {
                            dtgvFrecuenciaRelativa[y++, i].Value = hi[i].strxi;
                            obj.strxi = hi[i].strxi;
                        }

                        Fi += hi[i].fi;
                        Hi += hi[i].hi;              
                        dtgvFrecuenciaRelativa[y++, i].Value = hi[i].fi;
                        obj.fi = hi[i].fi;
                        dtgvFrecuenciaRelativa[y++, i].Value = Fi;
                        obj.Fi = Fi;
                        dtgvFrecuenciaRelativa[y++, i].Value = hi[i].hi;
                        obj.hi = hi[i].hi;
                        dtgvFrecuenciaRelativa[y++, i].Value = Hi;
                        obj.Hi = Hi;

                        DataFinal.Add(obj);
                    }


                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        private void rbnSinIntervalo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnSinIntervalo.Checked)
            {
                txtInvertavalos.Clear();
                txtInvertavalos.Enabled = false;
                txtIntervaloSuperior.Clear();
                txtIntervaloSuperior.Enabled = false;
                txtIntervaloInferior.Clear();
                txtIntervaloInferior.Enabled = false;
            }
        }

        private void rbnConIntervalo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnConIntervalo.Checked)
            {
                txtInvertavalos.Clear();
                txtInvertavalos.Enabled = true;
                txtIntervaloSuperior.Clear();
                txtIntervaloSuperior.Enabled = true;
                txtIntervaloInferior.Clear();
                txtIntervaloInferior.Enabled = true;
            }
        }

        private void FrecuenciaRelativa_Load(object sender, EventArgs e)
        {
            txtInvertavalos.Enabled = false;
            txtIntervaloSuperior.Enabled = false;
            txtIntervaloInferior.Enabled = false;
            rbnSinIntervalo.Checked = true;
        }

        private void txtIntervaloSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloDecimales(e);
            int numero = ValidarDatos.NumeroCaracteres(txtIntervaloSuperior, 2, e);
            ValidarDatos.MaximoCaracteres(txtIntervaloSuperior, numero, 2, e);
        }

        private void txtIntervaloInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloDecimales(e);
            int numero = ValidarDatos.NumeroCaracteres(txtIntervaloInferior,2,e);
            ValidarDatos.MaximoCaracteres(txtIntervaloInferior, numero, 2, e);
        }

        private void txtInvertavalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }
    }
}
