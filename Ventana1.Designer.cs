namespace Lab5DS4
{
    partial class wdReservasEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTipoEntrada = new System.Windows.Forms.ComboBox();
            this.numEntrada = new System.Windows.Forms.NumericUpDown();
            this.ckbEntradas = new System.Windows.Forms.CheckBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblSPAC = new System.Windows.Forms.Label();
            this.lblITBMS = new System.Windows.Forms.Label();
            this.lblEstacionamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoEntrada
            // 
            this.cbTipoEntrada.FormattingEnabled = true;
            this.cbTipoEntrada.Items.AddRange(new object[] {
            "VIP",
            "Ejecutivo",
            "General"});
            this.cbTipoEntrada.Location = new System.Drawing.Point(36, 129);
            this.cbTipoEntrada.Name = "cbTipoEntrada";
            this.cbTipoEntrada.Size = new System.Drawing.Size(121, 24);
            this.cbTipoEntrada.TabIndex = 0;
            // 
            // numEntrada
            // 
            this.numEntrada.Location = new System.Drawing.Point(391, 133);
            this.numEntrada.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEntrada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEntrada.Name = "numEntrada";
            this.numEntrada.Size = new System.Drawing.Size(120, 22);
            this.numEntrada.TabIndex = 1;
            this.numEntrada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckbEntradas
            // 
            this.ckbEntradas.AutoSize = true;
            this.ckbEntradas.Location = new System.Drawing.Point(182, 133);
            this.ckbEntradas.Name = "ckbEntradas";
            this.ckbEntradas.Size = new System.Drawing.Size(187, 20);
            this.ckbEntradas.TabIndex = 2;
            this.ckbEntradas.Text = "Deseas Estacionamiento?";
            this.ckbEntradas.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(561, 133);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular Total";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(193, 247);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(83, 16);
            this.lblPrecioTotal.TabIndex = 4;
            this.lblPrecioTotal.Text = "Precio Total:";
            // 
            // lblSPAC
            // 
            this.lblSPAC.AutoSize = true;
            this.lblSPAC.Location = new System.Drawing.Point(193, 329);
            this.lblSPAC.Name = "lblSPAC";
            this.lblSPAC.Size = new System.Drawing.Size(134, 16);
            this.lblSPAC.TabIndex = 5;
            this.lblSPAC.Text = "Impuesto SPAC (5%):";
            // 
            // lblITBMS
            // 
            this.lblITBMS.AutoSize = true;
            this.lblITBMS.Location = new System.Drawing.Point(193, 294);
            this.lblITBMS.Name = "lblITBMS";
            this.lblITBMS.Size = new System.Drawing.Size(81, 16);
            this.lblITBMS.TabIndex = 7;
            this.lblITBMS.Text = "ITBMS (7%):";
            // 
            // lblEstacionamiento
            // 
            this.lblEstacionamiento.AutoSize = true;
            this.lblEstacionamiento.Location = new System.Drawing.Point(193, 368);
            this.lblEstacionamiento.Name = "lblEstacionamiento";
            this.lblEstacionamiento.Size = new System.Drawing.Size(107, 16);
            this.lblEstacionamiento.TabIndex = 8;
            this.lblEstacionamiento.Text = "Estacionamiento";
            // 
            // wdReservasEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstacionamiento);
            this.Controls.Add(this.lblITBMS);
            this.Controls.Add(this.lblSPAC);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ckbEntradas);
            this.Controls.Add(this.numEntrada);
            this.Controls.Add(this.cbTipoEntrada);
            this.Name = "wdReservasEntrada";
            this.Text = "ReservasEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.numEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoEntrada;
        private System.Windows.Forms.NumericUpDown numEntrada;
        private System.Windows.Forms.CheckBox ckbEntradas;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblSPAC;
        private System.Windows.Forms.Label lblITBMS;
        private System.Windows.Forms.Label lblEstacionamiento;
    }
}

