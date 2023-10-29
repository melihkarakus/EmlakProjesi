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
    public partial class SatılıkForm : Form
    {
        public SatılıkForm()
        {
            InitializeComponent();
        }
        private EmlakServiceClient client = new EmlakServiceClient();
        private void Clear()
        {
            txtSatId.Clear();
            txtSatF.Clear();
            txtSatAdres.Clear();
        }
        private void SatılıkForm_Load(object sender, EventArgs e)
        {
            dgvSatılık.DataSource = client.GetSatılıks();
        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            client.AddSatılık(new Satılık
            {
                SatılıkFiyat = Convert.ToInt32(txtSatF.Text),
                Adres = txtSatAdres.Text
            });
            dgvSatılık.DataSource = client.GetSatılıks();
            Clear();
        }

        private void dgvSatılık_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvSatılık.Rows[e.RowIndex];
            txtSatId.Text = selectedRow.Cells["SatılıkId"].Value.ToString();
            txtSatF.Text = selectedRow.Cells["SatılıkFiyat"].Value.ToString();
            txtSatAdres.Text = selectedRow.Cells["SatılıkAdres"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.RemoveSatılık(Convert.ToInt32(txtSatId.Text.Trim()));
            dgvSatılık.DataSource = client.GetSatılıks();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.EditSatılık(new Satılık
            {
                SatılıkId = Convert.ToInt32(txtSatId.Text.Trim()),
                SatılıkFiyat = Convert.ToInt32(txtSatF.Text),
                Adres = txtSatAdres.Text
            });
            dgvSatılık.DataSource = client.GetSatılıks();
            Clear();
        }
    }
}
