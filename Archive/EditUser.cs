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
    public partial class EditUser : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        private string idUser = null;
  
        public EditUser(string UserId,string login,string password,string role)
        {
            InitializeComponent();
            cmb_role.DataSource = dal.GetAllRole();
            cmb_role.DisplayMember = "Name";
            cmb_role.ValueMember = "id";
            txbx_loginUser.Text = login;
            txbx_password.Text = password;
            cmb_role.SelectedValue = dal.idRole(UserId);
            idUser = UserId;
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {

            if (txbx_loginUser.Text != "" && txbx_password.Text != "")
            {
                if (dal.Edit_User(idUser, txbx_loginUser.Text.Trim(), txbx_password.Text.Trim(), cmb_role.SelectedValue.ToString()))
                {

                    MetroFramework.MetroMessageBox.Show(this, "Пользователь успешно измененён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, заполните все текстовые поля", "Ошибка");
            }
        }
    }
}
