using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiator
{
    public partial class AddNewUser : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        public AddNewUser()
        {
            InitializeComponent();
            cmb_role.DataSource = dal.GetAllRole();
            cmb_role.DisplayMember = "Name";
            cmb_role.ValueMember = "id";
            
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            if (txbx_loginUser.Text != "" && txbx_password.Text != "")
            {
                if (dal.Insert_User(txbx_loginUser.Text.Trim(), txbx_password.Text.Trim(), cmb_role.SelectedValue.ToString()))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Новый пользователь успешно добален.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Произошка ошибка", "Ошибка");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожайлуйста, заполните все текстовые поля", "Ошибка");
            }
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
