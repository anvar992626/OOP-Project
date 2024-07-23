using AffärsLager;
using DatalagerEF;
using EntitetsLager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Återlämning : Form
    {
        private Controller controller;
        public Återlämning(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            IList<Bokning> aktivaBokningar = controller.HämtaBokningar();
            dataGridViewAktivaBokningar.DataSource = new BindingList<Bokning>(controller.HämtaBokningar().ToList());
        }

        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            new HuvudMeny(controller).Show();
            this.Close();
        }

        private void btnÅterlämna_Click(object sender, EventArgs e)
        {
            UnitOfWork UnitOfWorkef = new UnitOfWork();

            Bokning selectedBooking = dataGridViewAktivaBokningar.SelectedRows[0].DataBoundItem as Bokning;
            if (selectedBooking == null)
            {
                MessageBox.Show("Vänligen välj en bokning att avsluta.");
                return;
            }

            Faktura faktura = controller.LämnaInBokning(selectedBooking.Bokningsnummer);

            // Ta bort bokningen från databasen
            UnitOfWorkef.BokningRepos.Remove(selectedBooking);
            UnitOfWorkef.Save();

            MessageBox.Show("Bokningen är nu återlämnad och borttagen från databasen!");
        }
    }
}
