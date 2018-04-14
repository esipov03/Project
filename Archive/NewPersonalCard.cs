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

namespace Radiator
{
    public partial class NewPersonalCard : MetroFramework.Forms.MetroForm
    {

        DAL dal = new DAL();
        private string id1 = null;
        public NewPersonalCard(string id)
        {
            InitializeComponent();
            
            cbx_deistv.DataSource = dal.GetAllDeistv();
            cbx_deistv.DisplayMember = "Наименование ";
            cbx_deistv.ValueMember = "id";
            id1 = id;
        }

        private void btn_AddNewJournal_Click(object sender, EventArgs e)
        {


            try
            {

                if (txbx_Pod.Text == "" || txbx_Dol.Text == "" || txbx_Prikazn.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "вы ввели не всю информацию", "Ошибка");

                }
                else
                {
                    dal.Insert_Journal(id1, cbx_deistv.SelectedValue.ToString(), txbx_Prikazn.Text, dtp_prik.Value);
                    dal.Insert_Dol_Pod(txbx_Pod.Text.Trim(), txbx_Dol.Text.Trim());
                    if (cbx_deistv.SelectedIndex != 1)
                    {
                        dal.Set_Custmomer_PersonalCard_Date(id1, dtv_Dateofemployment.Value);
                    }
                    else
                    {
                        dal.UpdateDateEndВismissale(id1, dtv_Dateofemployment.Value);
                    }
                    
                    
                    MetroFramework.MetroMessageBox.Show(this, "Новая запись в журнал усешно добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txbx_Pod.Clear();
                    txbx_Dol.Clear();
                    txbx_Prikazn.Clear();
                    

                }


            }

            catch(Exception ex)
            {
                // MetroFramework.MetroMessageBox.Show(this, "Произошка ошибка. Проверьте внесённые данные или выбор сотрудника", "Ошибка", MessageBoxButtons.OK);
                MessageBox.Show(ex.Message);
                

            }
            

        }

        private void NewJournal_Load(object sender, EventArgs e)
        {
           
            dal.SerachDolTextBox(txbx_Dol);
            dal.SerachPodTextBox(txbx_Pod);
            
        }

        private void txbx_SearchSotrFromJournal_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txbx_Dol_TextChanged(object sender, EventArgs e)
        {
            
                                       
        }

        private void dgv_AddNewSotr_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void cbx_deistv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_deistv.SelectedIndex!=1)
            {
              
                dtv_Dateofemployment.Enabled = true;
                txbx_Dol.Text = "";
                txbx_Pod.Text = "";
                txbx_Dol.ReadOnly = false;
                txbx_Pod.ReadOnly = false;
                txbx_DataPrikaz.Text = "Дата выхода на работу";
            }
            else
            {
               
              
                txbx_Dol.Text = "-";
                txbx_Pod.Text = "-";
                txbx_Dol.ReadOnly = true;
                txbx_Pod.ReadOnly = true;
                txbx_DataPrikaz.Text = "Дата завершения работы";
            }


            
        }
    }
}
