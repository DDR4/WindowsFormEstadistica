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
using WindowsFormsGraficos;

namespace WindowsFormEstadistica
{
    public partial class FrecuenciaRelativa : Form
    {
        public FrecuenciaRelativa()
        {
            InitializeComponent();
        }

        private bool Validar_btnArchivo()
        {
            bool validar = false;
            if (rbnSinIntervalo.Checked)
            {
                validar = true;
            }

            if (rbnConIntervalo.Checked)
            {
                if (string.IsNullOrEmpty(txtInvertavalos.Text))
                {
                    MessageBox.Show("Ingresar un numero de intervalos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtIntervaloSuperior.Text))
                {
                    MessageBox.Show("Ingresar un intervalo superior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txtIntervaloInferior.Text))
                {
                    MessageBox.Show("Ingresar un intervalo inferior", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    validar = true;
                }
            }
            return validar;
        }


        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if (Validar_btnArchivo())
            {             
                try
                {
                    string[] data = CargaDocumento();

                    if (data != null)
                    {
                        int validartd = ValidarTipoDato(data);
                        if (validartd == 0)
                        {
                            CargaDatos(data);
                        }
                        else if (validartd == 1)
                        {
                            MessageBox.Show("Se encontraron datos numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (validartd == 2)
                        {
                            MessageBox.Show("Se encontraron datos no numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

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
            rbnNumerico.Checked = true;
        }

        private void txtIntervaloSuperior_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloDecimales(txtIntervaloSuperior, e);
            int numero = ValidarDatos.NumeroCaracteresDecimales(txtIntervaloSuperior, 2, e);
            ValidarDatos.MaximoCaracteresDecimales(txtIntervaloSuperior, numero, 2, e);
        }

        private void txtIntervaloInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloDecimales(txtIntervaloInferior, e);
            int numero = ValidarDatos.NumeroCaracteresDecimales(txtIntervaloInferior, 2, e);
            ValidarDatos.MaximoCaracteresDecimales(txtIntervaloInferior, numero, 2, e);
        }

        private void txtInvertavalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
            ValidarDatos.MaximoCaracteresEnteros(txtInvertavalos, 2, e);
        }

        public string[] CargaDocumento()
        {
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            string[] data = null;

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
                    data = File.ReadAllLines(ruta);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return data;
        }

        public void CargaDatos(string[] data)
        {
            List<decimal> datadecimal = new List<decimal>();
            List<string> datatexto = new List<string>();
            
            foreach (string item in data)
            {
                if (rbnTexto.Checked)
                {
                    datatexto.Add(item);
                }

                if (rbnNumerico.Checked)
                {
                    datadecimal.Add(decimal.Parse(item.Replace('.', ',')));
                }
            }

            List<FrecuenciaRelativa_E> xi_fi = new List<FrecuenciaRelativa_E>();

            if (rbnSinIntervalo.Checked)
            {             

                if (rbnTexto.Checked)
                {
                    xi_fi = datatexto.GroupBy(x => x)
                        .Select(y => new FrecuenciaRelativa_E { strxi = y.Key, fi = y.Count() })
                        .OrderBy(z => z.strxi).AsEnumerable().ToList();
                }

                if (rbnNumerico.Checked)
                {
                    xi_fi = datadecimal.GroupBy(x => x)
                         .Select(y => new FrecuenciaRelativa_E { xi = y.Key, fi = y.Count() })
                         .OrderBy(z => z.xi).AsEnumerable().ToList();
                }
            }

            if (rbnConIntervalo.Checked)
            {
                int numintervalo = Convert.ToInt32(txtInvertavalos.Text);
                decimal intervalo = Convert.ToDecimal(txtIntervaloSuperior.Text.Replace('.', ',')) - Convert.ToDecimal(txtIntervaloInferior.Text.Replace('.', ','));


                decimal intinf = Convert.ToDecimal(txtIntervaloInferior.Text.Replace('.', ','));
                decimal intsup = Convert.ToDecimal(txtIntervaloSuperior.Text.Replace('.', ','));
                int fi = 0;
                for (int i = 0; i < numintervalo; i++)
                {
                    List<FrecuenciaRelativa_E> aux_xi_fi = new List<FrecuenciaRelativa_E>();
                    aux_xi_fi = datadecimal.GroupBy(x => x)
                            .Select(y => new FrecuenciaRelativa_E { xi = y.Key, fi = y.Count() })
                            .Where(z => z.xi >= intinf && z.xi <= intsup).ToList();

                    fi = aux_xi_fi.Select(x => x.fi).Sum();

                    FrecuenciaRelativa_E xi = new FrecuenciaRelativa_E
                    {
                        strxi = string.Concat(intinf, " - ", intsup),
                        fi = fi
                    };
                    var auxintervalo = intervalo < 1 ? intervalo : 1;
                    intinf = intsup + auxintervalo;
                    intsup += intervalo + auxintervalo;

                    xi_fi.Add(xi);
                }
            }

            int xicount = xi_fi.Select(x => x.fi).Sum();

            var hi = xi_fi.Select(x => new { x.strxi, x.xi, x.fi, hi = Math.Round((decimal)x.fi / xicount, 3) }).ToList();   

            int Fi = 0; decimal Hi = 0;
            for (int i = 0; i < hi.Count; i++)
            {
 
                dtgvFrecuenciaRelativa.Rows.Add();
                int y = 0;
                if (rbnSinIntervalo.Checked)
                {
                    if (rbnTexto.Checked)
                    {
                        dtgvFrecuenciaRelativa[y++, i].Value = hi[i].strxi;
                    }

                    if (rbnNumerico.Checked)
                    {
                        dtgvFrecuenciaRelativa[y++, i].Value = hi[i].xi;
                    }
          
                }

                if (rbnConIntervalo.Checked)
                {
                    dtgvFrecuenciaRelativa[y++, i].Value = hi[i].strxi;
                }

                Fi += hi[i].fi;
                Hi += hi[i].hi;
                dtgvFrecuenciaRelativa[y++, i].Value = hi[i].fi;
                dtgvFrecuenciaRelativa[y++, i].Value = Fi;
                dtgvFrecuenciaRelativa[y++, i].Value = hi[i].hi;
                dtgvFrecuenciaRelativa[y++, i].Value = Hi;

            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            string[] data = null;
            string ruta = openFileDialog.FileName;
            dtgvFrecuenciaRelativa.Rows.Clear();
            data = File.ReadAllLines(ruta);

            if (data != null)
            {
                int validartd = ValidarTipoDato(data);
                if (validartd == 0)
                {
                    CargaDatos(data);
                }
                else if (validartd == 1)
                {
                    MessageBox.Show("Se encontraron datos numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (validartd == 2)
                {
                    MessageBox.Show("Se encontraron datos no numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInvertavalos.Clear();
            txtIntervaloSuperior.Clear();
            txtIntervaloInferior.Clear();
        }

        private void btnGraficaBarra_Click(object sender, EventArgs e)
        {
            List<FrecuenciaRelativa_E> DataFinal = new List<FrecuenciaRelativa_E>();
            DataFinal = RecuperarDatos();

            Form frombarra = new GraficoBarra(DataFinal);
            frombarra.Show();
        }

        private void btnGraficaPie_Click(object sender, EventArgs e)
        {
            List<FrecuenciaRelativa_E> DataFinal = new List<FrecuenciaRelativa_E>();
            DataFinal = RecuperarDatos();

            Form frompie = new GraficoPie(DataFinal);
            frompie.Show();
        }

        public List<FrecuenciaRelativa_E> RecuperarDatos()
        {
            List<FrecuenciaRelativa_E> DataFinal = new List<FrecuenciaRelativa_E>();

            foreach (DataGridViewRow dr in dtgvFrecuenciaRelativa.Rows)
            {
                FrecuenciaRelativa_E obj = new FrecuenciaRelativa_E();


                if (dr.Cells["xi"].Value != null)
                {

                    if (rbnSinIntervalo.Checked)
                    {
                        if (rbnTexto.Checked)
                        {
                            obj.strxi = Convert.ToString(dr.Cells["xi"].Value);
                        }

                        if (rbnNumerico.Checked)
                        {
                            obj.xi = Convert.ToDecimal(dr.Cells["xi"].Value);
                        }
                    }

                    if (rbnConIntervalo.Checked)
                    {
                        obj.strxi = Convert.ToString(dr.Cells["xi"].Value);
                    }

                    obj.fi = Convert.ToInt32(dr.Cells["fi"].Value);
                    obj.Fi = Convert.ToInt32(dr.Cells["F"].Value);
                    obj.ni = Convert.ToDecimal(dr.Cells["ni"].Value);
                    obj.Ni = Convert.ToDecimal(dr.Cells["N"].Value);
                    DataFinal.Add(obj);
                }
            }

            return DataFinal;
        }

        private void rbnTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnTexto.Checked)
            {
                rbnConIntervalo.Enabled = false;
            }         
        }

        private void rbnNumerico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNumerico.Checked)
            {
                rbnConIntervalo.Enabled = true;
                rbnSinIntervalo.Enabled = true;
            }
        }

        public int ValidarTipoDato(string[] data) {
            int validar = 0;

            if (rbnTexto.Checked)
            {
                foreach (var item in data)
                {
                    bool isNumeric = int.TryParse(item, out int n);

                    if (isNumeric)
                    {
                        validar = 1;
                        break;
                    }
                }
            }

            if (rbnNumerico.Checked)
            {
                foreach (var item in data)
                {
                    bool isNumeric = int.TryParse(item, out int n);

                    if (!isNumeric)
                    {
                        validar = 2;
                        break;
                    }
                }
            }


            return validar;
        }
    }
}
