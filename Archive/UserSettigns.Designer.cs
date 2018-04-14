namespace Radiator
{
    partial class UserSettigns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettigns));
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_editUser = new System.Windows.Forms.Button();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.btn_addnewusers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_users.BackgroundColor = System.Drawing.Color.White;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(229, 78);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(599, 381);
            this.dgv_users.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.btn_editUser);
            this.panel2.Controls.Add(this.btn_deleteUser);
            this.panel2.Controls.Add(this.btn_addnewusers);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 482);
            this.panel2.TabIndex = 42;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.bunifuImageButton1.Image = global::Radiator.Properties.Resources.Bezymyanny1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(43, 361);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(113, 97);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btn_editUser
            // 
            this.btn_editUser.FlatAppearance.BorderSize = 0;
            this.btn_editUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editUser.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_editUser.Image = global::Radiator.Properties.Resources.icons8_Pencil_24px;
            this.btn_editUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editUser.Location = new System.Drawing.Point(0, 101);
            this.btn_editUser.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_editUser.Name = "btn_editUser";
            this.btn_editUser.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_editUser.Size = new System.Drawing.Size(214, 52);
            this.btn_editUser.TabIndex = 32;
            this.btn_editUser.Text = "  Изменить";
            this.btn_editUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editUser.UseVisualStyleBackColor = true;
            this.btn_editUser.Click += new System.EventHandler(this.btn_editUser_Click);
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.FlatAppearance.BorderSize = 0;
            this.btn_deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteUser.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deleteUser.Image = global::Radiator.Properties.Resources.icons8_Delete_24px;
            this.btn_deleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteUser.Location = new System.Drawing.Point(0, 176);
            this.btn_deleteUser.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_deleteUser.Size = new System.Drawing.Size(214, 52);
            this.btn_deleteUser.TabIndex = 31;
            this.btn_deleteUser.Text = "  Удалить";
            this.btn_deleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // btn_addnewusers
            // 
            this.btn_addnewusers.FlatAppearance.BorderSize = 0;
            this.btn_addnewusers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addnewusers.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addnewusers.Image = ((System.Drawing.Image)(resources.GetObject("btn_addnewusers.Image")));
            this.btn_addnewusers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addnewusers.Location = new System.Drawing.Point(0, 34);
            this.btn_addnewusers.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_addnewusers.Name = "btn_addnewusers";
            this.btn_addnewusers.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_addnewusers.Size = new System.Drawing.Size(218, 52);
            this.btn_addnewusers.TabIndex = 28;
            this.btn_addnewusers.Text = "  Добавить";
            this.btn_addnewusers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addnewusers.UseVisualStyleBackColor = true;
            this.btn_addnewusers.Click += new System.EventHandler(this.btn_addnewusers_Click);
            // 
            // UserSettigns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_users);
            this.MaximumSize = new System.Drawing.Size(839, 482);
            this.MinimumSize = new System.Drawing.Size(839, 390);
            this.Name = "UserSettigns";
            this.Style = MetroFramework.MetroColorStyle.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_editUser;
        private System.Windows.Forms.Button btn_deleteUser;
        private System.Windows.Forms.Button btn_addnewusers;
    }
}