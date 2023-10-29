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
    public partial class MülkSahibiForm : Form
    {
        public MülkSahibiForm()
        {
            InitializeComponent();
        }
        private EmlakServiceClient client = new EmlakServiceClient();

        private void Clear()
        {
            txtSId.Clear();
            txtSAdı.Clear();
            txtSaSoyadı.Clear();
            txtSTc.Clear();
            txtSEmail.Clear();
        }
        private void MülkSahibiForm_Load(object sender, EventArgs e)
        {
            dgvMülkSahibi.DataSource = client.GetMalSahibis();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            client.AddMalSahibi(new MalSahibi 
            {
              SahipAdı = txtSAdı.Text,
              SahipSoyadı = txtSaSoyadı.Text,
              SahipTc = Convert.ToInt32(txtSTc.Text),
              SahipEmail = txtSEmail.Text
            });
            dgvMülkSahibi.DataSource = client.GetMalSahibis();
            Clear();
        }

        private void dgvMülkSahibi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvMülkSahibi.Rows[e.RowIndex];
            txtSId.Text = selectedRow.Cells["MülkSahibiId"].Value.ToString();
            txtSAdı.Text = selectedRow.Cells["MülkSahibiAdı"].Value.ToString();
            txtSaSoyadı.Text = selectedRow.Cells["MülkSahibiSoyadı"].Value.ToString();
            txtSTc.Text = selectedRow.Cells["MülkSahibiTc"].Value.ToString();
            txtSEmail.Text = selectedRow.Cells["MülkSahibiEmail"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.RemoveMalSahibi(Convert.ToInt32(txtSId.Text.Trim()));
            dgvMülkSahibi.DataSource = client.GetMalSahibis();
            Clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            client.EditMalSahibi(new MalSahibi
            {
                SahipId = Convert.ToInt32(txtSId.Text),
                SahipAdı = txtSAdı.Text,
                SahipSoyadı = txtSaSoyadı.Text,
                SahipTc = Convert.ToInt32(txtSTc.Text),
                SahipEmail = txtSEmail.Text
            });
            dgvMülkSahibi.DataSource = client.GetMalSahibis();
            Clear();
        }
    }
}
