using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Radiator
{
    public partial class LoginSqlAdmin : MetroFramework.Forms.MetroForm
    {



        public LoginSqlAdmin()
        {
            InitializeComponent();
            label1.Text = "Для доступа к настройкам подключения к Базе данных  необходио войти под Администратором базы данных";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=" + txbx_server.Text.Trim() + "; user =" + txbx_login.Text.Trim() + ";Password=" + txbx_password.Text.Trim() + ";";
            if (txbx_login.Text != "" && txbx_password.Text !="" && txbx_server.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        SettingsConnect settings = new SettingsConnect();
                     
                        settings.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Неправильные данные. Проверьте");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Вы не заполнили все необходимые текстовые поля","Ошибка");
            }
        }
    }
}
