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
    public partial class Administrators : Form
    {
        public Administrators()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            comboBoxFullName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNumberPhone.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Administrators_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buttonPerformance_Click(object sender, EventArgs e)
        {
            if(labelPrompt.Visible == true)
            {
                labelPrompt.Visible = false;
            }
            if (comboBoxFullName.Visible == true)
            {
                comboBoxFullName.Visible = false;
            }
            if (label2.Visible == true)
            {
                label2.Visible = false;
            }
            if (comboBoxNumberPhone.Visible == true)
            {
                comboBoxNumberPhone.Visible = false;
            }
            if (buttonDelet.Visible == true)
            {
                buttonDelet.Visible = false;
            }
            if (dataGridViewAdmin.Visible == false)
            {
                dataGridViewAdmin.Visible = true;
            }
            dataGridViewAdmin.Rows.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT `full_name`, `phone_number`, `email` FROM `admin`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewAdmin.Columns.Count]);
                for (int i = 0; i < dataGridViewAdmin.Columns.Count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewAdmin.Rows.Add(s);
            }
        }

        private void buttonDeletPerformance_Click(object sender, EventArgs e)
        {
            if (labelPrompt.Visible == false)
            {
                labelPrompt.Visible = true;
            }
            if (comboBoxFullName.Visible == false)
            {
                comboBoxFullName.Visible = true;
            }
            if (label2.Visible == true)
            {
                label2.Visible = false;
            }
            if (comboBoxNumberPhone.Visible == true)
            {
                comboBoxNumberPhone.Visible = false;
            }
            if (buttonDelet.Visible == false)
            {
                buttonDelet.Visible = true;
            }
            if (dataGridViewAdmin.Visible == true)
            {
                dataGridViewAdmin.Visible = false;
            }
            comboBoxNumberPhone.Items.Clear();
            comboBoxFullName.Items.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT MIN(id) FROM admin", db.getConnection());
            Int32 resultMinimum = (Int32)command.ExecuteScalar();
            command = new MySqlCommand("SELECT MAX(id) FROM admin", db.getConnection());
            Int32 resultMaximum = (Int32)command.ExecuteScalar();
            for (int i = resultMinimum; i <= resultMaximum; i++)
            {
                command = new MySqlCommand("SELECT full_name FROM `admin` WHERE id = @I", db.getConnection());
                command.Parameters.Add("@I", MySqlDbType.Int32).Value = i;
                comboBoxFullName.Items.Add(command.ExecuteScalar().ToString());
            }
            db.closeConnection();
        }

        private void comboBoxFullName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNumberPhone.Visible == true)
            {
                comboBoxNumberPhone.Visible = false;
                comboBoxNumberPhone.Items.Clear();
            }
            DB db = new DB();
            string fullName = comboBoxFullName.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT phone_number FROM admin WHERE full_name = @fN", db.getConnection());
            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = fullName;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                comboBoxNumberPhone.Items.Add(table.Rows[i]["phone_number"]);
                label2.Visible = true;
                comboBoxNumberPhone.Visible = true;
            }
            db.closeConnection();
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            string fullName = comboBoxFullName.Text;
            string phoneNumber = comboBoxNumberPhone.Text;
            db.openConnection();
            MySqlCommand command = new MySqlCommand("DELETE FROM `admin` WHERE full_name = @n AND phone_number = @pN", db.getConnection());
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = fullName;
            command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNumber;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Администратор удален");
                comboBoxNumberPhone.Items.Clear();
                comboBoxNumberPhone.Visible = false;
                comboBoxNumberPhone.Enabled = true;
                label2.Visible = false;
                comboBoxFullName.Enabled = true;
                db = new DB();
                db.openConnection();
                command = new MySqlCommand("SELECT MIN(id) FROM admin", db.getConnection());
                Int32 resultMinimum = (Int32)command.ExecuteScalar();
                command = new MySqlCommand("SELECT MAX(id) FROM admin", db.getConnection());
                Int32 resultMaximum = (Int32)command.ExecuteScalar();
                for (int i = resultMinimum; i <= resultMaximum; i++)
                {
                    command = new MySqlCommand("SELECT full_name FROM `admin` WHERE id = @I", db.getConnection());
                    command.Parameters.Add("@I", MySqlDbType.Int32).Value = i;
                    comboBoxFullName.Items.Add(command.ExecuteScalar().ToString());
                }
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
            }
            db.closeConnection();
        }

        private void comboBoxNumberPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFullName.Enabled = false;
            comboBoxNumberPhone.Enabled = false;
            buttonDelet.Visible = true;
        }
    }
}
