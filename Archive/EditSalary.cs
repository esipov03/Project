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
    public partial class EditSalary : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        private string id1 = null;
        private string idCustomer1 = null;
        public EditSalary(string id, string summa, DateTime date, string idCustmomer)
        {
            InitializeComponent();
            txbx_Summ.Text = summa;
            dtm_DateZP.Value = date;
            id1 = id;
            idCustomer1 = idCustmomer;



        }

        private void btn_editSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbx_Summ.Text != "")
                {

                    if (dal.Edit_Salary(idCustomer1, id1, decimal.Parse(txbx_Summ.Text.Trim().Replace('.', ',')), dtm_DateZP.Value))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Данные о зарплата успешно изменены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        this.Close();
                    }



                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                    }
                }



                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, заполните все поля", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txbx_Summ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_Summ_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (e.KeyChar == '.')
                e.KeyChar = ','; //замена точки на запятую
            if (!Char.IsDigit(ch) && e.KeyChar != 8)
            {
                if (e.KeyChar == ',')
                {
                    if (((sender as TextBox).Text.IndexOf(',') != -1) //запятая уже есть
                        || (sender as TextBox).Text.Length == 0) //число не введено
                        e.Handled = true;
                    return;

                }
                e.Handled = true;
            }
        }
    }

}
