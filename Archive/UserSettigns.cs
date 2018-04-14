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
    public partial class UserSettigns : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();


        public UserSettigns()
        {
            InitializeComponent();
            dgv_users.DataSource = dal.GetAllUsers();
            try
            {

                dgv_users.Columns["id"].Visible = false;
            }
            catch
            {

            }
        }

        private void btn_addnewusers_Click(object sender, EventArgs e)
        {
            AddNewUser addNewUser = new AddNewUser();
            addNewUser.ShowDialog();
            dgv_users.DataSource = dal.GetAllUsers();
            try
            {

                dgv_users.Columns["id"].Visible = false;
            }
            catch
            {

            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
          DialogResult result =  MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить этого пользователя?", "Вопрос", MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                if (dal.Delete_User(dgv_users.CurrentRow.Cells[0].Value.ToString()))
                {
                   
                    dgv_users.DataSource = dal.GetAllUsers();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                }

            }
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            EditUser edit = new EditUser(dgv_users.CurrentRow.Cells[0].Value.ToString(), dgv_users.CurrentRow.Cells[1].Value.ToString(), dgv_users.CurrentRow.Cells[2].Value.ToString(), dgv_users.CurrentRow.Cells[3].Value.ToString());
            edit.ShowDialog();
            dgv_users.DataSource = dal.GetAllUsers();

        }
    }
}
