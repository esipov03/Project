namespace Radiator
{
    partial class EditUser
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
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.txbx_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbx_loginUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_role
            // 
            this.cmb_role.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_role.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(22, 226);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(354, 28);
            this.cmb_role.TabIndex = 8;
            // 
            // txbx_password
            // 
            this.txbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_password.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_password.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_password.HintText = "";
            this.txbx_password.isPassword = false;
            this.txbx_password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_password.LineThickness = 4;
            this.txbx_password.Location = new System.Drawing.Point(22, 147);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(493, 44);
            this.txbx_password.TabIndex = 7;
            this.txbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbx_loginUser
            // 
            this.txbx_loginUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_loginUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_loginUser.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_loginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_loginUser.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_loginUser.HintText = "";
            this.txbx_loginUser.isPassword = false;
            this.txbx_loginUser.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_loginUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_loginUser.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_loginUser.LineThickness = 4;
            this.txbx_loginUser.Location = new System.Drawing.Point(22, 95);
            this.txbx_loginUser.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_loginUser.Name = "txbx_loginUser";
            this.txbx_loginUser.Size = new System.Drawing.Size(493, 44);
            this.txbx_loginUser.TabIndex = 6;
            this.txbx_loginUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_editUser
            // 
            this.btn_editUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editUser.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_editUser.Location = new System.Drawing.Point(391, 296);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Size = new System.Drawing.Size(124, 34);
            this.btn_editUser.TabIndex = 9;
            this.btn_editUser.Text = "Изменить";
            this.btn_editUser.UseVisualStyleBackColor = true;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 342);
            this.Controls.Add(this.btn_editUser);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_loginUser);
            this.MaximumSize = new System.Drawing.Size(845, 350);
            this.MinimumSize = new System.Drawing.Size(274, 342);
            this.Name = "EditUser";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Изменить";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_role;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_loginUser;
        private System.Windows.Forms.Button btn_editUser;
    }
}