namespace Tools_Renting_System_Information.view.userControl
{
    partial class UcAlquilarForm
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
            this.labelEquipoName = new System.Windows.Forms.Label();
            this.textBoxCliente = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHorasDias = new System.Windows.Forms.TextBox();
            this.radioDia = new System.Windows.Forms.RadioButton();
            this.radioHora = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxImporteTotal = new System.Windows.Forms.TextBox();
            this.textBoxImporteDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAlquilar = new System.Windows.Forms.Button();
            this.buttonAgregarCotizacion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEquipoName
            // 
            this.labelEquipoName.AutoSize = true;
            this.labelEquipoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipoName.Location = new System.Drawing.Point(344, 38);
            this.labelEquipoName.Name = "labelEquipoName";
            this.labelEquipoName.Size = new System.Drawing.Size(76, 25);
            this.labelEquipoName.TabIndex = 0;
            this.labelEquipoName.Text = "label1";
            // 
            // textBoxCliente
            // 
            // 
            // 
            // 
            this.textBoxCliente.CustomButton.Image = null;
            this.textBoxCliente.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.textBoxCliente.CustomButton.Name = "";
            this.textBoxCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxCliente.CustomButton.TabIndex = 1;
            this.textBoxCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxCliente.CustomButton.UseSelectable = true;
            this.textBoxCliente.CustomButton.Visible = false;
            this.textBoxCliente.Lines = new string[0];
            this.textBoxCliente.Location = new System.Drawing.Point(286, 87);
            this.textBoxCliente.MaxLength = 32767;
            this.textBoxCliente.Multiline = true;
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.PasswordChar = '\0';
            this.textBoxCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxCliente.SelectedText = "";
            this.textBoxCliente.SelectionLength = 0;
            this.textBoxCliente.SelectionStart = 0;
            this.textBoxCliente.ShortcutsEnabled = true;
            this.textBoxCliente.Size = new System.Drawing.Size(203, 23);
            this.textBoxCliente.TabIndex = 6;
            this.textBoxCliente.UseSelectable = true;
            this.textBoxCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCliente.Click += new System.EventHandler(this.textBoxCliente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cliente:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(584, 447);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 43);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(56, 164);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(640, 146);
            this.dataGrid.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Disponibles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Alquilar por:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxHorasDias);
            this.panel1.Controls.Add(this.radioDia);
            this.panel1.Controls.Add(this.radioHora);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(56, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 76);
            this.panel1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cuantas horas / dias:";
            // 
            // textBoxHorasDias
            // 
            this.textBoxHorasDias.Location = new System.Drawing.Point(197, 45);
            this.textBoxHorasDias.Name = "textBoxHorasDias";
            this.textBoxHorasDias.Size = new System.Drawing.Size(154, 20);
            this.textBoxHorasDias.TabIndex = 19;
            this.textBoxHorasDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHorasDias.TextChanged += new System.EventHandler(this.textBoxHorasDias_TextChanged);
            // 
            // radioDia
            // 
            this.radioDia.AutoSize = true;
            this.radioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDia.Location = new System.Drawing.Point(113, 43);
            this.radioDia.Name = "radioDia";
            this.radioDia.Size = new System.Drawing.Size(51, 24);
            this.radioDia.TabIndex = 17;
            this.radioDia.Text = "Dia";
            this.radioDia.UseVisualStyleBackColor = true;
            this.radioDia.CheckedChanged += new System.EventHandler(this.radioDia_CheckedChanged);
            // 
            // radioHora
            // 
            this.radioHora.AutoSize = true;
            this.radioHora.Checked = true;
            this.radioHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioHora.Location = new System.Drawing.Point(113, 13);
            this.radioHora.Name = "radioHora";
            this.radioHora.Size = new System.Drawing.Size(62, 24);
            this.radioHora.TabIndex = 16;
            this.radioHora.TabStop = true;
            this.radioHora.Text = "Hora";
            this.radioHora.UseVisualStyleBackColor = true;
            this.radioHora.CheckedChanged += new System.EventHandler(this.radioHora_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxImporteTotal);
            this.panel2.Controls.Add(this.textBoxImporteDia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(426, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 76);
            this.panel2.TabIndex = 17;
            // 
            // textBoxImporteTotal
            // 
            this.textBoxImporteTotal.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporteTotal.Location = new System.Drawing.Point(139, 38);
            this.textBoxImporteTotal.Name = "textBoxImporteTotal";
            this.textBoxImporteTotal.ReadOnly = true;
            this.textBoxImporteTotal.Size = new System.Drawing.Size(117, 27);
            this.textBoxImporteTotal.TabIndex = 22;
            this.textBoxImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxImporteDia
            // 
            this.textBoxImporteDia.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporteDia.Location = new System.Drawing.Point(139, 6);
            this.textBoxImporteDia.Name = "textBoxImporteDia";
            this.textBoxImporteDia.ReadOnly = true;
            this.textBoxImporteDia.Size = new System.Drawing.Size(117, 27);
            this.textBoxImporteDia.TabIndex = 20;
            this.textBoxImporteDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Importe por dia:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Importe Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAlquilar
            // 
            this.buttonAlquilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlquilar.Location = new System.Drawing.Point(56, 451);
            this.buttonAlquilar.Name = "buttonAlquilar";
            this.buttonAlquilar.Size = new System.Drawing.Size(137, 43);
            this.buttonAlquilar.TabIndex = 18;
            this.buttonAlquilar.Text = "Alquilar ya!";
            this.buttonAlquilar.UseVisualStyleBackColor = true;
            this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
            // 
            // buttonAgregarCotizacion
            // 
            this.buttonAgregarCotizacion.Location = new System.Drawing.Point(221, 451);
            this.buttonAgregarCotizacion.Name = "buttonAgregarCotizacion";
            this.buttonAgregarCotizacion.Size = new System.Drawing.Size(112, 43);
            this.buttonAgregarCotizacion.TabIndex = 19;
            this.buttonAgregarCotizacion.Text = "Agregar a Cotizacion";
            this.buttonAgregarCotizacion.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha a Devolver:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(214, 411);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 21;
            this.datePicker.Value = new System.DateTime(2020, 6, 9, 13, 25, 5, 0);
            // 
            // UcAlquilarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAgregarCotizacion);
            this.Controls.Add(this.buttonAlquilar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.textBoxCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelEquipoName);
            this.Controls.Add(this.panel1);
            this.Name = "UcAlquilarForm";
            this.Size = new System.Drawing.Size(762, 521);
            this.Enter += new System.EventHandler(this.UcAlquilarForm_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipoName;
        private MetroFramework.Controls.MetroTextBox textBoxCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHorasDias;
        private System.Windows.Forms.RadioButton radioDia;
        private System.Windows.Forms.RadioButton radioHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxImporteTotal;
        private System.Windows.Forms.TextBox textBoxImporteDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAlquilar;
        private System.Windows.Forms.Button buttonAgregarCotizacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
