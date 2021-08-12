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
    public partial class FrmMonstieGallery : Form
    {
        public FrmMonstieGallery()
        {
            InitializeComponent();
        }

        private void btnAddMonstie_Click(object sender, EventArgs e)
        {
            FrmAddMonstie addMonstie = new FrmAddMonstie
            {
                MdiParent = this.MdiParent,
                //WindowState = FormWindowState.Maximized
            };
            addMonstie.Show();
            Close();
        }
    }
}
