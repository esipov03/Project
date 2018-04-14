namespace Radiator
{
    partial class LoginSqlAdmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_server = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbx_login = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txbx_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(337, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.MaximumSize = new System.Drawing.Size(625, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 40);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbx_server
            // 
            this.txbx_server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_server.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_server.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_server.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_server.HintText = "Имя сервера";
            this.txbx_server.isPassword = false;
            this.txbx_server.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_server.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_server.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_server.LineThickness = 4;
            this.txbx_server.Location = new System.Drawing.Point(13, 79);
            this.txbx_server.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_server.Name = "txbx_server";
            this.txbx_server.Size = new System.Drawing.Size(502, 44);
            this.txbx_server.TabIndex = 2;
            this.txbx_server.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbx_login
            // 
            this.txbx_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_login.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_login.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_login.HintText = "Логин";
            this.txbx_login.isPassword = false;
            this.txbx_login.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_login.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_login.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_login.LineThickness = 4;
            this.txbx_login.Location = new System.Drawing.Point(15, 143);
            this.txbx_login.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_login.Name = "txbx_login";
            this.txbx_login.Size = new System.Drawing.Size(500, 44);
            this.txbx_login.TabIndex = 3;
            this.txbx_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txbx_password
            // 
            this.txbx_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbx_password.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbx_password.HintForeColor = System.Drawing.Color.Empty;
            this.txbx_password.HintText = "Пароль";
            this.txbx_password.isPassword = false;
            this.txbx_password.LineFocusedColor = System.Drawing.Color.Blue;
            this.txbx_password.LineIdleColor = System.Drawing.Color.Gray;
            this.txbx_password.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txbx_password.LineThickness = 4;
            this.txbx_password.Location = new System.Drawing.Point(16, 209);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(499, 44);
            this.txbx_password.TabIndex = 4;
            this.txbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginSqlAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 342);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.txbx_login);
            this.Controls.Add(this.txbx_server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(883, 342);
            this.MinimumSize = new System.Drawing.Size(374, 342);
            this.Name = "LoginSqlAdmin";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_server;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbx_password;
    }
}