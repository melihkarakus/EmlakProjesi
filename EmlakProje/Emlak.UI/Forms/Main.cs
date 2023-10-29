using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak.UI.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolMenu.Enabled = false;
            LoginForm loginForm = new LoginForm(this);
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            MüsteriForm müsteriForm = new MüsteriForm();
            müsteriForm.MdiParent = this;
            müsteriForm.Show();
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            DaireForm daireForm = new DaireForm();
            daireForm.MdiParent = this;
            daireForm.Show();
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            MülkSahibiForm mülkSahibiForm = new MülkSahibiForm();
            mülkSahibiForm.MdiParent = this;
            mülkSahibiForm.Show();
        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {
            KiralıkForm kiralıkForm = new KiralıkForm();
            kiralıkForm.MdiParent = this;
            kiralıkForm.Show();
        }

        private void toolStripDropDownButton6_Click(object sender, EventArgs e)
        {
            SatılıkForm satılıkForm = new SatılıkForm();
            satılıkForm.MdiParent = this;
            satılıkForm.Show();
        }
    }
}
