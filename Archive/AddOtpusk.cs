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
    
    public partial class AddOtpusk : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        private string id1 = null;
        public AddOtpusk(string id)
        {
            InitializeComponent();                  
            cb_Prich.DataSource = dal.GetAllPrichin();
            cb_Prich.ValueMember = "id";
            cb_Prich.DisplayMember = "Наименование";
            id1 = id;
           
        }

        private void bnt_SaveOtpusk_Click(object sender, EventArgs e)
        {
          
                if (txbx_CountDay.Text != "")
                {

                    if (dal.SaveNewOtpusk(Int32.Parse(cb_Prich.SelectedValue.ToString()), dateTimePicker_S.Value, dateTimePicker_Po.Value, Int32.Parse(txbx_CountDay.Text), id1))
                    {

                    MetroFramework.MetroMessageBox.Show(this, "Отпуск успешно внесён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                    else
                    {
                    MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, заполните все поля", "Ошибка", MessageBoxButtons.OK);
                }
           



        }

        private void dateTimePicker_S_ValueChanged(object sender, EventArgs e)
        {
            txbx_CountDay.Text = dal.DateDiff(dateTimePicker_S.Value, dateTimePicker_Po.Value).ToString();
        }

        private void dateTimePicker_S_ClientSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker_Po_ClientSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker_S_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void dateTimePicker_Po_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txbx_CountDay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbx_SearchOtpusk_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txbx_SearchOtpusk_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                

            
        }

        private void txbx_SearchOtpusk_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Otpusk_Load(object sender, EventArgs e)
        {
          
        }

        private void txbx_AddZP_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker_Po_ValueChanged(object sender, EventArgs e)
        {
            txbx_CountDay.Text = dal.DateDiff(dateTimePicker_S.Value, dateTimePicker_Po.Value).ToString();
        }

        private void dgv_SotrOtpusk_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void txbx_CountDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
