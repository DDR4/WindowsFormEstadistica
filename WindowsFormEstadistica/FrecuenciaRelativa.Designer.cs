namespace WindowsFormEstadistica
{
    partial class FrecuenciaRelativa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dtgvFrecuenciaRelativa = new System.Windows.Forms.DataGridView();
            this.xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmpxi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbnSinIntervalo = new System.Windows.Forms.RadioButton();
            this.rbnConIntervalo = new System.Windows.Forms.RadioButton();
            this.txtIntervaloSuperior = new System.Windows.Forms.TextBox();
            this.txtIntervaloInferior = new System.Windows.Forms.TextBox();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.lblInferior = new System.Windows.Forms.Label();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.txtInvertavalos = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbnNumerico = new System.Windows.Forms.RadioButton();
            this.rbnTexto = new System.Windows.Forms.RadioButton();
            this.gbIntervalo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGraficaBarra = new System.Windows.Forms.Button();
            this.btnGraficaPie = new System.Windows.Forms.Button();
            this.btnTendeciaCentral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrecuenciaRelativa)).BeginInit();
            this.gbIntervalo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(56, 46);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(44, 20);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta";
            // 
            // txtRuta
            // 
            this.txtRuta.AcceptsReturn = true;
            this.txtRuta.Location = new System.Drawing.Point(110, 46);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(152, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.Location = new System.Drawing.Point(295, 41);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(116, 25);
            this.btnArchivo.TabIndex = 2;
            this.btnArchivo.Text = "Seleccionar Archivo";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dtgvFrecuenciaRelativa
            // 
            this.dtgvFrecuenciaRelativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFrecuenciaRelativa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xi,
            this.tmpxi,
            this.fi,
            this.F,
            this.ni,
            this.N});
            this.dtgvFrecuenciaRelativa.Location = new System.Drawing.Point(76, 217);
            this.dtgvFrecuenciaRelativa.Name = "dtgvFrecuenciaRelativa";
            this.dtgvFrecuenciaRelativa.Size = new System.Drawing.Size(535, 318);
            this.dtgvFrecuenciaRelativa.TabIndex = 3;
            // 
            // xi
            // 
            this.xi.HeaderText = "xi";
            this.xi.Name = "xi";
            // 
            // tmpxi
            // 
            this.tmpxi.HeaderText = "tmpxi";
            this.tmpxi.Name = "tmpxi";
            this.tmpxi.Visible = false;
            // 
            // fi
            // 
            this.fi.HeaderText = "fi";
            this.fi.Name = "fi";
            // 
            // F
            // 
            this.F.HeaderText = "F";
            this.F.Name = "F";
            // 
            // ni
            // 
            this.ni.HeaderText = "ni";
            this.ni.Name = "ni";
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.Name = "N";
            // 
            // rbnSinIntervalo
            // 
            this.rbnSinIntervalo.AutoSize = true;
            this.rbnSinIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSinIntervalo.Location = new System.Drawing.Point(12, 23);
            this.rbnSinIntervalo.Name = "rbnSinIntervalo";
            this.rbnSinIntervalo.Size = new System.Drawing.Size(115, 24);
            this.rbnSinIntervalo.TabIndex = 5;
            this.rbnSinIntervalo.TabStop = true;
            this.rbnSinIntervalo.Text = "Sin Intervalo";
            this.rbnSinIntervalo.UseVisualStyleBackColor = true;
            this.rbnSinIntervalo.CheckedChanged += new System.EventHandler(this.rbnSinIntervalo_CheckedChanged);
            // 
            // rbnConIntervalo
            // 
            this.rbnConIntervalo.AutoSize = true;
            this.rbnConIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnConIntervalo.Location = new System.Drawing.Point(164, 23);
            this.rbnConIntervalo.Name = "rbnConIntervalo";
            this.rbnConIntervalo.Size = new System.Drawing.Size(88, 24);
            this.rbnConIntervalo.TabIndex = 6;
            this.rbnConIntervalo.TabStop = true;
            this.rbnConIntervalo.Text = "Intervalo";
            this.rbnConIntervalo.UseVisualStyleBackColor = true;
            this.rbnConIntervalo.CheckedChanged += new System.EventHandler(this.rbnConIntervalo_CheckedChanged);
            // 
            // txtIntervaloSuperior
            // 
            this.txtIntervaloSuperior.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIntervaloSuperior.Location = new System.Drawing.Point(217, 85);
            this.txtIntervaloSuperior.Name = "txtIntervaloSuperior";
            this.txtIntervaloSuperior.Size = new System.Drawing.Size(84, 24);
            this.txtIntervaloSuperior.TabIndex = 7;
            this.txtIntervaloSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntervaloSuperior_KeyPress);
            // 
            // txtIntervaloInferior
            // 
            this.txtIntervaloInferior.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIntervaloInferior.Location = new System.Drawing.Point(111, 85);
            this.txtIntervaloInferior.Name = "txtIntervaloInferior";
            this.txtIntervaloInferior.Size = new System.Drawing.Size(80, 24);
            this.txtIntervaloInferior.TabIndex = 8;
            this.txtIntervaloInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntervaloInferior_KeyPress);
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(213, 62);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(96, 20);
            this.lblSuperior.TabIndex = 9;
            this.lblSuperior.Text = "Int. Superior";
            // 
            // lblInferior
            // 
            this.lblInferior.AutoSize = true;
            this.lblInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInferior.Location = new System.Drawing.Point(105, 62);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(86, 20);
            this.lblInferior.TabIndex = 10;
            this.lblInferior.Text = "Int. Inferior";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalos.Location = new System.Drawing.Point(8, 62);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(78, 20);
            this.lblIntervalos.TabIndex = 12;
            this.lblIntervalos.Text = "Intervalos";
            // 
            // txtInvertavalos
            // 
            this.txtInvertavalos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInvertavalos.Location = new System.Drawing.Point(12, 85);
            this.txtInvertavalos.Name = "txtInvertavalos";
            this.txtInvertavalos.Size = new System.Drawing.Size(74, 24);
            this.txtInvertavalos.TabIndex = 11;
            this.txtInvertavalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvertavalos_KeyPress);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Location = new System.Drawing.Point(426, 42);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(88, 25);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(529, 42);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 25);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rbnNumerico
            // 
            this.rbnNumerico.AutoSize = true;
            this.rbnNumerico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnNumerico.Location = new System.Drawing.Point(90, 19);
            this.rbnNumerico.Name = "rbnNumerico";
            this.rbnNumerico.Size = new System.Drawing.Size(94, 24);
            this.rbnNumerico.TabIndex = 17;
            this.rbnNumerico.TabStop = true;
            this.rbnNumerico.Text = "Numerico";
            this.rbnNumerico.UseVisualStyleBackColor = true;
            this.rbnNumerico.CheckedChanged += new System.EventHandler(this.rbnNumerico_CheckedChanged);
            // 
            // rbnTexto
            // 
            this.rbnTexto.AutoSize = true;
            this.rbnTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTexto.Location = new System.Drawing.Point(14, 17);
            this.rbnTexto.Name = "rbnTexto";
            this.rbnTexto.Size = new System.Drawing.Size(66, 24);
            this.rbnTexto.TabIndex = 16;
            this.rbnTexto.TabStop = true;
            this.rbnTexto.Text = "Texto";
            this.rbnTexto.UseVisualStyleBackColor = true;
            this.rbnTexto.CheckedChanged += new System.EventHandler(this.rbnTexto_CheckedChanged);
            // 
            // gbIntervalo
            // 
            this.gbIntervalo.Controls.Add(this.rbnSinIntervalo);
            this.gbIntervalo.Controls.Add(this.rbnConIntervalo);
            this.gbIntervalo.Controls.Add(this.lblInferior);
            this.gbIntervalo.Controls.Add(this.txtIntervaloSuperior);
            this.gbIntervalo.Controls.Add(this.lblIntervalos);
            this.gbIntervalo.Controls.Add(this.txtIntervaloInferior);
            this.gbIntervalo.Controls.Add(this.txtInvertavalos);
            this.gbIntervalo.Controls.Add(this.lblSuperior);
            this.gbIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIntervalo.Location = new System.Drawing.Point(295, 74);
            this.gbIntervalo.Name = "gbIntervalo";
            this.gbIntervalo.Size = new System.Drawing.Size(316, 115);
            this.gbIntervalo.TabIndex = 18;
            this.gbIntervalo.TabStop = false;
            this.gbIntervalo.Text = "Intervalo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnNumerico);
            this.groupBox1.Controls.Add(this.rbnTexto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 47);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Dato";
            // 
            // btnGraficaBarra
            // 
            this.btnGraficaBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficaBarra.Location = new System.Drawing.Point(293, 565);
            this.btnGraficaBarra.Name = "btnGraficaBarra";
            this.btnGraficaBarra.Size = new System.Drawing.Size(129, 26);
            this.btnGraficaBarra.TabIndex = 20;
            this.btnGraficaBarra.Text = "Grafica Barra";
            this.btnGraficaBarra.UseVisualStyleBackColor = true;
            this.btnGraficaBarra.Click += new System.EventHandler(this.btnGraficaBarra_Click);
            // 
            // btnGraficaPie
            // 
            this.btnGraficaPie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraficaPie.Location = new System.Drawing.Point(477, 565);
            this.btnGraficaPie.Name = "btnGraficaPie";
            this.btnGraficaPie.Size = new System.Drawing.Size(134, 26);
            this.btnGraficaPie.TabIndex = 21;
            this.btnGraficaPie.Text = "Grafica Pie";
            this.btnGraficaPie.UseVisualStyleBackColor = true;
            this.btnGraficaPie.Click += new System.EventHandler(this.btnGraficaPie_Click);
            // 
            // btnTendeciaCentral
            // 
            this.btnTendeciaCentral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTendeciaCentral.Location = new System.Drawing.Point(76, 565);
            this.btnTendeciaCentral.Name = "btnTendeciaCentral";
            this.btnTendeciaCentral.Size = new System.Drawing.Size(150, 26);
            this.btnTendeciaCentral.TabIndex = 22;
            this.btnTendeciaCentral.Text = "Tendencia Central";
            this.btnTendeciaCentral.UseVisualStyleBackColor = true;
            this.btnTendeciaCentral.Click += new System.EventHandler(this.btnTendeciaCentral_Click);
            // 
            // FrecuenciaRelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 658);
            this.Controls.Add(this.btnTendeciaCentral);
            this.Controls.Add(this.btnGraficaPie);
            this.Controls.Add(this.btnGraficaBarra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbIntervalo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dtgvFrecuenciaRelativa);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Name = "FrecuenciaRelativa";
            this.Text = "TablaFrecuencia";
            this.Load += new System.EventHandler(this.FrecuenciaRelativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrecuenciaRelativa)).EndInit();
            this.gbIntervalo.ResumeLayout(false);
            this.gbIntervalo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dtgvFrecuenciaRelativa;
        private System.Windows.Forms.RadioButton rbnSinIntervalo;
        private System.Windows.Forms.RadioButton rbnConIntervalo;
        private System.Windows.Forms.TextBox txtIntervaloSuperior;
        private System.Windows.Forms.TextBox txtIntervaloInferior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Label lblInferior;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.TextBox txtInvertavalos;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rbnNumerico;
        private System.Windows.Forms.RadioButton rbnTexto;
        private System.Windows.Forms.GroupBox gbIntervalo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGraficaBarra;
        private System.Windows.Forms.Button btnGraficaPie;
        private System.Windows.Forms.Button btnTendeciaCentral;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmpxi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn ni;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
    }
}

