using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Radiator
{
    public partial class HomeForm : Form
    {
        DAL dal = new DAL();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private object metka;

        public HomeForm()
        {
            InitializeComponent();
            dgv_Customers.DataSource = dal.GetAllRabotnik();
            DataGridViewRow row = dgv_Customers.RowTemplate;
            row.Height = 40;
            try
            {
                dgv_Customers.Columns["id"].Visible = false;
            }
            catch
            {

            }
            dgv_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private string rol = null;
        public HomeForm(string str)
        {
            InitializeComponent();
            dgv_Customers.DataSource = dal.GetAllRabotnik();
            DataGridViewRow row = dgv_Customers.RowTemplate;
            dgv_Customers.ColumnHeadersHeight = 30;
            row.Height = 40;
           dgv_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                dgv_Customers.Columns["id"].Visible = false;
            }
            catch
            {

            }


            lbl_Role.Text = String.Format("Вы вошли как " + str);
            rol = str;
            if (str == "Viewer")
            {
                btn_add_Customers.Enabled = false;
                btn_EditCustomer.Enabled = false;
                btn_DeleteCustomer.Enabled = false;


            }
            else
            {

                if (str == "Admin")
                {
                    btn_user.Visible = true;


                }
                else {
                    btn_DeleteCustomer.Enabled = false;


                }


            }
        }



        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NewJournalFromName_Click(object sender, EventArgs e)
        {

        }

        private void btn_newJournal_Click(object sender, EventArgs e)
        {


        }

        private void добавитьОтпускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {
                OtpuskSearch otpusk = new OtpuskSearch(dgv_Customers.CurrentRow.Cells[0].Value.ToString(), rol);
                otpusk.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите работника", "Ошибка");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void добавитьЗарплатуToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void btn_SearchHome_Click(object sender, EventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NewPersonalCard newJournal = new NewPersonalCard(dgv_Customers.CurrentRow.Cells["id"].Value.ToString());
                newJournal.ShowDialog();

            }
            catch
            {

            }

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomers newSotr = new AddCustomers();
            newSotr.ShowDialog();
            dgv_Customers.DataSource = dal.GetAllRabotnik();
            try
            {
                dgv_Customers.Columns["id"].Visible = false;
            }
            catch
            {

            }

        }

        private void журналToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void HomeForm_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void lbl_Role_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {




            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tab_search_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            UserSettigns user = new UserSettigns();
            user.ShowDialog();
        }

        private void tb_Customers_Click(object sender, EventArgs e)
        {

        }

        private void btn_custmomerSearch_OnTextChange(object sender, EventArgs e)
        {
            dgv_Customers.DataSource = dal.SearchFromSotrudnik(txbx_custmerSearch.Text.Trim());
            try
            {
                dgv_Customers.Columns["id"].Visible = false;
            }
            catch
            {

            }
        }

        private void txbx_customer_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {
                EditCustomer edit = new EditCustomer(dgv_Customers.CurrentRow.Cells[0].Value.ToString(), dgv_Customers.CurrentRow.Cells[1].Value.ToString(), dgv_Customers.CurrentRow.Cells[2].Value.ToString(), dgv_Customers.CurrentRow.Cells[3].Value.ToString(), Convert.ToDateTime(dgv_Customers.CurrentRow.Cells[4].Value));
            edit.ShowDialog();
            dgv_Customers.DataSource = dal.GetAllRabotnik();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите работника", "Ошибка");

            }
        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {
                object NameCustomer = dal.GetNameCustomerMessageBox(dgv_Customers.CurrentRow.Cells[0].Value.ToString()).ToString();
                DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить " + NameCustomer + "? Вся информация о работнике также будет удалена!", "Удаление", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {

                    try
                    {

                        dal.DeleteCustomer(dgv_Customers.CurrentRow.Cells[0].Value.ToString());
                        if (!cbx_metka.Checked)
                        {
                            dgv_Customers.DataSource = dal.GetAllRabotnik();
                        }
                        else
                        {
                            dgv_Customers.DataSource = dal.getMetkaCustomer();
                        }
                    }

                    catch
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка", "Ошибка");
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите работника", "Ошибка");

            }

        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow!=null)
            {
                Salary zp = new Salary(dgv_Customers.CurrentRow.Cells[0].Value.ToString(), rol);
                zp.ShowDialog();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста,укажите работника", "Ошибка");
            }
        }

        private void add_Journal_Click(object sender, EventArgs e)
        {
            if (dgv_Customers.CurrentRow != null)
            {
                PersonalCard journal = new PersonalCard(dgv_Customers.CurrentRow.Cells[0].Value.ToString(), dgv_Customers.CurrentRow.Cells[1].Value.ToString(), dgv_Customers.CurrentRow.Cells[2].Value.ToString(), dgv_Customers.CurrentRow.Cells[3].Value.ToString(), dgv_Customers.CurrentRow.Cells[4].Value.ToString(), rol);
                journal.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста,укажите работника", "Ошибка");
            }

        }

        private void btn_Spravka_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_Customers_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow dataGridViewRow1 = dgv_Customers.Rows[e.RowIndex];
            contextMenuStrip1.Visible = true;
            metka = dgv_Customers.CurrentRow.Cells[5].Value;

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


    



        private void dgv_Customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_Customers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dgv_Customers.CurrentCell =dgv_Customers[e.ColumnIndex, e.RowIndex];
                dgv_Customers.CurrentRow.Selected = true;
            }
        }

        private void отметитьНаУдалениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgv_Customers.CurrentRow.Index;
           if( dal.MetkaDelete(dgv_Customers.CurrentRow.Cells[0].Value.ToString(), Convert.ToBoolean(metka)))
            {
              
               
                DataGridViewCellStyle rowRed = new DataGridViewCellStyle();
                rowRed.BackColor = Color.Red;
                dgv_Customers.Rows[index].DefaultCellStyle = rowRed;
                //dgv_Customers.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
               
           
                DataGridViewCellStyle rowWhite = new DataGridViewCellStyle();
                rowWhite.BackColor = Color.White;
                dgv_Customers.Rows[index].DefaultCellStyle = rowWhite;
                // dgv_Customers.Rows[index].InheritedStyle.BackColor = Color.Red;
            }
            dgv_Customers.DataSource = dal.GetAllRabotnik();

        }

        private void cbx_metka_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_metka.Checked)
            {
                dgv_Customers.DataSource = dal.getMetkaCustomer();
                if (dgv_Customers.Rows.Count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не найдено", "Ошибка");
                    cbx_metka.Checked = false;
                }
            }
            else 

            if(cbx_metka.Checked==false)
            {
                dgv_Customers.DataSource = dal.GetAllRabotnik();
                try
                {
                    dgv_Customers.Columns[0].Visible = false;
                }
                catch
                {

                }
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
    }
    

