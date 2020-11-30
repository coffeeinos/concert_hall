using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concert_hall
{
    class checkAuthorization
    {
        public int checkLogPass(string userLogin, string userPass)
        {
            DB db = new DB();
            DataTable tabel = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE login = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
            adapter.SelectCommand = command;
            adapter.Fill(tabel);

            if (tabel.Rows.Count <= 0)
            {
                return 1;
            }
            else
            {
                tabel = new DataTable();
                command = new MySqlCommand("SELECT * FROM `admin` WHERE login = @uL AND pass = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLogin;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPass;
                adapter.SelectCommand = command;
                adapter.Fill(tabel);
                
                if (tabel.Rows.Count > 0)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }

        }
    }
}
