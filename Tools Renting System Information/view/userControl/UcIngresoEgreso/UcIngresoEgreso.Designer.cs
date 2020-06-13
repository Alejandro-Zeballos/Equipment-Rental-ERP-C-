namespace Tools_Renting_System_Information.view.userControl.UcIngresoEgreso
{
    partial class UcIngresoEgreso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioIngresos = new System.Windows.Forms.RadioButton();
            this.radioEgresos = new System.Windows.Forms.RadioButton();
            this.RadioIngresosEgresos = new System.Windows.Forms.RadioButton();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTypoReporte = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioResumen = new System.Windows.Forms.RadioButton();
            this.radioDetalle = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte Ingresos - Egresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha desde:";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(120, 81);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 22;
            this.datePicker.Value = new System.DateTime(2020, 6, 9, 13, 25, 5, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 9, 13, 25, 5, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha hasta:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadioIngresosEgresos);
            this.panel1.Controls.Add(this.radioEgresos);
            this.panel1.Controls.Add(this.radioIngresos);
            this.panel1.Location = new System.Drawing.Point(350, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 96);
            this.panel1.TabIndex = 25;
            // 
            // radioIngresos
            // 
            this.radioIngresos.AutoSize = true;
            this.radioIngresos.Checked = true;
            this.radioIngresos.Location = new System.Drawing.Point(24, 19);
            this.radioIngresos.Name = "radioIngresos";
            this.radioIngresos.Size = new System.Drawing.Size(81, 17);
            this.radioIngresos.TabIndex = 0;
            this.radioIngresos.Text = "INGRESOS";
            this.radioIngresos.UseVisualStyleBackColor = true;
            // 
            // radioEgresos
            // 
            this.radioEgresos.AutoSize = true;
            this.radioEgresos.Location = new System.Drawing.Point(24, 42);
            this.radioEgresos.Name = "radioEgresos";
            this.radioEgresos.Size = new System.Drawing.Size(77, 17);
            this.radioEgresos.TabIndex = 1;
            this.radioEgresos.Text = "EGRESOS";
            this.radioEgresos.UseVisualStyleBackColor = true;
            // 
            // RadioIngresosEgresos
            // 
            this.RadioIngresosEgresos.AutoSize = true;
            this.RadioIngresosEgresos.Location = new System.Drawing.Point(24, 65);
            this.RadioIngresosEgresos.Name = "RadioIngresosEgresos";
            this.RadioIngresosEgresos.Size = new System.Drawing.Size(142, 17);
            this.RadioIngresosEgresos.TabIndex = 2;
            this.RadioIngresosEgresos.Text = "INGRESOS - EGRESOS";
            this.RadioIngresosEgresos.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(441, 170);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(201, 57);
            this.buttonGenerateReport.TabIndex = 26;
            this.buttonGenerateReport.Text = "Generar Reporte";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Reporte";
            // 
            // labelTypoReporte
            // 
            this.labelTypoReporte.AutoSize = true;
            this.labelTypoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypoReporte.Location = new System.Drawing.Point(130, 210);
            this.labelTypoReporte.Name = "labelTypoReporte";
            this.labelTypoReporte.Size = new System.Drawing.Size(90, 24);
            this.labelTypoReporte.TabIndex = 30;
            this.labelTypoReporte.Text = "Ingresos";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(45, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 342);
            this.panel2.TabIndex = 31;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(188, 588);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(132, 50);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(45, 588);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(132, 50);
            this.buttonPrint.TabIndex = 33;
            this.buttonPrint.Text = "Imprimir Reporte";
            this.buttonPrint.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioResumen);
            this.panel3.Controls.Add(this.radioDetalle);
            this.panel3.Location = new System.Drawing.Point(546, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 96);
            this.panel3.TabIndex = 26;
            // 
            // radioResumen
            // 
            this.radioResumen.AutoSize = true;
            this.radioResumen.Location = new System.Drawing.Point(34, 48);
            this.radioResumen.Name = "radioResumen";
            this.radioResumen.Size = new System.Drawing.Size(79, 17);
            this.radioResumen.TabIndex = 1;
            this.radioResumen.Text = "RESUMEN";
            this.radioResumen.UseVisualStyleBackColor = true;
            // 
            // radioDetalle
            // 
            this.radioDetalle.AutoSize = true;
            this.radioDetalle.Checked = true;
            this.radioDetalle.Location = new System.Drawing.Point(34, 25);
            this.radioDetalle.Name = "radioDetalle";
            this.radioDetalle.Size = new System.Drawing.Size(73, 17);
            this.radioDetalle.TabIndex = 0;
            this.radioDetalle.Text = "DETALLE";
            this.radioDetalle.UseVisualStyleBackColor = true;
            // 
            // UcIngresoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTypoReporte);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "UcIngresoEgreso";
            this.Size = new System.Drawing.Size(746, 655);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadioIngresosEgresos;
        private System.Windows.Forms.RadioButton radioEgresos;
        private System.Windows.Forms.RadioButton radioIngresos;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTypoReporte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioResumen;
        private System.Windows.Forms.RadioButton radioDetalle;
    }
}
