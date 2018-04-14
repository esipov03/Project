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
    public partial class AddCustomers : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
       
        public AddCustomers()
        {
            InitializeComponent();


            
           
        }

        private void btn_SaveJournalFrom_Click(object sender, EventArgs e)
        {
          
                if (txbx_Family.Text == "" || txbx_Name.Text == "" || txbx_Otch.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Вы не внесли всю информацию", "Ошибка");
                }
                else
                {
                    if (dal.SaveNewSotrdunik(txbx_Family.Text.Trim(), txbx_Name.Text.Trim(), txbx_Otch.Text.Trim(), dateTimePicker_Besdey.Value))
                    {

                    MetroFramework.MetroMessageBox.Show(this, "Сотрудник добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txbx_Family.Text = "";
                    txbx_Name.Text = "";
                    txbx_Otch.Text = "";
                }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                    }
                }
            
            




        }
    }
}
