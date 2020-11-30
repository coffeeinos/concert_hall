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
    public partial class Authorization : Form
    {
        int numberAttempts = 0;
        public Authorization()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            textBoxLogin.Text = "Введите ваш логин";
            textBoxPassword.Text = "Введите ваш пароль";
        }



        private void pictureBoxShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxShowPass.Image = Image.FromFile(@"E:\Учеба\5-тый семестр\Курсовая БД\concert hall\concert_hall\concert_hall\img\close_eye.png");
            if (textBoxPassword.Text != "Введите ваш пароль")
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            
        }

        private void pictureBoxShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxShowPass.Image = Image.FromFile(@"E:\Учеба\5-тый семестр\Курсовая БД\concert hall\concert_hall\concert_hall\img\open_eye.png");
            if (textBoxPassword.Text != "Введите ваш пароль")
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxLogin_MouseEnter(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == "Введите ваш логин")
            {
                textBoxLogin.Text = "";
            }
            
        }

        private void textBoxLogin_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text== "")
            {
                textBoxLogin.Text = "Введите ваш логин";
            }
        }

        private void textBoxPassword_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Введите ваш пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.Text = "Введите ваш пароль";
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "Введите ваш логин")
            {
                if (textBoxPassword.Text != "Введите ваш пароль")
                {
                    string userLogin = textBoxLogin.Text;
                    string userPass = textBoxPassword.Text;
                    checkAuthorization check = new checkAuthorization();
                    int result = check.checkLogPass(userLogin, userPass);
                    if (result == 0)
                    {
                        this.Hide();
                        Menu menu = new Menu();
                        menu.Show();
                    }
                    else if (result == 1)
                    {
                        MessageBox.Show("Пользователя с таким логином не найдено. Введите логин еще раз.");
                        if (numberAttempts >= 30)
                        {
                            buttonRecovery.Text = "Восстановление логина";
                            buttonRecovery.Enabled = true;
                            buttonRecovery.Visible = true;
                            numberAttempts = 0;
                        }
                        else if (numberAttempts <= 5)
                        {
                            numberAttempts = 0;
                        }
                        numberAttempts += 6;

                    }
                    else if (result == 2)
                    {
                        MessageBox.Show("Пароль введен неверно. Введите пароль еще раз.");
                        if (numberAttempts > 5)
                        {
                            numberAttempts = 0;
                        }
                        else if (numberAttempts == 5)
                        {
                            buttonRecovery.Text = "Восстановление пароля";
                            buttonRecovery.Enabled = true;
                            buttonRecovery.Visible = true;
                            numberAttempts = 0;
                        }
                        numberAttempts++;


                    }
                    else
                    {
                        MessageBox.Show("Возникла какая-то ошибка. Попробуйте авторизоваться позже.");
                    }
                }
                else 
                {
                    MessageBox.Show("Введите ваш пароль");
                }
            }
            else
            {
                MessageBox.Show("Введите ваш логин");
            }

        }

        private void buttonRecovery_Click(object sender, EventArgs e)
        {
            bool cause = false;
            if (buttonRecovery.Text == "Восстановление логина")
            {
                this.Hide();
                Recovery recovery = new Recovery(cause);
                recovery.Show();

            }
            else if (buttonRecovery.Text == "Восстановление пароля")
            {
                cause = true;
                this.Hide();
                Recovery recovery = new Recovery(cause, textBoxLogin.Text);
                recovery.Show();
            }
            else
            {
                MessageBox.Show("Возникла какая-то ошибка, пропробуйте позже");
            }
        }

        private void Authorization_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
