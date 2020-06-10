using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools_Renting_System_Information.presenter;
using Tools_Renting_System_Information.view.forms;
using Tools_Renting_System_Information.model.userControl;

namespace Tools_Renting_System_Information.view.userControl
{
    public partial class UcItemEquipo : UserControl
    {
        AlquilarEquipoPresenter presenter;
        public UcItemEquipo(AlquilarEquipoPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
            
        }

        public string EquipoName
        {
            get { return this.labelEquipo.Text; }
            set { this.labelEquipo.Text = value; }
        }

        public string Img
        {
            set { this.img.ImageLocation = value; }
        }

        private void UcItemEquipo_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void img_Click(object sender, EventArgs e)
        {
            UcAlquilarForm form = UcAlquilarForm.Instance;
            form.setTypeEquipo(this.EquipoName);
            ((MainForm)ParentForm).DisplayUserControl(form);
        }
    }
}
