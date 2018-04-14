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
    public partial class SettingsConnect : MetroFramework.Forms.MetroForm
    {
        public SettingsConnect()
        {
            InitializeComponent();
            txbx_server.Text = Properties.Settings.Default.server;
            txbx_login.Text = Properties.Settings.Default.login;
            txbx_password.Text = Properties.Settings.Default.password;
            txbx_nameDB.Text = Properties.Settings.Default.database;
            Properties.Settings.Default.Save();

        }

        private void SettingsConnect_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = txbx_server.Text;
            Properties.Settings.Default.login = txbx_login.Text;
            Properties.Settings.Default.password = txbx_password.Text;
            Properties.Settings.Default.database = txbx_nameDB.Text;
            Properties.Settings.Default.Save();
            MetroFramework.MetroMessageBox.Show(this, "Данные успеешно обновлены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
