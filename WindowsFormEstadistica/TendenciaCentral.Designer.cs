namespace WindowsFormsGraficos
{
    partial class TendenciaCentral
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
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtModa = new System.Windows.Forms.TextBox();
            this.txtMediana = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMediana = new System.Windows.Forms.Label();
            this.lblModa = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Actualizar.AutoSize = true;
            this.btn_Actualizar.Location = new System.Drawing.Point(69, 265);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(89, 23);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cerrar.AutoSize = true;
            this.btn_Cerrar.Location = new System.Drawing.Point(176, 265);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(93, 23);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModa);
            this.groupBox1.Controls.Add(this.txtMediana);
            this.groupBox1.Controls.Add(this.txtMedia);
            this.groupBox1.Controls.Add(this.lblMediana);
            this.groupBox1.Controls.Add(this.lblModa);
            this.groupBox1.Controls.Add(this.lblMedia);
            this.groupBox1.Location = new System.Drawing.Point(55, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 221);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tendencia de Medida Central";
            // 
            // txtModa
            // 
            this.txtModa.Location = new System.Drawing.Point(121, 157);
            this.txtModa.Name = "txtModa";
            this.txtModa.Size = new System.Drawing.Size(78, 20);
            this.txtModa.TabIndex = 5;
            // 
            // txtMediana
            // 
            this.txtMediana.Location = new System.Drawing.Point(121, 99);
            this.txtMediana.Name = "txtMediana";
            this.txtMediana.Size = new System.Drawing.Size(78, 20);
            this.txtMediana.TabIndex = 4;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(121, 49);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(78, 20);
            this.txtMedia.TabIndex = 3;
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(42, 99);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(51, 13);
            this.lblMediana.TabIndex = 2;
            this.lblMediana.Text = "Mediana:";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(42, 160);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(37, 13);
            this.lblModa.TabIndex = 1;
            this.lblModa.Text = "Moda:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(42, 49);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(39, 13);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Media:";
            // 
            // TendenciaCentral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 327);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Actualizar);
            this.Name = "TendenciaCentral";
            this.Text = "Tendecia de Medida Central";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModa;
        private System.Windows.Forms.TextBox txtMediana;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.Label lblMedia;
    }
}

