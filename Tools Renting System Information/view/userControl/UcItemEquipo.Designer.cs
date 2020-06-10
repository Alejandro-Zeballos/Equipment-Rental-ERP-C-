namespace Tools_Renting_System_Information.view.userControl
{
    partial class UcItemEquipo
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
            this.labelEquipo = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEquipo
            // 
            this.labelEquipo.AutoSize = true;
            this.labelEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipo.Location = new System.Drawing.Point(86, 13);
            this.labelEquipo.Name = "labelEquipo";
            this.labelEquipo.Size = new System.Drawing.Size(92, 31);
            this.labelEquipo.TabIndex = 0;
            this.labelEquipo.Text = "label1";
            this.labelEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(33, 57);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(215, 204);
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // UcItemEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.img);
            this.Controls.Add(this.labelEquipo);
            this.Name = "UcItemEquipo";
            this.Size = new System.Drawing.Size(280, 284);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UcItemEquipo_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEquipo;
        private System.Windows.Forms.PictureBox img;
    }
}
