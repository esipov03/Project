using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Collections;



namespace Radiator
{
    public partial class PersonalCard : MetroFramework.Forms.MetroForm
    {

        DAL dal = new DAL();
        private string id1 = null;
        HomeForm pis = new HomeForm();
        private object metka;
        string Birthday1 = null;

     private   string LastName1;
           private string FirstName1;
           private  string patronymic1;
        public PersonalCard()
        {
            InitializeComponent();
            //dgv_RezultSearch.DataSource = dal.SearchFromSotrudnik();     


        }
        public PersonalCard(string id, string LastName, string FirstName, string patronymic, string Birthday, string role)
        {
            InitializeComponent();
           dgv_dateEmlpoy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
          
            if (role == "Viewer")
            {
                btn_DeleteCard.Enabled = false;
                btn_EditCard.Enabled = false;
                btn_add_Card.Enabled = false;
            }

            if (role=="User")
            {
                btn_DeleteCard.Enabled = false;
            }
           dgv_Journal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LastName1 = LastName;
            FirstName1 = FirstName;
            patronymic1 = patronymic;
            Birthday1 = Birthday;
            dgv_dateEmlpoy.DataSource = dal.Get_Customer_Dol_Date(id);
            DataGridViewRow pis = dgv_Journal.RowTemplate;
            pis.Height = 40;
            dgv_Journal.DataSource = dal.JournalFromSotrudnik(id);
            lbl_nameCard.Text = string.Format("Личная карточка {0} {1} {2} {3}", LastName, FirstName, patronymic, Birthday);
            id1 = id;
            try
            {
                dgv_Journal.Columns["id"].Visible = false;
                dgv_dateEmlpoy.Columns["id"].Visible = false;
            }
            catch
            {

            }



        }


        private void dgv_RezultSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Journal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {



        }

        private void dgv_RezultSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_RezultSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btn_ot_Click(object sender, EventArgs e)
        {

        }

        private void btn_zp_Click(object sender, EventArgs e)
        {


        }

        private void dgv_RezultSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgv_Journal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_Journal.CurrentCell.RowIndex;
            dgv_Journal.Rows[index].Selected = true;
        }

        private void btn_Spravka_Click(object sender, EventArgs e)
        {


        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Card_Click(object sender, EventArgs e)
        {
            NewPersonalCard newCard = new NewPersonalCard(id1);
            newCard.ShowDialog();
            dgv_Journal.DataSource = dal.JournalFromSotrudnik(id1);
            dgv_dateEmlpoy.DataSource = dal.Get_Customer_Dol_Date(id1);


            try
            {
                dgv_Journal.Columns["id"].Visible = false;
                dgv_dateEmlpoy.Columns["Id"].Visible = false;
            }
            catch
            {

            }
        }

        private void btn_EditCard_Click(object sender, EventArgs e)
        {
            if (dgv_Journal.CurrentRow != null)
            {
                EditPersonalCard editPersonalCard = new EditPersonalCard(dgv_Journal.CurrentRow.Cells[0].Value.ToString(), dgv_Journal.CurrentRow.Cells[4].Value.ToString(), Convert.ToDateTime(dgv_Journal.CurrentRow.Cells[5].Value), dgv_Journal.CurrentRow.Cells[2].Value.ToString(), dgv_Journal.CurrentRow.Cells[3].Value.ToString());

                editPersonalCard.ShowDialog();
                dgv_Journal.DataSource = dal.JournalFromSotrudnik(id1);
                try
                {
                    dgv_Journal.Columns["id"].Visible = false;
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

        private void btn_DeleteCard_Click(object sender, EventArgs e)
        {
            if (dgv_Journal.CurrentRow != null)
            {
                if (dgv_Journal.CurrentRow.Selected)
                {
                    DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Вы действительно хотите удалить эту запись в личной карточке?", "Удаление", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        dal.DeleteFromJournal(dgv_Journal.CurrentRow.Cells[0].Value.ToString());


                        dgv_Journal.DataSource = dal.JournalFromSotrudnik(id1);
                        dgv_dateEmlpoy.DataSource = dal.Get_Customer_Dol_Date(id1);

                        try
                        {
                            dgv_Journal.Columns["id"].Visible = false;
                        }
                        catch
                        {

                        }
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Укажите запись, которую хотите удалить", "Удаление");
                }


            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Пожалуйста, укажите запись в таблице", "Ошибка");
            }

        }

        private void dgv_Journal_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow dataGridViewRow1 = dgv_Journal.Rows[e.RowIndex];
            contextMenuStrip1.Visible = true;
            metka = dgv_Journal.CurrentRow.Cells[6].Value;

            if (Convert.ToBoolean(metka) == true)

            {
                отметитьToolStripMenuItem.Text = "Снять отметку";
                отметитьToolStripMenuItem.Image = Properties.Resources.DELETE;
            }
            else
            {
                отметитьToolStripMenuItem.Text = "Пометить на удаление";
                отметитьToolStripMenuItem.Image = Properties.Resources.OK;
            }
        }

        private void dgv_Journal_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                dgv_Journal.CurrentCell = dgv_Journal[e.ColumnIndex, e.RowIndex];
                dgv_Journal.CurrentRow.Selected = true;
            }
        }

        private void отметитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = dgv_Journal.CurrentRow.Index;
            if (dal.MetkaDeleteFromJournal(dgv_Journal.CurrentRow.Cells[0].Value.ToString(), Convert.ToBoolean(metka)))
            {


                DataGridViewCellStyle rowRed = new DataGridViewCellStyle();
                rowRed.BackColor = Color.Red;
                dgv_Journal.Rows[index].DefaultCellStyle = rowRed;
                dgv_Journal.DataSource = dal.JournalFromSotrudnik(id1);
                //dgv_Customers.CurrentRow.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {


                DataGridViewCellStyle rowWhite = new DataGridViewCellStyle();
                rowWhite.BackColor = Color.White;
                dgv_Journal.Rows[index].DefaultCellStyle = rowWhite;
                dgv_Journal.DataSource = dal.JournalFromSotrudnik(id1);
                // dgv_Customers.Rows[index].InheritedStyle.BackColor = Color.Red;
            }

        }

