using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.model;
using Tools_Renting_System_Information.view.userControl;

namespace Tools_Renting_System_Information.view.forms
{
    public partial class ItemEditForm<T> : Form
    {
        
        public T Item { get; set; }

        public ItemEditForm(ref T item)
        {
            this.Item = item;
            InitializeComponent();
            CreateApropiateUserControl();
        }

        private void CreateApropiateUserControl()
        {
            UserControl userControl = null;
            switch (Item)
            {
                case Customer customer:
                    userControl = new UcEditCustomer(customer);
                    break;
                case Equipo equipo:
                    userControl = new UcEditEquipo(equipo);
                    break;
            }

            this.panel.Controls.Add(userControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
