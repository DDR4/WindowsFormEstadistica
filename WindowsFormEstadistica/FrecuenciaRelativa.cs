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

        int numintervalo = 2;
        int lenintervalo = 4;
        int numdecimales = 2;

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
                    CargarDocumentos_E objcd = new CargarDocumentos_E();
                    TipoDato_E objtd = new TipoDato_E();
                    objcd.data = CargaDocumento();

                    if (objcd.data != null)
                    {
                        objtd.tipodato = ValidarTipoDato(objcd.data);
                        if (objtd.tipodato == 0)
                        {
                            CargaDatos(objcd.data);
                        }
                        else if (objtd.tipodato == 1)
                        {
                            MessageBox.Show("Se encontraron datos numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (objtd.tipodato == 2)
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
            int numero = ValidarDatos.NumeroCaracteresDecimales(txtIntervaloSuperior, lenintervalo, numdecimales,e);
            ValidarDatos.MaximoCaracteresDecimales(txtIntervaloSuperior, numero, numdecimales, e);
        }

        private void txtIntervaloInferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloDecimales(txtIntervaloInferior, e);
            int numero = ValidarDatos.NumeroCaracteresDecimales(txtIntervaloInferior, lenintervalo, numdecimales, e);
            ValidarDatos.MaximoCaracteresDecimales(txtIntervaloInferior, numero, numdecimales, e);
        }

        private void txtInvertavalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
            ValidarDatos.MaximoCaracteresEnteros(txtInvertavalos, numintervalo, e);
        }

        public string[] CargaDocumento()
        {
            openFileDialog.InitialDirectory = "D:\\";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";

            CargarDocumentos_E objcd = new CargarDocumentos_E();

            objcd.data = null;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    char serapador = '\\';
                    objcd.ruta = openFileDialog.FileName;
                    objcd.strarray = objcd.ruta.Split(serapador);
                    objcd.maxstrarray = objcd.strarray.Length;
                    txtRuta.Text = objcd.strarray[objcd.maxstrarray - 1];

                    dtgvFrecuenciaRelativa.Rows.Clear();
                    objcd.data = File.ReadAllLines(objcd.ruta);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return objcd.data;
        }

        public void CargaDatos(string[] data)
        {
            TipoDato_E objtd = new TipoDato_E();   
            
            foreach (string item in data)
            {
                if (rbnTexto.Checked)
                {
                    objtd.datatexto.Add(item);
                }

                if (rbnNumerico.Checked)
                {
                    objtd.datadecimal.Add(decimal.Parse(item.Replace(',', '.')));
                }
            }

            List<TablaFrecuencia_E> xi_fi = new List<TablaFrecuencia_E>();

            if (rbnSinIntervalo.Checked)
            {             

                if (rbnTexto.Checked)
                {
                    xi_fi = objtd.datatexto.GroupBy(x => x)
                        .Select(y => new TablaFrecuencia_E { strxi = y.Key, fi = y.Count() })
                        .OrderBy(z => z.strxi).AsEnumerable().ToList();
                }

                if (rbnNumerico.Checked)
                {
                    xi_fi = objtd.datadecimal.GroupBy(x => x)
                         .Select(y => new TablaFrecuencia_E { xi = y.Key, fi = y.Count() })
                         .OrderBy(z => z.xi).AsEnumerable().ToList();
                }
            }

            if (rbnConIntervalo.Checked)
            {
                Intervalo_E objint = new Intervalo_E();
                objint.numintervalo = Convert.ToInt32(txtInvertavalos.Text);
                objint.intervalo = Convert.ToDecimal(txtIntervaloSuperior.Text.Replace(',', '.')) - Convert.ToDecimal(txtIntervaloInferior.Text.Replace(',', '.'));
                objint.intinf = Convert.ToDecimal(txtIntervaloInferior.Text.Replace(',', '.'));
                objint.intsup = Convert.ToDecimal(txtIntervaloSuperior.Text.Replace(',', '.'));
                objint.fi = 0;
                for (int i = 0; i < objint.numintervalo; i++)
                {
                    List<TablaFrecuencia_E> aux_xi_fi = new List<TablaFrecuencia_E>();

                    aux_xi_fi = objtd.datadecimal.GroupBy(x => x)
                                .Select(y => new TablaFrecuencia_E { xi = y.Key, fi = y.Count() })
                                .Where(z => z.xi >= objint.intinf && z.xi <= objint.intsup).ToList();     
                    
                    objint.fi = aux_xi_fi.Select(x => x.fi).Sum();

                    decimal tmpxi = objint.intinf;
                    decimal indexxi = objint.intinf;
                    int numintervalo = 1;

                    while (indexxi < objint.intsup)
                    {
                        bool isNumeric = int.TryParse(objint.intinf.ToString(), out int n);
                        if (isNumeric)
                        {
                            indexxi++;
                            tmpxi += indexxi;
                            numintervalo++;
                        }
                        else
                        {
                            indexxi = indexxi + Convert.ToDecimal(0.01);
                            tmpxi += indexxi;
                            numintervalo++;
                        }

                    }

                    TablaFrecuencia_E xi = new TablaFrecuencia_E
                    {
                        strxi = string.Concat(objint.intinf, " - ", objint.intsup),
                        xi = tmpxi/ numintervalo,
                        fi = objint.fi
                    };

                    objint.intinf = objint.intsup + (objint.intervalo >= 1 ? 1 : Convert.ToDecimal(0.01));
                    objint.intsup += objint.intervalo + (objint.intervalo >= 1 ? 1 : Convert.ToDecimal(0.01));

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
                    y++;
                }

                if (rbnConIntervalo.Checked)
                {
                    dtgvFrecuenciaRelativa[y++, i].Value = hi[i].strxi;
                    dtgvFrecuenciaRelativa[y++, i].Value = hi[i].xi;
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
            CargarDocumentos_E objcd = new CargarDocumentos_E();
            TipoDato_E objtd = new TipoDato_E();
            objcd.data = null;
            objcd.ruta = openFileDialog.FileName;
            dtgvFrecuenciaRelativa.Rows.Clear();
            objcd.data = File.ReadAllLines(objcd.ruta);

            if (objcd.data != null)
            {
                objtd.tipodato = ValidarTipoDato(objcd.data);
                if (objtd.tipodato == 0)
                {
                    CargaDatos(objcd.data);
                }
                else if (objtd.tipodato == 1)
                {
                    MessageBox.Show("Se encontraron datos numericos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (objtd.tipodato == 2)
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
            List<TablaFrecuencia_E> DataFinal = new List<TablaFrecuencia_E>();
            DataFinal = RecuperarDatos();

            if (DataFinal.Count == 0)
            {
                MessageBox.Show("Se deben cargar datos previamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form frombarra = new GraficoBarra(DataFinal);
                frombarra.Show();
            }
        }

        private void btnGraficaPie_Click(object sender, EventArgs e)
        {
            List<TablaFrecuencia_E> DataFinal = new List<TablaFrecuencia_E>();
            DataFinal = RecuperarDatos();

            if (DataFinal.Count == 0)
            {
                MessageBox.Show("Se deben cargar datos previamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form frompie = new GraficoPie(DataFinal);
                frompie.Show();
            }
        }

        public List<TablaFrecuencia_E> RecuperarDatos()
        {
            List<TablaFrecuencia_E> DataFinal = new List<TablaFrecuencia_E>();

            foreach (DataGridViewRow dr in dtgvFrecuenciaRelativa.Rows)
            {
                TablaFrecuencia_E obj = new TablaFrecuencia_E();


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
                        obj.xi = Convert.ToDecimal(dr.Cells["tmpxi"].Value);
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
                rbnSinIntervalo.Checked = true;
                rbnConIntervalo.Enabled = false;
                btnTendeciaCentral.Enabled = false;
            }         
        }

        private void rbnNumerico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnNumerico.Checked)
            {
                rbnConIntervalo.Enabled = true;
                rbnSinIntervalo.Enabled = true;
                btnTendeciaCentral.Enabled = true;
            }
        }

        public int ValidarTipoDato(string[] data) {
            int validar = 0;

            if (rbnTexto.Checked)
            {
                foreach (var item in data)
                {
                    bool isNumeric = decimal.TryParse(item.ToString(), out decimal n);

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
                    bool isNumeric = decimal.TryParse(item.ToString(), out decimal n);

                    if (!isNumeric)
                    {
                        validar = 2;
                        break;
                    }                    
                    
                }
            }


            return validar;
        }

        private void btnTendeciaCentral_Click(object sender, EventArgs e)
        {
            List<TablaFrecuencia_E> DataFinal = new List<TablaFrecuencia_E>();
            DataFinal = RecuperarDatos();

            if (DataFinal.Count == 0)
            {
                MessageBox.Show("Se deben cargar datos previamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CargarDocumentos_E objcd = new CargarDocumentos_E();
                TipoDato_E objtd = new TipoDato_E();
                objcd.data = null;
                objcd.ruta = openFileDialog.FileName;
                objcd.data = File.ReadAllLines(objcd.ruta);

                Form frombarra = new TendenciaCentral(DataFinal, objcd.data);
                frombarra.Show();
            }
        }
    }
}
