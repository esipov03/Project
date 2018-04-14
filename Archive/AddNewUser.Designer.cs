namespace Radiator
{
    partial class AddNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbx_loginUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbx_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_loginUser
            // 
            this.txbx_loginUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_loginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_loginUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_loginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_loginUser.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_loginUser.HintText = "Логин";
            this.txbx_loginUser.isPassword = false;
            this.txbx_loginUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_loginUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_loginUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_loginUser.LineThickness = 3;
            this.txbx_loginUser.Location = new System.Drawing.Point(12, 13);
            this.txbx_loginUser.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_loginUser.Name = "txbx_loginUser";
            this.txbx_loginUser.Size = new System.Drawing.Size(370, 44);
            this.txbx_loginUser.TabIndex = 3;
            this.txbx_loginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbx_password
            // 
            this.txbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txbx_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_password.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_password.HintText = "Пароль";
            this.txbx_password.isPassword = false;
            this.txbx_password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_password.LineThickness = 3;
            this.txbx_password.Location = new System.Drawing.Point(12, 83);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(370, 44);
            this.txbx_password.TabIndex = 4;
            this.txbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmb_role
            // 
            this.cmb_role.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(12, 162);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(231, 21);
            this.cmb_role.TabIndex = 5;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addUser.Location = new System.Drawing.Point(330, 199);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(89, 23);
            this.btn_addUser.TabIndex = 6;
            this.btn_addUser.Text = "Добавить";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 245);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_loginUser);
            this.MaximumSize = new System.Drawing.Size(442, 245);
            this.MinimumSize = new System.Drawing.Size(442, 245);
            this.Name = "AddNewUser";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_loginUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_password;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Button btn_addUser;
    }
}