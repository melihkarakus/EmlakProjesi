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
    public partial class KiralıkForm : Form
    {
        public KiralıkForm()
        {
            InitializeComponent();
        }
        private EmlakServiceClient client = new EmlakServiceClient();
        private void Clear()
        {
            txtKId.Clear();
            txtKFiyat.Clear();
            txtKTarih.Clear();
            txtKAdres.Clear();
        }
        private void KiralıkForm_Load(object sender, EventArgs e)
        {
            dgvKiralık.DataSource = client.GetKiralıks();
        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            client.AddKiralık(new Kiralık
            {
                KiraFiyat =Convert.ToInt32(txtKFiyat.Text),
                KiraTarihi =Convert.ToDateTime(txtKTarih.Text)
            });
            dgvKiralık.DataSource = client.GetKiralıks();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            client.RemoveKiralık(Convert.ToInt32(txtKId.Text.Trim()));
            dgvKiralık.DataSource = client.GetKiralıks();
            Clear();
        }

        private void dgvKiralık_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvKiralık.Rows[e.RowIndex];
            txtKId.Text = selectedRow.Cells["KiralıkId"].Value.ToString();
            txtKFiyat.Text = selectedRow.Cells["KiralıkFiyat"].Value.ToString();
            txtKTarih.Text = selectedRow.Cells["KiralıkTarih"].Value.ToString();
            txtKAdres.Text = selectedRow.Cells["Adres"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.EditKiralık(new Kiralık
            {
                KiralıkId = Convert.ToInt32(txtKId.Text),
                KiraFiyat = Convert.ToInt32(txtKFiyat.Text),
                KiraTarihi = Convert.ToDateTime(txtKTarih.Text)
            });
            dgvKiralık.DataSource = client.GetKiralıks();
            Clear();
        }
    }
}
