using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiator
{
    public partial class Salary : MetroFramework.Forms.MetroForm
    {
        DAL dal = new DAL();
        private string buf = null;
        object metka;
        public Salary(string str,string role)
        {
            InitializeComponent();
            if (role == "Viewer")
            {
               btn_add_salary.Enabled = false;
                btn_delete_salary.Enabled = false;
                btn_edit_Salary.Enabled = false;
            }

            if (role == "User")
            {
                btn_delete_salary.Enabled = false;
            }
            buf = str;
            dgv_SearchZP.DataSource = dal.ZPSearch(str);
            dgv_SearchZP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewRow row = dgv_SearchZP.RowTemplate;
            row.Height = 40;
            Summa.Text = string.Format("Сумма за {0} год составляет {1} рублей", txbx_ZP.Text, 0);
            try
            {
                dgv_SearchZP.Columns[0].Visible = false;
            }
            catch
            {

            }

            //if (dgv_SearchZP.Rows.Count == 0)
            //{
              
            //    btn_delete_salary.Enabled = false;
            //    btn_edit_Salary.Enabled = false;
            //}
        }
        
        private void SearchZP_Load(object sender, EventArgs e)
        {
            dgv_SearchZP.AutoResizeColumns();
            

        }

        private void txbx_ZP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Summa.Text = string.Format("Сумма за {0} год составляет {1} рублей", txbx_ZP.Text, dal.SummaZP(buf, txbx_ZP.Text).ToString());
                
            }
            catch
            {

            }
           
            dgv_SearchZP.DataSource = dal.ZpFromYear(txbx_ZP.Text,buf);
            try
            {
                dgv_SearchZP.Columns[0].Visible = false;
            }
            catch
            {

            }
            if (txbx_ZP.Text == "")
            {
                dgv_SearchZP.DataSource = dal.ZPSearch(buf);
                try
                {
                    dgv_SearchZP.Columns[0].Visible = false;
                }
                catch
                {

                }
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
                
            }

        private void txbx_ZP_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txbx_ZP_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_add_salary_Click(object sender, EventArgs e)
        {

            AddNewZp newZP = new AddNewZp(buf);
            newZP.ShowDialog();
            dgv_SearchZP.DataSource = dal.ZPSearch(buf);
            try
            {
                dgv_SearchZP.Columns[0].Visible = false;
            }
            catch
            {

            }
        }

        private void btn_edit_Salary_Click(object sender, EventArgs e)
        {



            if (dgv_SearchZP.CurrentRow != null)
            {
                EditSalary editSalary = new EditSalary(dgv_SearchZP.CurrentRow.Cells[0].Value.ToString(), dgv_SearchZP.CurrentRow.Cells[1].Value.ToString(), Convert.ToDateTime(dgv_SearchZP.CurrentRow.Cells[2].Value), buf);
                editSalary.ShowDialog();
                dgv_SearchZP.DataSource = dal.ZPSearch(buf);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите запись в таблице", "Ошибка");
            }
          



            
        }

        private void btn_delete_salary_Click(object sender, EventArgs e)
        {
            if (dgv_SearchZP.CurrentRow != null)
            {
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить данную запись о зарплате?", "Удаление", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (dal.DeleteSalary(dgv_SearchZP.CurrentRow.Cells[0].Value.ToString()))
                    {
                        dgv_SearchZP.DataSource = dal.ZPSearch(buf);
                    }

                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Удаление");
                    }
                }
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите запись в таблице", "Ошибка");
            }


        }

            private void dgv_SearchZP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgv_SearchZP.CurrentCell.RowIndex;
            dgv_SearchZP.Rows[index].Selected = true;
        }

        private void dgv_SearchZP_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow dataGridViewRow1 = dgv_SearchZP.Rows[e.RowIndex];
            contextMenuStrip1.Visible = true;
            metka = dgv_SearchZP.CurrentRow.Cells[3].Value;

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

        private void dgv_SearchZP_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
               dgv_SearchZP.CurrentCell = dgv_SearchZP[e.ColumnIndex, e.RowIndex];
                dgv_SearchZP.CurrentRow.Selected = true;
            }
        }

        private void отметитьНаУдалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgv_SearchZP.CurrentRow.Index;
            if (dal.MetkaDeleteFromSalary(dgv_SearchZP.CurrentRow.Cells[0].Value.ToString(), Convert.ToBoolean(metka)))
            {


                DataGridViewCellStyle rowRed = new DataGridViewCellStyle();
                rowRed.BackColor = Color.Red;
                dgv_SearchZP.Rows[index].DefaultCellStyle = rowRed;
                //dgv_Customers.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {


                DataGridViewCellStyle rowWhite = new DataGridViewCellStyle();
                rowWhite.BackColor = Color.White;
                dgv_SearchZP.Rows[index].DefaultCellStyle = rowWhite;
                // dgv_Customers.Rows[index].InheritedStyle.BackColor = Color.Red;
            }
            dgv_SearchZP.DataSource = dal.ZPSearch(buf);
        }

        private void ckeck_Metka_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Metka.Checked)
            {
               dgv_SearchZP.DataSource = dal.getMetkaFromSalary(buf);
                if (dgv_SearchZP.Rows.Count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не найдено", "Ошибка");
                    check_Metka.Checked = false;
                }
            }
            else

            if (check_Metka.Checked == false)
            {
                dgv_SearchZP.DataSource = dal.ZPSearch(buf);
                try
                {
                    dgv_SearchZP.Columns[0].Visible = false;
                }
                catch
                {

                }
            }
        }
    }
}
