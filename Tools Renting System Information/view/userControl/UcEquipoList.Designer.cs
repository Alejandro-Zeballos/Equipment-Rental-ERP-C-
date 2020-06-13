namespace Tools_Renting_System_Information.view.userControl
{
    partial class UcEquipoList
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.labelEquipoName = new System.Windows.Forms.Label();
            this.textBoxEquipo = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(29, 187);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(640, 201);
            this.dataGrid.TabIndex = 14;
            this.dataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
            // 
            // labelEquipoName
            // 
            this.labelEquipoName.AutoSize = true;
            this.labelEquipoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipoName.Location = new System.Drawing.Point(241, 48);
            this.labelEquipoName.Name = "labelEquipoName";
            this.labelEquipoName.Size = new System.Drawing.Size(188, 25);
            this.labelEquipoName.TabIndex = 15;
            this.labelEquipoName.Text = "Lista de Equipos";
            // 
            // textBoxEquipo
            // 
            // 
            // 
            // 
            this.textBoxEquipo.CustomButton.Image = null;
            this.textBoxEquipo.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.textBoxEquipo.CustomButton.Name = "";
            this.textBoxEquipo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxEquipo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxEquipo.CustomButton.TabIndex = 1;
            this.textBoxEquipo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxEquipo.CustomButton.UseSelectable = true;
            this.textBoxEquipo.CustomButton.Visible = false;
            this.textBoxEquipo.Lines = new string[0];
            this.textBoxEquipo.Location = new System.Drawing.Point(151, 147);
            this.textBoxEquipo.MaxLength = 32767;
            this.textBoxEquipo.Multiline = true;
            this.textBoxEquipo.Name = "textBoxEquipo";
            this.textBoxEquipo.PasswordChar = '\0';
            this.textBoxEquipo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxEquipo.SelectedText = "";
            this.textBoxEquipo.SelectionLength = 0;
            this.textBoxEquipo.SelectionStart = 0;
            this.textBoxEquipo.ShortcutsEnabled = true;
            this.textBoxEquipo.Size = new System.Drawing.Size(203, 23);
            this.textBoxEquipo.TabIndex = 16;
            this.textBoxEquipo.UseSelectable = true;
            this.textBoxEquipo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxEquipo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar Equipo:";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(32, 427);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(137, 43);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Location = new System.Drawing.Point(189, 427);
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size(112, 43);
            this.buttonImprimir.TabIndex = 21;
            this.buttonImprimir.Text = "Imprimir";
            this.buttonImprimir.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(557, 427);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 43);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // UcEquipoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxEquipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelEquipoName);
            this.Controls.Add(this.dataGrid);
            this.Name = "UcEquipoList";
            this.Size = new System.Drawing.Size(699, 520);
            this.Enter += new System.EventHandler(this.UcEquipoList_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label labelEquipoName;
        private MetroFramework.Controls.MetroTextBox textBoxEquipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.Button buttonCancel;
    }
}