        private void check_metka_CheckedChanged(object sender, EventArgs e)
        {
            if (check_metka.Checked)
            {
                dgv_Journal.DataSource = dal.getMetkaJournal(id1);
                if (dgv_Journal.Rows.Count == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Не найдено", "Ошибка");
                    check_metka.Checked = false;
                }
            }
            else

           if (check_metka.Checked == false)
            {
                dgv_Journal.DataSource = dal.JournalFromSotrudnik(id1);
                try
                {
                    dgv_Journal.Columns[0].Visible = false;
                }
                catch
                {

                }
            }
        }

        private void btn_Spravka_Click_1(object sender, EventArgs e)
        {
            if (dgv_Journal.SelectedRows.Count>=2)
            {
                List<object> tis = new List<object>();

                //for (int i = 0; i < dgv_Journal.SelectedRows.Count; i++)
                //{
                //    tis.Add(dgv_Journal.SelectedRows[i].Cells[0].Value.ToString());
                //}

                tis.Add(dgv_Journal.SelectedRows[0].Cells[0].Value.ToString());
                tis.Add(dgv_Journal.SelectedRows[dgv_Journal.SelectedRows.Count - 1].Cells[0].Value.ToString());
                tis.Reverse();

                List<object> FirstProf = new List<object> { LastName1, FirstName1, patronymic1, Birthday1, dgv_Journal.SelectedRows[dgv_Journal.SelectedRows.Count - 1].Cells[2].Value.ToString(), dgv_Journal.SelectedRows[dgv_Journal.SelectedRows.Count - 1].Cells[3].Value.ToString(), dgv_Journal.SelectedRows[dgv_Journal.SelectedRows.Count - 1].Cells[4].Value.ToString(), dgv_Journal.SelectedRows[dgv_Journal.SelectedRows.Count - 1].Cells[5].Value.ToString() };

                Word.Application application = new Word.Application();
                Object trueObj = true;
                Object falseObj = false;


                Word._Document document;
                Object templatePathObj = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Справка.docx");
                Object missingObj = System.Reflection.Missing.Value;
                document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                application.Visible = true;
                Word.Bookmarks wBookmarks = document.Bookmarks;
                Word.Range wRange;
                string Congratulations2 = "";
                string Position2 = "";
                string idPosition2 = "";



                int i = 0;
                ArrayList ForRefernce = new ArrayList();

                ForRefernce.AddRange(FirstProf);
                ForRefernce.AddRange(dal.DurationOfWork(dgv_Journal.SelectedRows[dgv_Journal.SelectedRows.Count - 1].Cells[0].Value.ToString()));
                bool check2Perevod = true;
                for (int j = dgv_Journal.SelectedRows.Count - 2; j >= 0; j--)
                {
                    if (dgv_Journal.SelectedRows[j].Cells[1].Value.ToString() == "Перевод")
                    {
                        Congratulations2 = dgv_Journal.SelectedRows[j].Cells[2].Value.ToString();
                        Position2 = dgv_Journal.SelectedRows[j].Cells[3].Value.ToString();
                        idPosition2 = dgv_Journal.SelectedRows[j].Cells[0].Value.ToString();
                        ForRefernce.Add(Congratulations2);
                        ForRefernce.Add(Position2);
                        ForRefernce.AddRange(dal.DurationOfWork(idPosition2));
                        check2Perevod = false;
                        break;
                    }

                }
                if (check2Perevod)
                {
                    ForRefernce.Add("");
                    ForRefernce.Add("");
                    ForRefernce.Add("");
                    ForRefernce.Add("");
                }

                ForRefernce.AddRange(dal.Spravka(id1, tis[0].ToString(), tis[1].ToString()));

                foreach (Word.Bookmark mark in wBookmarks)
                {

                    wRange = mark.Range;
                    wRange.Text = ForRefernce[i].ToString();
                    wRange.Bold = 1;
                    i++;

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Необходимо выделить минимум 2 строки","Ошибка");
            }




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
