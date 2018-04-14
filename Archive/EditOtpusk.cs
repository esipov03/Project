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
    public partial class EditOtpusk : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        private string id1 = null;
        public EditOtpusk(string idOtpusk,string Reason,DateTime start,DateTime end,string CountDay)
        {
            InitializeComponent();
            id1 = idOtpusk;
            txbx_CountDay.Text = CountDay;
            dateTimePicker_S.Value = start;
            dateTimePicker_Po.Value = end;
            cb_Prich.DataSource = dal.GetAllPrichin();
            cb_Prich.ValueMember = "id";
            cb_Prich.DisplayMember = "Наименование";
            cb_Prich.SelectedValue = dal.idReason(idOtpusk);
        }

        private void bnt_EditOtpusk_Click(object sender, EventArgs e)
        {
            if(dal.Edit_Otpusk(id1,cb_Prich.SelectedValue.ToString(),dateTimePicker_S.Value,dateTimePicker_Po.Value,txbx_CountDay.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Информация о отпуске успешно изменена", "успешно",MessageBoxButtons.OK,MessageBoxIcon.Question);
                this.Close();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "успешно");
                
            }
        }

        private void dateTimePicker_S_ValueChanged(object sender, EventArgs e)
        {
            txbx_CountDay.Text = dal.DateDiff(dateTimePicker_S.Value, dateTimePicker_Po.Value).ToString();
        }

        private void dateTimePicker_Po_ValueChanged(object sender, EventArgs e)
        {
            txbx_CountDay.Text = dal.DateDiff(dateTimePicker_S.Value, dateTimePicker_Po.Value).ToString();
        }
    }
}
