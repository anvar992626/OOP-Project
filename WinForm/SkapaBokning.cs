using AffärsLager;
using EntitetsLager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForm
{
    public partial class SkapaBokning : Form
    {
        private Controller controller;
        private IList<Bok> tillgänglig;

        public SkapaBokning(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;

            tillgänglig = controller.HämtaTillgängligaBöcker();
            foreach (Bok b in tillgänglig)

                listBoxListaAvBöcker.Items.Add(b.Boktitel); 
        }

        private void buttonLäggaTill_Click(object sender, EventArgs e)
        {
            int medlemsnummer = Convert.ToInt32(textBoxMedlemId.Text);
            DateTime startTid = dateTimePickerFrån.Value;
            int antalDagar = Convert.ToInt32(textBoxAntalDagar.Text);
            DateTime slutTid = startTid.AddDays(antalDagar);
            List<Bok> valdaBocker = new List<Bok>();

            int no = 0;

            if (0 < no && no <= tillgänglig.Count)
            {
                controller.Otillgänglig(tillgänglig[no - 1]);
                valdaBocker.Add(tillgänglig[no - 1]);
            }

            foreach (var bok in valdaBocker)
            {
                controller.Otillgänglig(bok); 
            }

            Bokning b = controller.SparaBokning(valdaBocker, medlemsnummer, startTid, slutTid);
            MessageBox.Show("Bokningen är bekräftad:\n\nMedlemsnamn: " + b.Medlemsnummer.Namn + "\nStarttid: "
                + startTid + "\nAntal dagar: " + antalDagar + "\nSluttid: " + slutTid);
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            new HuvudMeny(controller).Show();
            this.Close();
        }
    }
}
