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
    public partial class MainParent : Form
    {
        public MainParent()
        {
            InitializeComponent();
            frmMonstieGallery monstieGallery = new frmMonstieGallery();
            monstieGallery.MdiParent = this;
            if (ActiveMdiChild == null)
            {
                monstieGallery.Show();
            }
        }
    }
}
