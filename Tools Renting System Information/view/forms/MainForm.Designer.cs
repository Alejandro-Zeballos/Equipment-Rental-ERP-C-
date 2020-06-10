namespace Tools_Renting_System_Information.view.forms
{
    partial class MainForm
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
            this.container = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inversoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteParaInversoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAlquilar = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.buttonEgreso = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.menuStrip1);
            this.container.Location = new System.Drawing.Point(184, 7);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(803, 649);
            this.container.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversoresToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.inversoresToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inversoresToolStripMenuItem
            // 
            this.inversoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosEgresosToolStripMenuItem,
            this.reporteEquiposToolStripMenuItem,
            this.reporteParaInversoresToolStripMenuItem});
            this.inversoresToolStripMenuItem.Name = "inversoresToolStripMenuItem";
            this.inversoresToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.inversoresToolStripMenuItem.Text = "Reportes";
            // 
            // ingresosEgresosToolStripMenuItem
            // 
            this.ingresosEgresosToolStripMenuItem.Name = "ingresosEgresosToolStripMenuItem";
            this.ingresosEgresosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresosEgresosToolStripMenuItem.Text = "Ingresos - Egresos";
            // 
            // reporteEquiposToolStripMenuItem
            // 
            this.reporteEquiposToolStripMenuItem.Name = "reporteEquiposToolStripMenuItem";
            this.reporteEquiposToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.reporteEquiposToolStripMenuItem.Text = "Reporte Equipos";
            // 
            // reporteParaInversoresToolStripMenuItem
            // 
            this.reporteParaInversoresToolStripMenuItem.Name = "reporteParaInversoresToolStripMenuItem";
            this.reporteParaInversoresToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.reporteParaInversoresToolStripMenuItem.Text = "Reporte para Inversores";
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem,
            this.editarEquipoToolStripMenuItem,
            this.listarEquiposToolStripMenuItem});
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.equiposToolStripMenuItem.Text = "Equipos";
            // 
            // agregarEquipoToolStripMenuItem
            // 
            this.agregarEquipoToolStripMenuItem.Name = "agregarEquipoToolStripMenuItem";
            this.agregarEquipoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarEquipoToolStripMenuItem.Text = "Agregar Equipo";
            this.agregarEquipoToolStripMenuItem.Click += new System.EventHandler(this.agregarEquipoToolStripMenuItem_Click);
            // 
            // editarEquipoToolStripMenuItem
            // 
            this.editarEquipoToolStripMenuItem.Name = "editarEquipoToolStripMenuItem";
            this.editarEquipoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editarEquipoToolStripMenuItem.Text = "Editar Equipo";
            // 
            // listarEquiposToolStripMenuItem
            // 
            this.listarEquiposToolStripMenuItem.Name = "listarEquiposToolStripMenuItem";
            this.listarEquiposToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.listarEquiposToolStripMenuItem.Text = "Listar Equipos";
            // 
            // inversoresToolStripMenuItem1
            // 
            this.inversoresToolStripMenuItem1.Name = "inversoresToolStripMenuItem1";
            this.inversoresToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.inversoresToolStripMenuItem1.Text = "Inversores";
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(0, 85);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(186, 67);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAlquilar
            // 
            this.buttonAlquilar.Location = new System.Drawing.Point(0, 148);
            this.buttonAlquilar.Name = "buttonAlquilar";
            this.buttonAlquilar.Size = new System.Drawing.Size(186, 67);
            this.buttonAlquilar.TabIndex = 3;
            this.buttonAlquilar.Text = "Alquilar Equipo";
            this.buttonAlquilar.UseVisualStyleBackColor = true;
            this.buttonAlquilar.Click += new System.EventHandler(this.buttonAlquilar_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(0, 212);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(186, 67);
            this.buttonBuscarCliente.TabIndex = 4;
            this.buttonBuscarCliente.Text = "Buscar Cliente";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.Location = new System.Drawing.Point(0, 274);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(186, 67);
            this.buttonAgregarCliente.TabIndex = 5;
            this.buttonAgregarCliente.Text = "Agregar Cliente";
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.buttonAgregarCliente_Click);
            // 
            // buttonEgreso
            // 
            this.buttonEgreso.Location = new System.Drawing.Point(0, 338);
            this.buttonEgreso.Name = "buttonEgreso";
            this.buttonEgreso.Size = new System.Drawing.Size(186, 67);
            this.buttonEgreso.TabIndex = 6;
            this.buttonEgreso.Text = "Egreso";
            this.buttonEgreso.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 658);
            this.Controls.Add(this.buttonEgreso);
            this.Controls.Add(this.buttonAgregarCliente);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.buttonAlquilar);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.container);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAlquilar;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.Button buttonAgregarCliente;
        private System.Windows.Forms.Button buttonEgreso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inversoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteParaInversoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversoresToolStripMenuItem1;
    }
}