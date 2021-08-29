using System;
using System.Windows.Forms;

namespace MonstiePocket
{
    public partial class FrmAddMonstie : Form
    {
        public FrmAddMonstie()
        {
            InitializeComponent();
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

        private void btnAddMonstieToDb_Click(object sender, EventArgs e)
        {
            Monstie monster = new Monstie
            {
                MonstieNumber = Convert.ToInt16(txtMonstieId.Text),
                RiderAction1 = cmbRiderAction1.SelectedItem?.ToString(),
                RiderAction2 = cmbRiderAction2.SelectedItem?.ToString(),
                Genus = cmbGenus.SelectedItem?.ToString(),
                Habitat = cmbHabitat.SelectedItem?.ToString(),
                MonstieRarity = Convert.ToByte(cmbRarity.SelectedItem),
                Name = txtMonstieName.Text,
            };

            if (rdoTypePower.Checked)
            {
                monster.Status = "Power";
            }
            else if (rdoTypeTech.Checked)
            {
                monster.Status = "Tech";
            }
            else if (rdoTypeSpeed.Checked)
            {
                monster.Status = "Speed";
            }
            MonstieDB.Add(monster);
        }
    }
}
