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
    public partial class AddNewZp : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        private string id1 = null;
        public AddNewZp(string id)
        {
            InitializeComponent();
            id1 = id;
         
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txbx_Summ.Text=="")

                {
                    MetroFramework.MetroMessageBox.Show(this, "Введите сумму зарплаты", "Ошибка");
                }
                else
                {
                    try
                    {

                    if(dal.SaveNewZP(id1, Convert.ToDecimal(txbx_Summ.Text.Replace('.',',')), dtm_DateZP.Value))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Зарплата для сотрудника успешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        txbx_Summ.Clear();

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
         
              
        

        private void txbx_SearchSortZP_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txbx_SearchSortZP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dgv_SotrudnikZP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void txbx_Summ_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
