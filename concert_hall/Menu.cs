using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concert_hall
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket ticket = new Ticket();
            ticket.Show();
        }

        private void buttonArtist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artist artist = new Artist();
            artist.Show();
        }

        private void buttonAdvertising_Click(object sender, EventArgs e)
        {
            this.Hide();
            Advertising advertising = new Advertising();
            advertising.Show();
        }

        private void buttonPremises_Click(object sender, EventArgs e)
        {
            this.Hide();
            Premises premises = new Premises();
            premises.Show();
        }

        private void buttonPerformance_Click(object sender, EventArgs e)
        {
            this.Hide();
            Performance performance = new Performance();
            performance.Show();
        }

        private void buttonAdministrators_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrators administrators = new Administrators();
            administrators.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Archive archive = new Archive();
            archive.Show();
        }
    }
}
