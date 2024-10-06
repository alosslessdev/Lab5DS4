using System.Windows.Forms;

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
            this.labelEstaticoEntrada = new System.Windows.Forms.Label();
            this.labelEstaticoEncabezado = new System.Windows.Forms.Label();
            this.labelEstaticoEntradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoEntrada
            // 
            this.cbTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoEntrada.FormattingEnabled = true;
            this.cbTipoEntrada.Items.AddRange(new object[] {
            "",
            "VIP",
            "Ejecutivo",
            "General"});
            this.cbTipoEntrada.Location = new System.Drawing.Point(188, 131);
            this.cbTipoEntrada.Name = "cbTipoEntrada";
            this.cbTipoEntrada.Size = new System.Drawing.Size(121, 24);
            this.cbTipoEntrada.TabIndex = 0;
            // 
            // numEntrada
            // 
            this.numEntrada.Location = new System.Drawing.Point(905, 135);
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
            this.ckbEntradas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEntradas.Location = new System.Drawing.Point(330, 133);
            this.ckbEntradas.Name = "ckbEntradas";
            this.ckbEntradas.Size = new System.Drawing.Size(227, 24);
            this.ckbEntradas.TabIndex = 2;
            this.ckbEntradas.Text = "Deseas Estacionamiento?";
            this.ckbEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbEntradas.UseVisualStyleBackColor = true;
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(1043, 133);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(106, 29);
            this.btCalcular.TabIndex = 3;
            this.btCalcular.Text = "Calcular Total";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(71, 352);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(104, 20);
            this.lblPrecioTotal.TabIndex = 4;
            this.lblPrecioTotal.Text = "Precio Total:";
            // 
            // lblSPAC
            // 
            this.lblSPAC.AutoSize = true;
            this.lblSPAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPAC.Location = new System.Drawing.Point(71, 434);
            this.lblSPAC.Name = "lblSPAC";
            this.lblSPAC.Size = new System.Drawing.Size(173, 20);
            this.lblSPAC.TabIndex = 5;
            this.lblSPAC.Text = "Impuesto SPAC (5%):";
            // 
            // lblITBMS
            // 
            this.lblITBMS.AutoSize = true;
            this.lblITBMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITBMS.Location = new System.Drawing.Point(71, 399);
            this.lblITBMS.Name = "lblITBMS";
            this.lblITBMS.Size = new System.Drawing.Size(106, 20);
            this.lblITBMS.TabIndex = 7;
            this.lblITBMS.Text = "ITBMS (7%):";
            // 
            // lblEstacionamiento
            // 
            this.lblEstacionamiento.AutoSize = true;
            this.lblEstacionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacionamiento.Location = new System.Drawing.Point(71, 473);
            this.lblEstacionamiento.Name = "lblEstacionamiento";
            this.lblEstacionamiento.Size = new System.Drawing.Size(133, 20);
            this.lblEstacionamiento.TabIndex = 8;
            this.lblEstacionamiento.Text = "Estacionamiento";
            // 
            // labelEstaticoEntrada
            // 
            this.labelEstaticoEntrada.AutoSize = true;
            this.labelEstaticoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoEntrada.Location = new System.Drawing.Point(26, 133);
            this.labelEstaticoEntrada.Name = "labelEstaticoEntrada";
            this.labelEstaticoEntrada.Size = new System.Drawing.Size(130, 20);
            this.labelEstaticoEntrada.TabIndex = 9;
            this.labelEstaticoEntrada.Text = "Tipo de entrada:";
            // 
            // labelEstaticoEncabezado
            // 
            this.labelEstaticoEncabezado.AutoSize = true;
            this.labelEstaticoEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoEncabezado.Location = new System.Drawing.Point(38, 55);
            this.labelEstaticoEncabezado.Name = "labelEstaticoEncabezado";
            this.labelEstaticoEncabezado.Size = new System.Drawing.Size(249, 32);
            this.labelEstaticoEncabezado.TabIndex = 10;
            this.labelEstaticoEncabezado.Text = "Reservar Entradas";
            // 
            // labelEstaticoEntradas
            // 
            this.labelEstaticoEntradas.AutoSize = true;
            this.labelEstaticoEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaticoEntradas.Location = new System.Drawing.Point(716, 135);
            this.labelEstaticoEntradas.Name = "labelEstaticoEntradas";
            this.labelEstaticoEntradas.Size = new System.Drawing.Size(166, 20);
            this.labelEstaticoEntradas.TabIndex = 11;
            this.labelEstaticoEntradas.Text = "Numero de entradas:";
            // 
            // wdReservasEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1183, 669);
            this.Controls.Add(this.labelEstaticoEntradas);
            this.Controls.Add(this.labelEstaticoEncabezado);
            this.Controls.Add(this.labelEstaticoEntrada);
            this.Controls.Add(this.lblEstacionamiento);
            this.Controls.Add(this.lblITBMS);
            this.Controls.Add(this.lblSPAC);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ckbEntradas);
            this.Controls.Add(this.numEntrada);
            this.Controls.Add(this.cbTipoEntrada);
            this.Name = "wdReservasEntrada";
            this.Text = "Reservas Entradas";
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
        private Label labelEstaticoEntrada;
        private Label labelEstaticoEncabezado;
        private Label labelEstaticoEntradas;
    }
}

