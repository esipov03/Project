namespace Radiator
{
    partial class Salary
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.txbx_ZP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Summa = new System.Windows.Forms.Label();
            this.dgv_SearchZP = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отметитьНаУдалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_edit_Salary = new System.Windows.Forms.Button();
            this.btn_delete_salary = new System.Windows.Forms.Button();
            this.btn_add_salary = new System.Windows.Forms.Button();
            this.check_Metka = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchZP)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbx_ZP
            // 
            this.txbx_ZP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_ZP.Location = new System.Drawing.Point(283, 60);
            this.txbx_ZP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbx_ZP.MaximumSize = new System.Drawing.Size(88, 23);
            this.txbx_ZP.MaxLength = 4;
            this.txbx_ZP.MinimumSize = new System.Drawing.Size(88, 23);
            this.txbx_ZP.Name = "txbx_ZP";
            this.txbx_ZP.Size = new System.Drawing.Size(88, 23);
            this.txbx_ZP.TabIndex = 1;
            this.txbx_ZP.TextChanged += new System.EventHandler(this.txbx_ZP_TextChanged);
            this.txbx_ZP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_ZP_KeyPress);
            this.txbx_ZP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbx_ZP_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Год:";
            // 
            // Summa
            // 
            this.Summa.AutoSize = true;
            this.Summa.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Summa.Location = new System.Drawing.Point(408, 66);
            this.Summa.Name = "Summa";
            this.Summa.Size = new System.Drawing.Size(48, 17);
            this.Summa.TabIndex = 5;
            this.Summa.Text = "00,00 ";
            // 
            // dgv_SearchZP
            // 
            this.dgv_SearchZP.AllowUserToResizeColumns = false;
            this.dgv_SearchZP.AllowUserToResizeRows = false;
            this.dgv_SearchZP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SearchZP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SearchZP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SearchZP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SearchZP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_SearchZP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SearchZP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SearchZP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchZP.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SearchZP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SearchZP.Location = new System.Drawing.Point(228, 144);
            this.dgv_SearchZP.Name = "dgv_SearchZP";
            this.dgv_SearchZP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SearchZP.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SearchZP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgv_SearchZP.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SearchZP.Size = new System.Drawing.Size(790, 493);
            this.dgv_SearchZP.TabIndex = 40;
            this.dgv_SearchZP.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_SearchZP_CellMouseDown);
            this.dgv_SearchZP.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgv_SearchZP_RowContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отметитьНаУдалениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 26);
            // 
            // отметитьНаУдалениеToolStripMenuItem
            // 
            this.отметитьНаУдалениеToolStripMenuItem.Name = "отметитьНаУдалениеToolStripMenuItem";
            this.отметитьНаУдалениеToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.отметитьНаУдалениеToolStripMenuItem.Text = "Отметить на удаление";
            this.отметитьНаУдалениеToolStripMenuItem.Click += new System.EventHandler(this.отметитьНаУдалениеToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.btn_edit_Salary);
            this.panel2.Controls.Add(this.btn_delete_salary);
            this.panel2.Controls.Add(this.btn_add_salary);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 653);
            this.panel2.TabIndex = 41;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.bunifuImageButton1.Image = global::Radiator.Properties.Resources.Bezymyanny1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(43, 532);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(113, 97);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btn_edit_Salary
            // 
            this.btn_edit_Salary.FlatAppearance.BorderSize = 0;
            this.btn_edit_Salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_Salary.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_Salary.Image = global::Radiator.Properties.Resources.icons8_Pencil_24px;
            this.btn_edit_Salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_Salary.Location = new System.Drawing.Point(0, 143);
            this.btn_edit_Salary.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_edit_Salary.Name = "btn_edit_Salary";
            this.btn_edit_Salary.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_edit_Salary.Size = new System.Drawing.Size(214, 52);
            this.btn_edit_Salary.TabIndex = 32;
            this.btn_edit_Salary.Text = "  Изменить";
            this.btn_edit_Salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit_Salary.UseVisualStyleBackColor = true;
            this.btn_edit_Salary.Click += new System.EventHandler(this.btn_edit_Salary_Click);
            // 
            // btn_delete_salary
            // 
            this.btn_delete_salary.FlatAppearance.BorderSize = 0;
            this.btn_delete_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_salary.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete_salary.Image = global::Radiator.Properties.Resources.icons8_Delete_24px;
            this.btn_delete_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_salary.Location = new System.Drawing.Point(0, 218);
            this.btn_delete_salary.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_delete_salary.Name = "btn_delete_salary";
            this.btn_delete_salary.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_delete_salary.Size = new System.Drawing.Size(214, 52);
            this.btn_delete_salary.TabIndex = 31;
            this.btn_delete_salary.Text = "  Удалить";
            this.btn_delete_salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete_salary.UseVisualStyleBackColor = true;
            this.btn_delete_salary.Click += new System.EventHandler(this.btn_delete_salary_Click);
            // 
            // btn_add_salary
            // 
            this.btn_add_salary.FlatAppearance.BorderSize = 0;
            this.btn_add_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_salary.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_salary.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_salary.Image")));
            this.btn_add_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_salary.Location = new System.Drawing.Point(0, 76);
            this.btn_add_salary.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_add_salary.Name = "btn_add_salary";
            this.btn_add_salary.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_add_salary.Size = new System.Drawing.Size(218, 52);
            this.btn_add_salary.TabIndex = 28;
            this.btn_add_salary.Text = "  Добавить";
            this.btn_add_salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_salary.UseVisualStyleBackColor = true;
            this.btn_add_salary.Click += new System.EventHandler(this.btn_add_salary_Click);
            // 
            // check_Metka
            // 
            this.check_Metka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_Metka.AutoSize = true;
            this.check_Metka.Location = new System.Drawing.Point(840, 109);
            this.check_Metka.Name = "check_Metka";
            this.check_Metka.Size = new System.Drawing.Size(178, 20);
            this.check_Metka.TabIndex = 43;
            this.check_Metka.Text = "Помеченные на удаление";
            this.check_Metka.UseVisualStyleBackColor = true;
            this.check_Metka.CheckedChanged += new System.EventHandler(this.ckeck_Metka_CheckedChanged);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 656);
            this.Controls.Add(this.check_Metka);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_SearchZP);
            this.Controls.Add(this.Summa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_ZP);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(943, 412);
            this.Name = "Salary";
            this.Padding = new System.Windows.Forms.Padding(23, 74, 23, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.SearchZP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchZP)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbx_ZP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Summa;
        private System.Windows.Forms.DataGridView dgv_SearchZP;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_edit_Salary;
        private System.Windows.Forms.Button btn_delete_salary;
        private System.Windows.Forms.Button btn_add_salary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отметитьНаУдалениеToolStripMenuItem;
        private System.Windows.Forms.CheckBox check_Metka;
    }
}