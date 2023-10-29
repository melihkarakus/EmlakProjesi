using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emlak.UI.EmlakServiceReference;

namespace Emlak.UI.Forms
{
    public partial class MüsteriForm : Form
    {
        public MüsteriForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private EmlakServiceClient client = new EmlakServiceClient();

        private void Clear()
        {
            txtMId.Clear();
            txtMName.Clear();
            txtMSurname.Clear();
            txtMTc.Clear();
            txtMEmail.Clear();
        }
        private void MüsteriForm_Load(object sender, EventArgs e)
        {
            dgvMüsteri.DataSource = client.GetMüsteris();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            client.AddMüsteri(new Müsteri
            {
                MüsteriAdı = txtMName.Text,
                MüsteriSoyadı = txtMSurname.Text,
                MüsteriTc = Convert.ToInt32(txtMTc.Text),
                MüsteriMail = txtMEmail.Text
            });
            dgvMüsteri.DataSource = client.GetMüsteris();
            Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            client.RemoveMüsteri(Convert.ToInt32(txtMId.Text.Trim()));
            dgvMüsteri.DataSource = client.GetMüsteris();
            Clear();
        }

        private void dgvMüsteri_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvMüsteri.Rows[e.RowIndex];
            txtMId.Text = selectedRow.Cells["MüsterId"].Value.ToString();
            txtMName.Text = selectedRow.Cells["MüsteriAd"].Value.ToString();
            txtMSurname.Text = selectedRow.Cells["MüsteriSoyadı"].Value.ToString();
            txtMTc.Text = selectedRow.Cells["MüsteriTC"].Value.ToString();
            txtMEmail.Text = selectedRow.Cells["MüsteriEMail"].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            client.EditMüsteri(new Müsteri
            {
                MüsteriId = Convert.ToInt32(txtMId.Text.Trim()),
                MüsteriAdı = txtMName.Text,
                MüsteriSoyadı = txtMSurname.Text,
                MüsteriTc = Convert.ToInt32(txtMTc.Text),
                MüsteriMail = txtMEmail.Text
            });
            dgvMüsteri.DataSource = client.GetMüsteris();
            Clear();
        }
    }
}
