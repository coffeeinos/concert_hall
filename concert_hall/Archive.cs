using MySql.Data.MySqlClient;
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
    public partial class Archive : Form
    {
        public Archive()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Archive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdvertisingCampaignArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            if (dataGridViewArchive.Visible == false)
            {
                dataGridViewArchive.Visible = true;
            }
            dataGridViewArchive.Columns[0].HeaderText = "Название выступления";
            dataGridViewArchive.Columns[1].HeaderText = "Название маркетинговой фирмы";
            dataGridViewArchive.Columns[2].HeaderText = "Номер телефона";
            if (dataGridViewArchive.Columns[2].Visible == false)
            {
                dataGridViewArchive.Columns[2].Visible = true;
            }
            dataGridViewArchive.Columns[3].HeaderText = "Цена";
            if (dataGridViewArchive.Columns[3].Visible == false)
            {
                dataGridViewArchive.Columns[3].Visible = true;
            }
            if (dataGridViewArchive.Columns[4].Visible == true)
            {
                dataGridViewArchive.Columns[4].Visible = false;
            }
            if (dataGridViewArchive.Columns[5].Visible == true)
            {
                dataGridViewArchive.Columns[5].Visible = false;
            }
            if (dataGridViewArchive.Columns[6].Visible == true)
            {
                dataGridViewArchive.Columns[6].Visible = false;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT performance_archive.name, advertising_campaign_archive.name, advertising_campaign_archive.phone_number, advertising_campaign_archive.cost FROM `advertising_campaign_archive` INNER JOIN performance_archive ON advertising_campaign_archive.id_performance = performance_archive.id", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArchive.Columns.Count - 3]);
                for (int i = 0; i < (dataGridViewArchive.Columns.Count - 3); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewArchive.Rows.Add(s);
            }
        }

        private void buttonPerformanceArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            if (dataGridViewArchive.Visible == false)
            {
                dataGridViewArchive.Visible = true;
            }
            dataGridViewArchive.Columns[0].HeaderText = "Номер холла";
            dataGridViewArchive.Columns[1].HeaderText = "Название выступления";
            dataGridViewArchive.Columns[2].HeaderText = "Жанр";
            if (dataGridViewArchive.Columns[2].Visible == false)
            {
                dataGridViewArchive.Columns[2].Visible = true;
            }
            dataGridViewArchive.Columns[3].HeaderText = "Дата";
            if (dataGridViewArchive.Columns[3].Visible == false)
            {
                dataGridViewArchive.Columns[3].Visible = true;
            }
            dataGridViewArchive.Columns[4].HeaderText = "Возрастное ограничение";
            if (dataGridViewArchive.Columns[4].Visible == false)
            {
                dataGridViewArchive.Columns[4].Visible = true;
            }
            dataGridViewArchive.Columns[5].HeaderText = "Использование фонограммы";
            if (dataGridViewArchive.Columns[5].Visible == false)
            {
                dataGridViewArchive.Columns[5].Visible = true;
            }
            dataGridViewArchive.Columns[6].HeaderText = "Цена";
            if (dataGridViewArchive.Columns[6].Visible == false)
            {
                dataGridViewArchive.Columns[6].Visible = true;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT hall.hall_number, `name`, `genre`, `day`, `age_limit`, `use_of_phonogram`, `cost` FROM performance_archive INNER JOIN hall ON performance_archive.id_hall = hall.id", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArchive.Columns.Count]);
                for (int i = 0; i < dataGridViewArchive.Columns.Count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewArchive.Rows.Add(s);
            }
        }

        private void buttonMarketingFirmArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            if (dataGridViewArchive.Visible == false)
            {
                dataGridViewArchive.Visible = true;
            }
            dataGridViewArchive.Columns[0].HeaderText = "Название маркетинговой фирмы";
            dataGridViewArchive.Columns[1].HeaderText = "Номер телефона";
            dataGridViewArchive.Columns[2].HeaderText = "Адрес";
            if (dataGridViewArchive.Columns[2].Visible == false)
            {
                dataGridViewArchive.Columns[2].Visible = true;
            }
            dataGridViewArchive.Columns[3].HeaderText = "Электронная почта";
            if (dataGridViewArchive.Columns[3].Visible == false)
            {
                dataGridViewArchive.Columns[3].Visible = true;
            }
            if (dataGridViewArchive.Columns[4].Visible == true)
            {
                dataGridViewArchive.Columns[4].Visible = false;
            }
            if (dataGridViewArchive.Columns[5].Visible == true)
            {
                dataGridViewArchive.Columns[5].Visible = false;
            }
            if (dataGridViewArchive.Columns[6].Visible == true)
            {
                dataGridViewArchive.Columns[6].Visible = false;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `name`, `phone_number`, `address`, `email` FROM `marketing_firm_archive` ", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArchive.Columns.Count - 3]);
                for (int i = 0; i < (dataGridViewArchive.Columns.Count - 3); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewArchive.Rows.Add(s);
            }
        }

        private void buttonGuestArtistArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            if (dataGridViewArchive.Visible == false)
            {
                dataGridViewArchive.Visible = true;
            }
            dataGridViewArchive.Columns[0].HeaderText = "ФИО";
            dataGridViewArchive.Columns[1].HeaderText = "Номер телефона";
            if (dataGridViewArchive.Columns[2].Visible == true)
            {
                dataGridViewArchive.Columns[2].Visible = false;
            }
            if (dataGridViewArchive.Columns[3].Visible == true)
            {
                dataGridViewArchive.Columns[3].Visible = false;
            }
            if (dataGridViewArchive.Columns[4].Visible == true)
            {
                dataGridViewArchive.Columns[4].Visible = false;
            }
            if (dataGridViewArchive.Columns[5].Visible == true)
            {
                dataGridViewArchive.Columns[5].Visible = false;
            }
            if (dataGridViewArchive.Columns[6].Visible == true)
            {
                dataGridViewArchive.Columns[6].Visible = false;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `full_name`, `phone_number` FROM `guest_artist_archive` ", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArchive.Columns.Count - 5]);
                for (int i = 0; i < (dataGridViewArchive.Columns.Count - 5); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewArchive.Rows.Add(s);
            }
        }

        private void buttonTheaterWorkerArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            if (dataGridViewArchive.Visible == false)
            {
                dataGridViewArchive.Visible = true;
            }
            dataGridViewArchive.Columns[0].HeaderText = "ФИО";
            dataGridViewArchive.Columns[1].HeaderText = "Должность";
            dataGridViewArchive.Columns[2].HeaderText = "Номер телефона";
            if (dataGridViewArchive.Columns[2].Visible == false)
            {
                dataGridViewArchive.Columns[2].Visible = true;
            }
            dataGridViewArchive.Columns[3].HeaderText = "Адрес";
            if (dataGridViewArchive.Columns[3].Visible == false)
            {
                dataGridViewArchive.Columns[3].Visible = true;
            }
            if (dataGridViewArchive.Columns[4].Visible == true)
            {
                dataGridViewArchive.Columns[4].Visible = false;
            }
            if (dataGridViewArchive.Columns[5].Visible == true)
            {
                dataGridViewArchive.Columns[5].Visible = false;
            }
            if (dataGridViewArchive.Columns[6].Visible == true)
            {
                dataGridViewArchive.Columns[6].Visible = false;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `full_name`, `position`, `phone_number`, `address` FROM `theater_worker_archive` ", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArchive.Columns.Count - 3]);
                for (int i = 0; i < (dataGridViewArchive.Columns.Count - 3); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewArchive.Rows.Add(s);
            }
        }

        private void buttonTicketArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            if (dataGridViewArchive.Visible == false)
            {
                dataGridViewArchive.Visible = true;
            }
            dataGridViewArchive.Columns[0].HeaderText = "Название выступления";
            dataGridViewArchive.Columns[1].HeaderText = "Номер места";
            dataGridViewArchive.Columns[2].HeaderText = "ФИО покупателя";
            if (dataGridViewArchive.Columns[2].Visible == false)
            {
                dataGridViewArchive.Columns[2].Visible = true;
            }
            dataGridViewArchive.Columns[3].HeaderText = "Цена";
            if (dataGridViewArchive.Columns[3].Visible == false)
            {
                dataGridViewArchive.Columns[3].Visible = true;
            }
            if (dataGridViewArchive.Columns[4].Visible == true)
            {
                dataGridViewArchive.Columns[4].Visible = false;
            }
            if (dataGridViewArchive.Columns[5].Visible == true)
            {
                dataGridViewArchive.Columns[5].Visible = false;
            }
            if (dataGridViewArchive.Columns[6].Visible == true)
            {
                dataGridViewArchive.Columns[6].Visible = false;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT performance_archive.name , place.number, ticket_archive.buyer_full_name, ticket_archive.cost FROM `ticket_archive` INNER JOIN performance_archive ON performance_archive.id = ticket_archive.id_performance INNER JOIN place ON place.id = ticket_archive.id_place", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArchive.Columns.Count - 3]);
                for (int i = 0; i < (dataGridViewArchive.Columns.Count - 3); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewArchive.Rows.Add(s);
            }
        }

        private void buttonDeletAdvertisingCampaignArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `advertising_campaign_archive`", db.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Архив рекламных компаний очищен");
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }

        private void buttonDeletMarketingFirmArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `marketing_firm_archive`", db.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Архив маркетинговых компаний очищен");
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }

        private void buttonDeletGuestArtistArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `guest_artist_archive`", db.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Архив приглашенных артистов очищен");
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }

        private void buttonDeletTheaterWorkerArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `theater_worker_archive`", db.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Архив работников театра очищен");
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }

        private void buttonDeletTicketArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `ticket_archive`", db.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Архив билетов очищен");
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }

        private void buttonDeletPerformanceArchive_Click(object sender, EventArgs e)
        {
            dataGridViewArchive.Rows.Clear();
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `advertising_campaign_archive` WHERE id_performance IN (SELECT id FROM performance_archive)", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
                if (table.Rows.Count > 0)
            {
                MessageBox.Show("Очистите сначала архив рекламных компаний");
                return;
            }
            command = new MySqlCommand("SELECT * FROM ticket_archive WHERE id_performance IN (SELECT id FROM performance_archive)", db.getConnection());
            adapter.SelectCommand = command;
            table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Очистите сначала архив билетов компаний");
                return;
            }
            db.openConnection();
            command = new MySqlCommand("DELETE FROM `performance_archive`", db.getConnection());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Архив выступлений очищен");
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }
    }
}
