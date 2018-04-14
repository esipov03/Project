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
    public partial class EditPersonalCard : MetroFramework.Forms.MetroForm
    {
        private string id1 = null;
        DAL dal = new DAL();
        public EditPersonalCard(string id,string prikaz,DateTime data, string pod,string dol)
        {
            InitializeComponent();
            txbx_Prikazn.Text = prikaz;
            dtp_prik.Value = data;
            cbx_deistv.DataSource = dal.GetAllDeistv();
            cbx_deistv.DisplayMember = "Наименование ";
            cbx_deistv.ValueMember = "id";
            cbx_deistv.SelectedValue = dal.idPDeistv(id);
            txbx_Pod.Text = pod;
            id1 = id;
            txbx_Dol.Text = dol;
        }

        private void btn_AddNewJournal_Click(object sender, EventArgs e)
        {

            if (txbx_Pod.Text == "" || txbx_Dol.Text == "" || txbx_Prikazn.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "вы ввели не всю информацию", "Ошибка");

            }
            else
            {
                dal.EditPersonalCard(id1, cbx_deistv.SelectedValue.ToString(), txbx_Prikazn.Text.Trim(), dtp_prik.Value, txbx_Dol.Text.Trim(), txbx_Pod.Text.Trim());
               
                    
                    MetroFramework.MetroMessageBox.Show(this, "Запись в личной карточке успешно изменена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Close();
               


            }

        }

        private void EditPersonalCard_Load(object sender, EventArgs e)
        {
            dal.SerachDolTextBox(txbx_Dol);
            dal.SerachPodTextBox(txbx_Pod);
        }
    }
}
