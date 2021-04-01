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
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.rbnSinIntervalo = new System.Windows.Forms.RadioButton();
            this.rbnConIntervalo = new System.Windows.Forms.RadioButton();
            this.txtIntervaloSuperior = new System.Windows.Forms.TextBox();
            this.txtIntervaloInferior = new System.Windows.Forms.TextBox();
            this.lblSuperior = new System.Windows.Forms.Label();
            this.lblInferior = new System.Windows.Forms.Label();
            this.lblIntervalos = new System.Windows.Forms.Label();
            this.txtInvertavalos = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrecuenciaRelativa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(79, 46);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(36, 16);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta";
            // 
            // txtRuta
            // 
            this.txtRuta.AcceptsReturn = true;
            this.txtRuta.Location = new System.Drawing.Point(141, 47);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(179, 20);
            this.txtRuta.TabIndex = 1;
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(342, 47);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(116, 23);
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
            this.fi,
            this.F,
            this.hi,
            this.H,
            this.Column1,
            this.Column2});
            this.dtgvFrecuenciaRelativa.Location = new System.Drawing.Point(66, 133);
            this.dtgvFrecuenciaRelativa.Name = "dtgvFrecuenciaRelativa";
            this.dtgvFrecuenciaRelativa.Size = new System.Drawing.Size(536, 286);
            this.dtgvFrecuenciaRelativa.TabIndex = 3;
            // 
            // xi
            // 
            this.xi.HeaderText = "xi";
            this.xi.Name = "xi";
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
            // hi
            // 
            this.hi.HeaderText = "hi";
            this.hi.Name = "hi";
            // 
            // H
            // 
            this.H.HeaderText = "H";
            this.H.Name = "H";
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalo.Location = new System.Drawing.Point(79, 99);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(59, 16);
            this.lblIntervalo.TabIndex = 4;
            this.lblIntervalo.Text = "Intervalo";
            // 
            // rbnSinIntervalo
            // 
            this.rbnSinIntervalo.AutoSize = true;
            this.rbnSinIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSinIntervalo.Location = new System.Drawing.Point(144, 99);
            this.rbnSinIntervalo.Name = "rbnSinIntervalo";
            this.rbnSinIntervalo.Size = new System.Drawing.Size(92, 19);
            this.rbnSinIntervalo.TabIndex = 5;
            this.rbnSinIntervalo.TabStop = true;
            this.rbnSinIntervalo.Text = "Sin Intervalo";
            this.rbnSinIntervalo.UseVisualStyleBackColor = true;
            this.rbnSinIntervalo.CheckedChanged += new System.EventHandler(this.rbnSinIntervalo_CheckedChanged);
            // 
            // rbnConIntervalo
            // 
            this.rbnConIntervalo.AutoSize = true;
            this.rbnConIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnConIntervalo.Location = new System.Drawing.Point(249, 99);
            this.rbnConIntervalo.Name = "rbnConIntervalo";
            this.rbnConIntervalo.Size = new System.Drawing.Size(71, 19);
            this.rbnConIntervalo.TabIndex = 6;
            this.rbnConIntervalo.TabStop = true;
            this.rbnConIntervalo.Text = "Intervalo";
            this.rbnConIntervalo.UseVisualStyleBackColor = true;
            this.rbnConIntervalo.CheckedChanged += new System.EventHandler(this.rbnConIntervalo_CheckedChanged);
            // 
            // txtIntervaloSuperior
            // 
            this.txtIntervaloSuperior.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIntervaloSuperior.Location = new System.Drawing.Point(486, 104);
            this.txtIntervaloSuperior.Name = "txtIntervaloSuperior";
            this.txtIntervaloSuperior.Size = new System.Drawing.Size(75, 20);
            this.txtIntervaloSuperior.TabIndex = 7;
            this.txtIntervaloSuperior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntervaloSuperior_KeyPress);
            // 
            // txtIntervaloInferior
            // 
            this.txtIntervaloInferior.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIntervaloInferior.Location = new System.Drawing.Point(407, 104);
            this.txtIntervaloInferior.Name = "txtIntervaloInferior";
            this.txtIntervaloInferior.Size = new System.Drawing.Size(62, 20);
            this.txtIntervaloInferior.TabIndex = 8;
            this.txtIntervaloInferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntervaloInferior_KeyPress);
            // 
            // lblSuperior
            // 
            this.lblSuperior.AutoSize = true;
            this.lblSuperior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperior.Location = new System.Drawing.Point(483, 85);
            this.lblSuperior.Name = "lblSuperior";
            this.lblSuperior.Size = new System.Drawing.Size(78, 16);
            this.lblSuperior.TabIndex = 9;
            this.lblSuperior.Text = "Int. Superior";
            // 
            // lblInferior
            // 
            this.lblInferior.AutoSize = true;
            this.lblInferior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInferior.Location = new System.Drawing.Point(404, 85);
            this.lblInferior.Name = "lblInferior";
            this.lblInferior.Size = new System.Drawing.Size(67, 16);
            this.lblInferior.TabIndex = 10;
            this.lblInferior.Text = "Int. Inferior";
            // 
            // lblIntervalos
            // 
            this.lblIntervalos.AutoSize = true;
            this.lblIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalos.Location = new System.Drawing.Point(326, 85);
            this.lblIntervalos.Name = "lblIntervalos";
            this.lblIntervalos.Size = new System.Drawing.Size(66, 16);
            this.lblIntervalos.TabIndex = 12;
            this.lblIntervalos.Text = "Intervalos";
            // 
            // txtInvertavalos
            // 
            this.txtInvertavalos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInvertavalos.Location = new System.Drawing.Point(329, 104);
            this.txtInvertavalos.Name = "txtInvertavalos";
            this.txtInvertavalos.Size = new System.Drawing.Size(62, 20);
            this.txtInvertavalos.TabIndex = 11;
            this.txtInvertavalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvertavalos_KeyPress);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // FrecuenciaRelativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.lblIntervalos);
            this.Controls.Add(this.txtInvertavalos);
            this.Controls.Add(this.lblInferior);
            this.Controls.Add(this.lblSuperior);
            this.Controls.Add(this.txtIntervaloInferior);
            this.Controls.Add(this.txtIntervaloSuperior);
            this.Controls.Add(this.rbnConIntervalo);
            this.Controls.Add(this.rbnSinIntervalo);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.dtgvFrecuenciaRelativa);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblRuta);
            this.Name = "FrecuenciaRelativa";
            this.Text = "FrecuenciaRelativa";
            this.Load += new System.EventHandler(this.FrecuenciaRelativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFrecuenciaRelativa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dtgvFrecuenciaRelativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataGridViewTextBoxColumn hi;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.RadioButton rbnSinIntervalo;
        private System.Windows.Forms.RadioButton rbnConIntervalo;
        private System.Windows.Forms.TextBox txtIntervaloSuperior;
        private System.Windows.Forms.TextBox txtIntervaloInferior;
        private System.Windows.Forms.Label lblSuperior;
        private System.Windows.Forms.Label lblInferior;
        private System.Windows.Forms.Label lblIntervalos;
        private System.Windows.Forms.TextBox txtInvertavalos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

