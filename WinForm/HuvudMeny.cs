using AffärsLager;
using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class HuvudMeny : Form
    {
        private Controller controller;
        public HuvudMeny(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            Inloggning newPage = new Inloggning(controller);
            this.Close();
            newPage.Show();
        }

        private void btnSkapaBokning_Click(object sender, EventArgs e)
        {
            new SkapaBokning(controller).Show();
            this.Hide();
        }

        private void btnÅterLämning_Click_1(object sender, EventArgs e)
        {
            new Återlämning(controller).Show();
            this.Hide();
        }
    }
}
