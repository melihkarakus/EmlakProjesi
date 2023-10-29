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
    public partial class DaireForm : Form
    {
        public DaireForm()
        {
            InitializeComponent();
        }
        private EmlakServiceClient client = new EmlakServiceClient();
        private void Clear()
        {
            txtDId.Clear();
            txtDName.Clear();
            txtDNumber.Clear();
            txtOId.Clear();
            txtOName.Clear();
            txtONumber.Clear();
        }
        private void DaireForm_Load(object sender, EventArgs e)
        {
            dgvDaire.DataSource = client.GetDaires(); 
        }

        private void btnİnsert_Click(object sender, EventArgs e)
        {
            client.AddDaire(new Daire
            {
                DaireAdı = txtDName.Text,
                DaireSayısı = Convert.ToInt32(txtDNumber.Text),
            });
            client.AddOda(new Odalar 
            {
               OdaAdı = txtOName.Text,
               OdaSayısı = Convert.ToInt32(txtONumber.Text)
            });
            dgvDaire.DataSource = client.GetOdalars();
            dgvDaire.DataSource = client.GetDaires();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvDaire_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvDaire.Rows[e.RowIndex];
            txtDId.Text = selectedRow.Cells["DaireId"].Value.ToString();
            txtDName.Text = selectedRow.Cells["DaireAdı"].Value.ToString();
            txtDNumber.Text = selectedRow.Cells["DaireSayısı"].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.EditDaire(new Daire
            {
                DaireId = Convert.ToInt32(txtDId.Text),
                DaireAdı = txtDName.Text,
                DaireSayısı = Convert.ToInt32(txtDNumber.Text),
            });
            client.AddOda(new Odalar
            {
                OdaId = Convert.ToInt32(txtOId.Text),
                OdaAdı = txtOName.Text,
                OdaSayısı = Convert.ToInt32(txtONumber.Text)
            });
            dgvDaire.DataSource = client.GetOdalars();
            dgvDaire.DataSource = client.GetDaires();
            Clear();
        }
    }
}
