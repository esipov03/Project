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
    public partial class OtpuskSearch : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        PersonalCard s = new PersonalCard();
        private string buf = null;
        private object metka;


        public OtpuskSearch(string str,string role)
        {
            InitializeComponent();

            if (role == "Viewer")
            {
               btn_addOtpusk.Enabled = false;
               btn_editOtpusk.Enabled = false;
                btn_deleteOtpusk.Enabled = false;
            }

            if (role == "User")
            {
               btn_deleteOtpusk.Enabled = false;
            }
            dgv_otpuskSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_otpuskSearch.DataSource = dal.OtpuskSearch(str);
            DataGridViewRow row = dgv_otpuskSearch.RowTemplate;
            row.Height = 40;
            cb_Prich.DataSource = dal.GetAllPrichin();
            cb_Prich.ValueMember = "id";
            cb_Prich.DisplayMember = "Наименование";
            cb_Prich.SelectedValue = 0;
            buf = str;
            try
            {
                dgv_otpuskSearch.Columns["id"].Visible = false;
            }
            catch
            {

            }


        }

        private void OtpuskSearch_Load(object sender, EventArgs e)
        {

            dgv_otpuskSearch.AutoResizeColumns();
        }

        private void txbx_ZpYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_Prich_ValueMemberChanged(object sender, EventArgs e)
        {

        }

        private void cb_Prich_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void cb_Prich_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgv_otpuskSearch.DataSource = dal.Search_Reason(Int32.Parse(cb_Prich.SelectedValue.ToString()), buf);
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dgv_otpuskSearch.DataSource = dal.OtpuskSearch(buf);
            try
            {
                dgv_otpuskSearch.Columns["id"].Visible = false;
            }
            catch
            {

            }
        }

        private void btn_addOtpusk_Click(object sender, EventArgs e)
        {
            AddOtpusk addOtpusk = new AddOtpusk(buf);
            addOtpusk.ShowDialog();
            dgv_otpuskSearch.DataSource = dal.OtpuskSearch(buf);
            cb_Prich.SelectedValue = 0;
            try
            {
                dgv_otpuskSearch.Columns["id"].Visible = false;
            }
            catch
            {

            }


        }

        private void btn_editOtpusk_Click(object sender, EventArgs e)
        {
            if (dgv_otpuskSearch.CurrentRow != null)
            {
                EditOtpusk editOtpusk = new EditOtpusk(dgv_otpuskSearch.CurrentRow.Cells[0].Value.ToString(), dgv_otpuskSearch.CurrentRow.Cells[1].Value.ToString(), Convert.ToDateTime(dgv_otpuskSearch.CurrentRow.Cells[2].Value), Convert.ToDateTime(dgv_otpuskSearch.CurrentRow.Cells[3].Value), dgv_otpuskSearch.CurrentRow.Cells[4].Value.ToString());
                editOtpusk.ShowDialog();
                dgv_otpuskSearch.DataSource = dal.OtpuskSearch(buf);
                try
                {
                    dgv_otpuskSearch.Columns["id"].Visible = false;
                }
                catch
                {

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите запись в таблице", "Ошибка");
            }


        }

        private void btn_deleteOtpusk_Click(object sender, EventArgs e)
        {
            if (dgv_otpuskSearch.CurrentRow != null)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить отпуск?", "Удаление", MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                if (dal.Delete_Otpusk(dgv_otpuskSearch.CurrentRow.Cells[0].Value.ToString()))
                {
                    dgv_otpuskSearch.DataSource = dal.OtpuskSearch(buf);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка удаления", "Удаление");
                }
            }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите запись в таблице", "Ошибка");
            }
        }

        private void dgv_otpuskSearch_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow dataGridViewRow1 = dgv_otpuskSearch.Rows[e.RowIndex];
            contextMenuStrip1.Visible = true;
            metka = dgv_otpuskSearch.CurrentRow.Cells[5].Value;

            if (Convert.ToBoolean(metka) == true)

            {
                отметитьНаУдалениеToolStripMenuItem.Text = "Снять отметку";
                отметитьНаУдалениеToolStripMenuItem.Image = Properties.Resources.DELETE;
            }
            else
            {
                отметитьНаУдалениеToolStripMenuItem.Text = "Пометить на удаление";
                отметитьНаУдалениеToolStripMenuItem.Image = Properties.Resources.OK;
            }
        }

        private void отметитьНаУдалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgv_otpuskSearch.CurrentRow.Index;
            if (dal.MetkaDeleteFromOtpusk(dgv_otpuskSearch.CurrentRow.Cells[0].Value.ToString(), Convert.ToBoolean(metka)))
            {


                DataGridViewCellStyle rowRed = new DataGridViewCellStyle();
                rowRed.BackColor = Color.Red;
               dgv_otpuskSearch.Rows[index].DefaultCellStyle = rowRed;
                //dgv_Customers.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {


                DataGridViewCellStyle rowWhite = new DataGridViewCellStyle();
                rowWhite.BackColor = Color.White;
                dgv_otpuskSearch.Rows[index].DefaultCellStyle = rowWhite;
                // dgv_Customers.Rows[index].InheritedStyle.BackColor = Color.Red;
            }
            dgv_otpuskSearch.DataSource = dal.OtpuskSearch(buf);
        }

        private void dgv_otpuskSearch_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
               dgv_otpuskSearch.CurrentCell = dgv_otpuskSearch[e.ColumnIndex, e.RowIndex];
                dgv_otpuskSearch.CurrentRow.Selected = true;
            }
        }

        private void check_metka_CheckedChanged(object sender, EventArgs e)
        {

            if (check_metka.Checked)
            {
                dgv_otpuskSearch.DataSource = dal.getMetkaFromOtpusk(buf);
                if (dgv_otpuskSearch.Rows.Count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не найдено", "Ошибка");
                    check_metka.Checked = false;
                }
            }
            else

            if (check_metka.Checked == false)
            {
                dgv_otpuskSearch.DataSource = dal.OtpuskSearch(buf);
                try
                {
                    dgv_otpuskSearch.Columns[0].Visible = false;
                }
                catch
                {

                }
            }
        }
    }
}