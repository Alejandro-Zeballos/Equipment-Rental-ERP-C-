namespace Tools_Renting_System_Information.model.userControl
{
    partial class UcAlquilar
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.textBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(294, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Alquilar Equipo";
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(201, 76);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(43, 13);
            this.labelBuscar.TabIndex = 1;
            this.labelBuscar.Text = "Buscar:";
            // 
            // textBoxSearch
            // 
            // 
            // 
            // 
            this.textBoxSearch.CustomButton.Image = null;
            this.textBoxSearch.CustomButton.Location = new System.Drawing.Point(177, 1);
            this.textBoxSearch.CustomButton.Name = "";
            this.textBoxSearch.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxSearch.CustomButton.TabIndex = 1;
            this.textBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxSearch.CustomButton.UseSelectable = true;
            this.textBoxSearch.CustomButton.Visible = false;
            this.textBoxSearch.Lines = new string[0];
            this.textBoxSearch.Location = new System.Drawing.Point(265, 71);
            this.textBoxSearch.MaxLength = 32767;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.SelectionLength = 0;
            this.textBoxSearch.SelectionStart = 0;
            this.textBoxSearch.ShortcutsEnabled = true;
            this.textBoxSearch.Size = new System.Drawing.Size(193, 17);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.UseSelectable = true;
            this.textBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Location = new System.Drawing.Point(0, 104);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(710, 435);
            this.flowLayout.TabIndex = 3;
            // 
            // UcAlquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelBuscar);
            this.Controls.Add(this.labelTitle);
            this.Name = "UcAlquilar";
            this.Size = new System.Drawing.Size(713, 539);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBuscar;
        private MetroFramework.Controls.MetroTextBox textBoxSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
    }
}
