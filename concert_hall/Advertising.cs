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
    public partial class Advertising : Form
    {
        public Advertising()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            comboBoxPerformance.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Advertising_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void textBoxCost_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "Введите стоимость рекламной компании")
            {
                textBoxCost.Text = "";
            }
        }

        private void textBoxCost_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "")
            {
                textBoxCost.Text = "Введите стоимость рекламной компании";
            }
        }

        private void textBoxPhoneNumber_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "Введите номер телефона")
            {
                textBoxPhoneNumber.Text = "";
            }
        }

        private void textBoxPhoneNumber_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPhoneNumber.Text == "")
            {
                textBoxPhoneNumber.Text = "Введите номер телефона";
            }
        }

        private void textBoxAddress_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "Введите адрес")
            {
                textBoxAddress.Text = "";
            }
        }

        private void textBoxAddress_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "")
            {
                textBoxAddress.Text = "Введите адрес";
            }
        }

        private void textBoxEmail_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Введите электронную почту")
            {
                textBoxEmail.Text = "";
            }
        }

        private void buttonShowAdvertisingCampaign_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Visible == true)
            {
                textBoxCost.Visible = false;
            }
            if (comboBoxPerformance.Visible == true)
            {
                comboBoxPerformance.Visible = false;
            }
            if (labelPrompt.Visible == true)
            {
                labelPrompt.Visible = false;
            }
            if (textBoxNameFirm.Visible == true)
            {
                textBoxNameFirm.Visible = false;
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (textBoxEmail.Visible == true)
            {
                textBoxEmail.Visible = false;
            }
            if (buttonAdd.Visible == true)
            {
                buttonAdd.Visible = false;
            }
            if (dataGridViewAdvertising.Visible == false)
            {
                dataGridViewAdvertising.Visible = true;
            }
            if (dataGridViewAdvertising.Columns[0].HeaderText == "Название фирмы")
            {
                dataGridViewAdvertising.Columns[0].HeaderText = "Название выступления";
            }
            if (dataGridViewAdvertising.Columns[1].HeaderText == "Номер телефона")
            {
                dataGridViewAdvertising.Columns[1].HeaderText = "Название фирмы";
            }
            if (dataGridViewAdvertising.Columns[2].HeaderText == "Адресс")
            {
                dataGridViewAdvertising.Columns[2].HeaderText = "Цена";
            }
            dataGridViewAdvertising.Rows.Clear();
            dataGridViewAdvertising.Visible = true;
            if (dataGridViewAdvertising.Columns["phoneNumber"].Visible == true)
            {
                dataGridViewAdvertising.Columns["phoneNumber"].Visible = false;
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT performance.name, marketing_firm.name, advertising_campaign.cost FROM advertising_campaign INNER JOIN performance ON advertising_campaign.id_performance = performance.id INNER JOIN marketing_firm ON advertising_campaign.id_marketing_firm = marketing_firm.id", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewAdvertising.Columns.Count-1]);
                for (int i = 0; i < (dataGridViewAdvertising.Columns.Count-1); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewAdvertising.Rows.Add(s);
            }
        }

        private void buttonShowMarketingFirm_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Visible == true)
            {
                textBoxCost.Visible = false;
            }
            if (comboBoxPerformance.Visible == true)
            {
                comboBoxPerformance.Visible = false;
            }
            if (labelPrompt.Visible == true)
            {
                labelPrompt.Visible = false;
            }
            if (textBoxNameFirm.Visible == true)
            {
                textBoxNameFirm.Visible = false;
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (textBoxEmail.Visible == true)
            {
                textBoxEmail.Visible = false;
            }
            if (buttonAdd.Visible == true)
            {
                buttonAdd.Visible = false;
            }
            dataGridViewAdvertising.Rows.Clear();
            if (dataGridViewAdvertising.Visible == false)
            {
                dataGridViewAdvertising.Visible = true;
            }
            if (dataGridViewAdvertising.Columns["phoneNumber"].Visible == false)
            {
                dataGridViewAdvertising.Columns["phoneNumber"].Visible = true;
            }
            if(dataGridViewAdvertising.Columns[0].HeaderText == "Название выступления")
            {
                dataGridViewAdvertising.Columns[0].HeaderText = "Название фирмы";
            }
            if (dataGridViewAdvertising.Columns[1].HeaderText == "Название фирмы")
            {
                dataGridViewAdvertising.Columns[1].HeaderText = "Номер телефона";
            }
            if (dataGridViewAdvertising.Columns[2].HeaderText == "Цена")
            {
                dataGridViewAdvertising.Columns[2].HeaderText = "Адресс";
            }
            if (dataGridViewAdvertising.Columns[3].HeaderText == "Номер телефона")
            {
                dataGridViewAdvertising.Columns[3].HeaderText = "Электронная почта";
            }

            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT name, phone_number, address, email FROM `marketing_firm`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[dataGridViewAdvertising.Columns.Count]);
                for (int i = 0; i < (dataGridViewAdvertising.Columns.Count); i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            db.closeConnection();

            foreach (string[] s in data)
            {
                dataGridViewAdvertising.Rows.Add(s);
            }
        }

        private void buttonAddMarketingFirm_Click(object sender, EventArgs e)
        {
            buttonAdd.Text = "Добавить маркетинговую фирму";
            textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
            textBoxPhoneNumber.Text = "Введите номер телефона";
            textBoxAddress.Text = "Введите адрес";
            textBoxEmail.Text = "Введите электронную почту";
            if (textBoxCost.Visible == true)
            {
                textBoxCost.Visible = false;
            }
            if (comboBoxPerformance.Visible == true)
            {
                comboBoxPerformance.Visible = false;
            }
            if (labelPrompt.Visible == true)
            {
                labelPrompt.Visible = false;
            }
            if (textBoxNameFirm.Visible == false)
            {
                textBoxNameFirm.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == false)
            {
                textBoxPhoneNumber.Visible = true;
            }
            if (textBoxAddress.Visible == false)
            {
                textBoxAddress.Visible = true;
            }
            if (textBoxEmail.Visible == false)
            {
                textBoxEmail.Visible = true;
            }
            if (buttonAdd.Visible == false)
            {
                buttonAdd.Visible = true;
            }
            if (dataGridViewAdvertising.Visible == true)
            {
                dataGridViewAdvertising.Visible = false;
            }
        }

        private void textBoxEmail_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Введите электронную почту";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameFirm.Text == "Введите название маркетинговой фирмы")
            {
                MessageBox.Show("Введите название маркетинговой фирмы");
                return;
            }
            string nameFirm = textBoxNameFirm.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;
            if (buttonAdd.Text == "Добавить маркетинговую фирму")
            {
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE name = @n", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameFirm;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с таким название уже внесена");
                    return;
                }
                if (textBoxPhoneNumber.Text == "Введите номер телефона")
                {
                    MessageBox.Show("Введите номер телефона");
                    return;
                }
                string phoneNymber = textBoxPhoneNumber.Text;
                db = new DB();
                table = new DataTable();
                adapter = new MySqlDataAdapter();
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE phone_number = @pN", db.getConnection());
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNymber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с таким номером телефона уже внесена");
                    return;
                }
                if (textBoxAddress.Text == "Введите адрес")
                {
                    MessageBox.Show("Введите адрес");
                    return;
                }
                string address = textBoxAddress.Text;
                db = new DB();
                table = new DataTable();
                adapter = new MySqlDataAdapter();
                db.openConnection();
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE address = @a", db.getConnection());
                command.Parameters.Add("@a", MySqlDbType.VarChar).Value = address;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с таким адресом уже внесена");
                    return;
                }
                if (textBoxEmail.Text == "Введите электронную почту")
                {
                    MessageBox.Show("Введите электронную почту");
                    return;
                }
                string email = textBoxEmail.Text;
                db = new DB();
                table = new DataTable();
                adapter = new MySqlDataAdapter();
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE email = @e", db.getConnection());
                command.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с такой электронной почтой уже внесена");
                    return;
                }
                command = new MySqlCommand("INSERT INTO `marketing_firm`(`name`, `phone_number`, `address`, `email`) VALUES (@n, @pN, @a, @e)", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameFirm;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNymber;
                command.Parameters.Add("@a", MySqlDbType.VarChar).Value = address;
                command.Parameters.Add("@e", MySqlDbType.VarChar).Value = email;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Маркетинговая фирма добавлена");
                    textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
                    textBoxPhoneNumber.Text = "Введите номер телефона";
                    textBoxAddress.Text = "Введите адрес";
                    textBoxEmail.Text = "Введите электронную почту";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
                }
                db.closeConnection();
            }
            if (buttonAdd.Text == "Убрать маркетинговую фирму")
            {
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE name = @n", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameFirm;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с таким название не существует");
                    return;
                }
                if (textBoxPhoneNumber.Text == "Введите номер телефона")
                {
                    MessageBox.Show("Введите номер телефона");
                    return;
                }
                string phoneNymber = textBoxPhoneNumber.Text;
                db = new DB();
                table = new DataTable();
                adapter = new MySqlDataAdapter();
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE phone_number = @pN", db.getConnection());
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNymber;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с таким номером телефона не существует");
                    return;
                }
                command = new MySqlCommand("DELETE FROM `marketing_firm` WHERE name = @n AND phone_number = @pN", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameFirm;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = phoneNymber;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Маркетинговая фирма была убрана");
                    textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
                    textBoxPhoneNumber.Text = "Введите номер телефона";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
                }
                db.closeConnection();
            }
            if (buttonAdd.Text == "Добавить рекламную компанию")
            {
                if (textBoxCost.Text == "Введите стоимость рекламной компании")
                {
                    MessageBox.Show("Введите стоимость рекламной компании");
                    return;
                }
                if (comboBoxPerformance.Text == "")
                {
                    MessageBox.Show("Выберите выступление");
                    return;
                }
                command = new MySqlCommand("SELECT * FROM marketing_firm WHERE name = @n", db.getConnection());
                command.Parameters.Add("@n", MySqlDbType.VarChar).Value = nameFirm;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Маркетинговой фирмы с таким название не существует");
                    return;
                }
                string namePerformance = comboBoxPerformance.Text;
                double cost = double.Parse(textBoxCost.Text.Replace(".", ","));
                command = new MySqlCommand("INSERT INTO `advertising_campaign`(`id_performance`, `id_marketing_firm`, `cost`) VALUES ((SELECT id FROM performance WHERE name = @nP),(SELECT id FROM marketing_firm WHERE name = @nF), @c)", db.getConnection());
                command.Parameters.Add("@nF", MySqlDbType.VarChar).Value = nameFirm;
                command.Parameters.Add("@nP", MySqlDbType.VarChar).Value = namePerformance;
                command.Parameters.Add("@c", MySqlDbType.Float).Value = cost;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Рекламная компания создана");
                    textBoxCost.Text = "Введите стоимость рекламной компании";
                    comboBoxPerformance.Items.Clear();
                    textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
                }
                db.closeConnection();
            }
            if (buttonAdd.Text == "Убрать рекламную компанию")
            {
                if (comboBoxPerformance.Text == "")
                {
                    MessageBox.Show("Выберите выступление");
                    return;
                }
                string namePerformance = comboBoxPerformance.Text;
                command = new MySqlCommand("DELETE FROM `advertising_campaign` WHERE id_performance = (SELECT id FROM performance WHERE name = @nP) AND id_marketing_firm = (SELECT id FROM marketing_firm WHERE name = @nF)", db.getConnection());
                command.Parameters.Add("@nF", MySqlDbType.VarChar).Value = nameFirm;
                command.Parameters.Add("@nP", MySqlDbType.VarChar).Value = namePerformance;
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Рекламная компания удалена");
                    comboBoxPerformance.Items.Clear();
                    textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
                }
                else
                {
                    MessageBox.Show("Возникла ошибка. Попробуйте повторить позже");
                }
                db.closeConnection();
            }
        }

        private void buttonAddAdvertisingCampaign_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNameFirm_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxNameFirm.Text == "Введите название маркетинговой фирмы")
            {
                textBoxNameFirm.Text = "";
            }
        }

        private void textBoxNameFirm_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxNameFirm.Text == "")
            {
                textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
            }
        }

        private void buttonAddAdvertisingCampaign_Click_1(object sender, EventArgs e)
        {
            buttonAdd.Text = "Добавить рекламную компанию";
            textBoxCost.Text = "Введите стоимость рекламной компании";
            comboBoxPerformance.Items.Clear();
            textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
            if (textBoxCost.Visible == false)
            {
                textBoxCost.Visible = true;
            }
            if (comboBoxPerformance.Visible == false)
            {
                comboBoxPerformance.Visible = true;
            }
            if (labelPrompt.Visible == false)
            {
                labelPrompt.Visible = true;
            }
            if (textBoxNameFirm.Visible == false)
            {
                textBoxNameFirm.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (textBoxEmail.Visible == true)
            {
                textBoxEmail.Visible = false;
            }
            if (buttonAdd.Visible == false)
            {
                buttonAdd.Visible = true;
            }
            if (dataGridViewAdvertising.Visible == true)
            {
                dataGridViewAdvertising.Visible = false;
            }
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT MIN(id) FROM performance", db.getConnection());
            Int32 resultMinimum = (Int32)command.ExecuteScalar();
            command = new MySqlCommand("SELECT MAX(id) FROM performance", db.getConnection());
            Int32 resultMaximum = (Int32)command.ExecuteScalar();
            for (int i = resultMinimum; i <= resultMaximum; i++)
            {
                command = new MySqlCommand("SELECT name FROM `performance` WHERE id = @I", db.getConnection());
                command.Parameters.Add("@I", MySqlDbType.Int32).Value = i;
                comboBoxPerformance.Items.Add(command.ExecuteScalar().ToString());
            }
            db.closeConnection();
        }

        private void buttonDeletMarketingFirm_Click(object sender, EventArgs e)
        {
            buttonAdd.Text = "Убрать маркетинговую фирму";
            textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
            textBoxPhoneNumber.Text = "Введите номер телефона";
            if (textBoxCost.Visible == true)
            {
                textBoxCost.Visible = false;
            }
            if (comboBoxPerformance.Visible == true)
            {
                comboBoxPerformance.Visible = false;
            }
            if (labelPrompt.Visible == true)
            {
                labelPrompt.Visible = false;
            }
            if (textBoxNameFirm.Visible == false)
            {
                textBoxNameFirm.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == false)
            {
                textBoxPhoneNumber.Visible = true;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (textBoxEmail.Visible == true)
            {
                textBoxEmail.Visible = false;
            }
            if (buttonAdd.Visible == false)
            {
                buttonAdd.Visible = true;
            }
            if (dataGridViewAdvertising.Visible == true)
            {
                dataGridViewAdvertising.Visible = false;
            }
        }

        private void buttonDeletAdvertisingCampaign_Click(object sender, EventArgs e)
        {
            buttonAdd.Text = "Убрать рекламную компанию";
            textBoxNameFirm.Text = "Введите название маркетинговой фирмы";
            comboBoxPerformance.Items.Clear();
            if (textBoxCost.Visible == true)
            {
                textBoxCost.Visible = false;
            }
            if (comboBoxPerformance.Visible == false)
            {
                comboBoxPerformance.Visible = true;
            }
            if (labelPrompt.Visible == false)
            {
                labelPrompt.Visible = true;
            }
            if (textBoxNameFirm.Visible == false)
            {
                textBoxNameFirm.Visible = true;
            }
            if (textBoxPhoneNumber.Visible == true)
            {
                textBoxPhoneNumber.Visible = false;
            }
            if (textBoxAddress.Visible == true)
            {
                textBoxAddress.Visible = false;
            }
            if (textBoxEmail.Visible == true)
            {
                textBoxEmail.Visible = false;
            }
            if (buttonAdd.Visible == false)
            {
                buttonAdd.Visible = true;
            }
            if (dataGridViewAdvertising.Visible == true)
            {
                dataGridViewAdvertising.Visible = false;
            }
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT MIN(id) FROM performance", db.getConnection());
            Int32 resultMinimum = (Int32)command.ExecuteScalar();
            command = new MySqlCommand("SELECT MAX(id) FROM performance", db.getConnection());
            Int32 resultMaximum = (Int32)command.ExecuteScalar();
            for (int i = resultMinimum; i <= resultMaximum; i++)
            {
                command = new MySqlCommand("SELECT name FROM `performance` WHERE id = @I", db.getConnection());
                command.Parameters.Add("@I", MySqlDbType.Int32).Value = i;
                comboBoxPerformance.Items.Add(command.ExecuteScalar().ToString());
            }
            db.closeConnection();
        }
    }
}
