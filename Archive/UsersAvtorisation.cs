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
using System.Runtime.InteropServices;


namespace Radiator
{
    
    public partial class UsersAvtorisation : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public UsersAvtorisation()
        {
            InitializeComponent();
            //this.KeyPreview = true;
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UsersAvtorisation_KeyUp);
            //this.btn_Vxod.Click += new System.EventHandler(this.btn_Vxod_Click);
        }

        private void btn_Vxod_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(dal.connectionString);
                SqlDataAdapter sda = new SqlDataAdapter("Select Role.Name from Users inner join Role on Role.id=Users.Role Where Login='" + txbx_login.Text.Trim() + "'and Password='" + txbx_password.Text.Trim() + " '", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    this.Hide();
                    HomeForm m = new HomeForm(dt.Rows[0][0].ToString());
                    m.Show();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Проверьте правильность ввёднных вами данных", "Ошибка");
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка");

            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UsersAvtorisation_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    btn_Vxod.PerformClick();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_password_OnValueChanged(object sender, EventArgs e)
        {
            txbx_password.isPassword = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }

        private void UsersAvtorisation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            LoginSqlAdmin loginSqlAdmin = new LoginSqlAdmin();          
            loginSqlAdmin.ShowDialog();
           
        }
    }
}
