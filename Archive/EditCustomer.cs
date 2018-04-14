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
    public partial class EditCustomer : MetroFramework.Forms.MetroForm
    {
        private string id1 = null;
        DAL dal = new DAL();
        public EditCustomer(string id,string LastName,string FirstName,string Patronymic,DateTime Birthday)
        {
            InitializeComponent();
            txbx_editUserLastName.Text = LastName;
            txbx_editUserPatronimyc.Text = Patronymic;
            txbx_editUserFirstname.Text = FirstName;
            dtm_Happy.Value = Birthday;
            id1 = id;
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            if(txbx_editUserFirstname.Text!=""&& txbx_editUserLastName.Text!=""&&txbx_editUserPatronimyc.Text!="")
            {
               if( dal.Edit_Customer(txbx_editUserLastName.Text.Trim(), txbx_editUserFirstname.Text.Trim(), txbx_editUserPatronimyc.Text.Trim(), dtm_Happy.Value, id1))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Данные о сотруднике успешно обновлены", "Успешно",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    this.Close();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Возникла ошибка", "Ошибка");
                }

            }

            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, заполините все текстовые поля!", "Ошибка");

            }
        }
    }
}
