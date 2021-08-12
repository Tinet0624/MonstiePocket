using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonstiePocket
{
    public partial class FrmAddMonstie : Form
    {
        public FrmAddMonstie()
        {
            InitializeComponent();
        }

        private void FrmAddMonstie_Load(object sender, EventArgs e)
        {

        }

        private void btnBackGallery_Click(object sender, EventArgs e)
        {
            FrmMonstieGallery monstieGallery = new FrmMonstieGallery
            {
                MdiParent = this.MdiParent,
                //WindowState = FormWindowState.Maximized
            };
            monstieGallery.Show();
            Close();
        }
    }
}
