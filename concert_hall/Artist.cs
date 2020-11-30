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
    public partial class Artist : Form
    {
        public Artist()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Artist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowTheatreArtist_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Visible == true)
            {
                textBoxFullName.Visible = false;
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Visible = false;
            }
            if (textBoxPosition.Visible == true)
            {
                textBoxPosition.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (buttonDecision.Visible == true)
            {
                buttonDecision.Visible = false;
            }
            if (dataGridViewArtist.Visible == false)
            {
                dataGridViewArtist.Visible = true;
            }
            if (dataGridViewArtist.Visible == true)
            {
                dataGridViewArtist.Columns["address"].Visible = true;
                dataGridViewArtist.Columns["position"].Visible = true;
            }
            dataGridViewArtist.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT full_name, position, phone_number, address FROM theater_worker", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while(reader.Read())
            {
                data.Add(new string[dataGridViewArtist.Columns.Count]);
                for (int i = 0; i<dataGridViewArtist.Columns.Count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();
            foreach (string[] s in data)
            {
                dataGridViewArtist.Rows.Add(s);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void textBoxFullName_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "Введите ФИО актера")
            {
                textBoxFullName.Text = "";
            }
        }

        private void textBoxFullName_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "")
            {
                textBoxFullName.Text = "Введите ФИО актера";
            }
        }

        private void textBoxPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "Введите номер телефона актера")
            {
                textBoxPhoneNumber.Text = "";
            }
        }

        private void textBoxPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "")
            {
                textBoxPhoneNumber.Text = "Введите номер телефона актера";
            }
        }

        private void textBoxAddress_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Введите домашний адрес актера")
            {
                textBoxAddress.Text = "";
            }
        }

        private void textBoxAddress_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "")
            {
                textBoxAddress.Text = "Введите домашний адрес актера";
            }
        }

        private void textBoxPosition_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxPosition.Text == "Введите должность актера")
            {
                textBoxPosition.Text = "";
            }
        }

        private void textBoxPosition_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPosition.Text == "")
            {
                textBoxPosition.Text = "Введите должность актера";
            }
        }

        private void buttonGuestArtists_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Visible == true)
            {
                textBoxFullName.Visible = false;
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Visible = false;
            }
            if (textBoxPosition.Visible == true)
            {
                textBoxPosition.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (buttonDecision.Visible == true)
            {
                buttonDecision.Visible = false;
            }
            if (dataGridViewArtist.Visible == false)
            {
                dataGridViewArtist.Visible = true;
            }
            dataGridViewArtist.Rows.Clear();
            dataGridViewArtist.Columns["address"].Visible = false;
            dataGridViewArtist.Columns["position"].Visible = false;
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT  full_name, phone_number FROM guest_artist", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewArtist.Columns.Count-2]);
                for (int i = 0; i < (dataGridViewArtist.Columns.Count-2); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();
            foreach (string[] s in data)
            {
                dataGridViewArtist.Rows.Add(s);
            }

        }

        private void buttonAddArtist_Click(object sender, EventArgs e)
        {
            buttonDecision.Text = "Нанять";
            if (textBoxFullName.Visible == false)
            {
                textBoxFullName.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == false)
            {
                textBoxPhoneNumber.Visible = true;
            }
            if (textBoxPosition.Visible == false)
            {
                textBoxPosition.Visible = true;
            }
            if (textBoxAddress.Visible == false)
            {
                textBoxAddress.Visible = true;
            }
            if (buttonDecision.Visible == false)
            {
                buttonDecision.Visible = true;
            }
            if (dataGridViewArtist.Visible == true)
            {
                dataGridViewArtist.Visible = false;
            }


            if (textBoxFullName.Visible == true)
            {
                textBoxFullName.Text = "Введите ФИО актера";
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Text = "Введите номер телефона актера";
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Text = "Введите домашний адрес актера";
            }
            if (textBoxPosition.Visible == true)
            {
                textBoxPosition.Text = "Введите должность актера";
            }
        }

        private void buttonAddGuestArtist_Click(object sender, EventArgs e)
        {
            buttonDecision.Text = "Добавить";
            if (textBoxFullName.Visible == false)
            {
                textBoxFullName.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == false)
            {
                textBoxPhoneNumber.Visible = true;
            }
            if (buttonDecision.Visible == false)
            {
                buttonDecision.Visible = true;
            }
            if (textBoxPosition.Visible == true)
            {
                textBoxPosition.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (dataGridViewArtist.Visible == true)
            {
                dataGridViewArtist.Visible = false;
            }


            if (textBoxFullName.Visible == true)
            {
                textBoxFullName.Text = "Введите ФИО актера";
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Text = "Введите номер телефона актера";
            }
        }

        private void buttonFireArtist_Click(object sender, EventArgs e)
        {
            buttonDecision.Text = "Уволить";
            if (textBoxFullName.Visible == false)
            {
                textBoxFullName.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == false)
            {
                textBoxPhoneNumber.Visible = true;
            }
            if (textBoxPosition.Visible == true)
            {
                textBoxPosition.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (buttonDecision.Visible == false)
            {
                buttonDecision.Visible = true;
            }
            if (dataGridViewArtist.Visible == true)
            {
                dataGridViewArtist.Visible = false;
            }


            if (textBoxFullName.Visible == true)
            {
                textBoxFullName.Text = "Введите ФИО актера";
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Text = "Введите номер телефона актера";
            }
        }

        private void buttonFireGuestArtist_Click(object sender, EventArgs e)
        {
            buttonDecision.Text = "Убрать";
            if (textBoxFullName.Visible == false)
            {
                textBoxFullName.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == false)
            {
                textBoxPhoneNumber.Visible = true;
            }
            if (textBoxPosition.Visible == true)
            {
                textBoxPosition.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (buttonDecision.Visible == false)
            {
                buttonDecision.Visible = true;
            }
            if (dataGridViewArtist.Visible == true)
            {
                dataGridViewArtist.Visible = false;
            }


            if (textBoxFullName.Visible == true)
            {
                textBoxFullName.Text = "Введите ФИО актера";
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Text = "Введите номер телефона актера";
            }
        }

        private void buttonDecision_Click(object sender, EventArgs e)
        {
            string fullName = textBoxFullName.Text;
            string phoneNumber = textBoxPhoneNumber.Text;
            if (textBoxFullName.Text == "Введите ФИО актера")
            {
                MessageBox.Show("Введите ФИО актера");
                return;
            }
            if (textBoxPhoneNumber.Text == "Введите номер телефона актера")
            {
                MessageBox.Show("Введите номер телефона актера");
                return;
            }
            if (buttonDecision.Text == "Нанять")
            {
                if (textBoxAddress.Text == "Введите домашний адрес актера")
                {
                    MessageBox.Show("Введите домашний адрес актера");
                    return;
                }
                if (textBoxPosition.Text == "Введите должность актера")
                {
                    MessageBox.Show("Введите должность актера");
                    return;
                }
                string address = textBoxAddress.Text;
                string position = textBoxPosition.Text;
                DB db = new DB();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `theater_worker` WHERE phone_number = @pN", db.getConnection());
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такой артист уже нанят");
                    return;
                }
                command = new MySqlCommand("INSERT INTO `theater_worker`(`full_name`, `position`, `phone_number`, `address`) VALUES (@fN, @p, @pN, @a)", db.getConnection());
                command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = fullName;
                command.Parameters.Add("@p", MySqlDbType.VarChar).Value = position;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                command.Parameters.Add("@a", MySqlDbType.VarChar).Value = address;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Артист нанят в театр");
                    textBoxFullName.Text = "";
                    textBoxAddress.Text = "";
                    textBoxPhoneNumber.Text = "";
                    textBoxPosition.Text = "";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить операцию найма позже");
                }
                db.closeConnection();
            }
            if (buttonDecision.Text == "Уволить")
            {
                DB db = new DB();
                Int32 id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand("SELECT id FROM `theater_worker` WHERE phone_number = @pN", db.getConnection());
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Такого актера нет в составе театра");
                    return;
                }
                db.openConnection();
                id = (Int32)command.ExecuteScalar();
                db.closeConnection();
                table = new DataTable();
                command = new MySqlCommand("SELECT * FROM `performance_theater_worker` WHERE id_theater_worker = @id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("На данный момент артист участвует в выступление и его нельзя уволить");
                    return;
                }
                command = new MySqlCommand("DELETE FROM `theater_worker` WHERE full_name = @fN AND phone_number = @pN", db.getConnection());
                command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = fullName;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Артист уволен из театра");
                    textBoxFullName.Text = "";
                    textBoxPhoneNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить операцию найма позже");
                }
                db.closeConnection();
            }
            if (buttonDecision.Text == "Добавить")
            {
                DB db = new DB();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `guest_artist` WHERE phone_number = @pN", db.getConnection());
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Такой артист уже добавлен");
                    return;
                }
                command = new MySqlCommand("INSERT INTO `guest_artist`(`full_name`, `phone_number`) VALUES (@fN, @pN)", db.getConnection());
                command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = fullName;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Артист добавлен в список");
                    textBoxFullName.Text = "";
                    textBoxPhoneNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить операцию найма позже");
                }
                db.closeConnection();
            }
            if (buttonDecision.Text == "Убрать")
            {
                DB db = new DB();
                Int32 id;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand("SELECT id FROM `guest_artist` WHERE phone_number = @pN", db.getConnection());
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Такого актера нет в списке");
                    return;
                }
                db.openConnection();
                id = (Int32)command.ExecuteScalar();
                db.closeConnection();
                table = new DataTable();
                command = new MySqlCommand("SELECT * FROM `performance_guest_artist` WHERE id_guest_artist = @id", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("На данный момент артист участвует в выступление и его нельзя убрать");
                    return;
                }
                command = new MySqlCommand("DELETE FROM `guest_artist` WHERE full_name = @fN AND phone_number = @pN", db.getConnection());
                command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = fullName;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Артист убран из списка");
                    textBoxFullName.Text = "";
                    textBoxPhoneNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить операцию найма позже");
                }
                db.closeConnection();
            }
        }
    }
}
