namespace WindowsFormsGraficos
{
    partial class GraficoBarra
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafico
            // 
            this.Grafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico.Legends.Add(legend1);
            this.Grafico.Location = new System.Drawing.Point(47, 15);
            this.Grafico.Name = "Grafico";
            this.Grafico.Size = new System.Drawing.Size(714, 342);
            this.Grafico.TabIndex = 0;
            this.Grafico.Text = "chart1";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(557, 389);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 1;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(657, 389);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // GraficoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 441);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.Grafico);
            this.Name = "GraficoBarra";
            this.Text = "Grafico Barra";
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

