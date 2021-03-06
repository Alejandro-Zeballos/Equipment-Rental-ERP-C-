﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.view.forms;

namespace Tools_Renting_System_Information.model.userControl
{
    public partial class UcItemRented : UserControl
    {
        public UcItemRented()
        {
            InitializeComponent();
        }
        public Customer _customer;

        #region Properties
        public int equipoRentedId { get; set; }
        public int Quantity{ set { this.labelQuantity.Text = value.ToString(); } }
        public string Detalle { set { this.labelDetalle.Text = value; } }
        public string ItemName { set {this.labelTypeItem.Text = value; } }
        public Equipo equipo { get; set; }
        public string DateToReturn { set {this.labelFecha.Text = value; } }
        public string TimeLeftToReturn { set {this.labelHrsFaltan.Text = value; } }
        public Customer customer { get { return this._customer; } set { this._customer = value; } }
        public string CustomerName { set {this.labelCliente.Text = value; } }
        public User user { get; set; }
        public string UserName { set {this.labelUsuario.Text = value; } }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            UcHome.Instance.presenter.returnEquipo(this.equipoRentedId);
        }

        private void labelCliente_DoubleClick(object sender, EventArgs e)
        {
            Form form = new ItemDetailForm<Customer>(item: ref _customer);
            form.Show();
        }
    }
}
