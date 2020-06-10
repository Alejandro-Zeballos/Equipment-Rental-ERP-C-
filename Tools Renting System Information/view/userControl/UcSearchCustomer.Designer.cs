namespace Tools_Renting_System_Information.view.userControl
{
    partial class UcSearchCustomer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioCarnet = new System.Windows.Forms.RadioButton();
            this.radioNombre = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new MetroFramework.Controls.MetroButton();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.buttonSelect = new MetroFramework.Controls.MetroButton();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioCarnet);
            this.panel1.Controls.Add(this.radioNombre);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(204, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 117);
            this.panel1.TabIndex = 2;
            // 
            // radioCarnet
            // 
            this.radioCarnet.AutoSize = true;
            this.radioCarnet.Location = new System.Drawing.Point(115, 83);
            this.radioCarnet.Name = "radioCarnet";
            this.radioCarnet.Size = new System.Drawing.Size(75, 17);
            this.radioCarnet.TabIndex = 3;
            this.radioCarnet.Text = "Por Carnet";
            this.radioCarnet.UseVisualStyleBackColor = true;
            this.radioCarnet.CheckedChanged += new System.EventHandler(this.radioCarnet_CheckedChanged);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Checked = true;
            this.radioNombre.Location = new System.Drawing.Point(115, 60);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(81, 17);
            this.radioNombre.TabIndex = 2;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Por Nombre";
            this.radioNombre.UseVisualStyleBackColor = true;
            this.radioNombre.CheckedChanged += new System.EventHandler(this.radioNombre_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonAdd.Location = new System.Drawing.Point(120, 218);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 58);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseSelectable = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonCancel.Location = new System.Drawing.Point(484, 218);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(148, 58);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseSelectable = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.buttonSelect.Location = new System.Drawing.Point(302, 218);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(148, 58);
            this.buttonSelect.TabIndex = 11;
            this.buttonSelect.Text = "Seleccionar";
            this.buttonSelect.UseSelectable = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(49, 317);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(640, 146);
            this.dataGrid.TabIndex = 12;
            // 
            // UcSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UcSearchCustomer";
            this.Size = new System.Drawing.Size(740, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioCarnet;
        private System.Windows.Forms.RadioButton radioNombre;
        private MetroFramework.Controls.MetroButton buttonAdd;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroButton buttonSelect;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}
