using AffärsLager;
using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Inloggning : Form
    {
        private Controller controller;
        public Inloggning(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void buttonLoggaIn_Click(object sender, EventArgs e)
        {
            if (controller.LoggaIn(int.Parse(txtboxAnvändarNamn.Text), txtboxtLösenord.Text))
            {
                new HuvudMeny(controller).Show();
                this.Close();
            }
        }

        private void buttonAvbryt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
