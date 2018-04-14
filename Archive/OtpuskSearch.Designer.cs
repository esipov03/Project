namespace Radiator
{
    partial class OtpuskSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtpuskSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Prich = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgv_otpuskSearch = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отметитьНаУдалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_editOtpusk = new System.Windows.Forms.Button();
            this.btn_deleteOtpusk = new System.Windows.Forms.Button();
            this.btn_addOtpusk = new System.Windows.Forms.Button();
            this.check_metka = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_otpuskSearch)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Причина";
            this.toolTip1.SetToolTip(this.label1, "Показать полный список");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_Prich
            // 
            this.cb_Prich.FormattingEnabled = true;
            this.cb_Prich.Location = new System.Drawing.Point(306, 88);
            this.cb_Prich.Name = "cb_Prich";
            this.cb_Prich.Size = new System.Drawing.Size(251, 24);
            this.cb_Prich.TabIndex = 3;
            this.cb_Prich.SelectedIndexChanged += new System.EventHandler(this.cb_Prich_SelectedIndexChanged);
            this.cb_Prich.ValueMemberChanged += new System.EventHandler(this.cb_Prich_ValueMemberChanged);
            this.cb_Prich.SelectedValueChanged += new System.EventHandler(this.cb_Prich_SelectedValueChanged);
            // 
            // dgv_otpuskSearch
            // 
            this.dgv_otpuskSearch.AllowUserToResizeColumns = false;
            this.dgv_otpuskSearch.AllowUserToResizeRows = false;
            this.dgv_otpuskSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_otpuskSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_otpuskSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgv_otpuskSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_otpuskSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_otpuskSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_otpuskSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_otpuskSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_otpuskSearch.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_otpuskSearch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_otpuskSearch.Location = new System.Drawing.Point(220, 147);
            this.dgv_otpuskSearch.Name = "dgv_otpuskSearch";
            this.dgv_otpuskSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_otpuskSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_otpuskSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgv_otpuskSearch.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_otpuskSearch.Size = new System.Drawing.Size(781, 423);
            this.dgv_otpuskSearch.TabIndex = 39;
            this.dgv_otpuskSearch.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_otpuskSearch_CellMouseDown);
            this.dgv_otpuskSearch.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgv_otpuskSearch_RowContextMenuStripNeeded);
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
            this.panel2.Controls.Add(this.btn_editOtpusk);
            this.panel2.Controls.Add(this.btn_deleteOtpusk);
            this.panel2.Controls.Add(this.btn_addOtpusk);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 580);
            this.panel2.TabIndex = 40;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.bunifuImageButton1.Image = global::Radiator.Properties.Resources.Bezymyanny1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(43, 459);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(113, 97);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btn_editOtpusk
            // 
            this.btn_editOtpusk.FlatAppearance.BorderSize = 0;
            this.btn_editOtpusk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editOtpusk.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_editOtpusk.Image = global::Radiator.Properties.Resources.icons8_Pencil_24px;
            this.btn_editOtpusk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editOtpusk.Location = new System.Drawing.Point(0, 143);
            this.btn_editOtpusk.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_editOtpusk.Name = "btn_editOtpusk";
            this.btn_editOtpusk.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_editOtpusk.Size = new System.Drawing.Size(214, 52);
            this.btn_editOtpusk.TabIndex = 32;
            this.btn_editOtpusk.Text = "  Изменить";
            this.btn_editOtpusk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editOtpusk.UseVisualStyleBackColor = true;
            this.btn_editOtpusk.Click += new System.EventHandler(this.btn_editOtpusk_Click);
            // 
            // btn_deleteOtpusk
            // 
            this.btn_deleteOtpusk.FlatAppearance.BorderSize = 0;
            this.btn_deleteOtpusk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteOtpusk.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deleteOtpusk.Image = global::Radiator.Properties.Resources.icons8_Delete_24px;
            this.btn_deleteOtpusk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteOtpusk.Location = new System.Drawing.Point(0, 218);
            this.btn_deleteOtpusk.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_deleteOtpusk.Name = "btn_deleteOtpusk";
            this.btn_deleteOtpusk.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_deleteOtpusk.Size = new System.Drawing.Size(214, 52);
            this.btn_deleteOtpusk.TabIndex = 31;
            this.btn_deleteOtpusk.Text = "  Удалить";
            this.btn_deleteOtpusk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deleteOtpusk.UseVisualStyleBackColor = true;
            this.btn_deleteOtpusk.Click += new System.EventHandler(this.btn_deleteOtpusk_Click);
            // 
            // btn_addOtpusk
            // 
            this.btn_addOtpusk.FlatAppearance.BorderSize = 0;
            this.btn_addOtpusk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOtpusk.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addOtpusk.Image = ((System.Drawing.Image)(resources.GetObject("btn_addOtpusk.Image")));
            this.btn_addOtpusk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addOtpusk.Location = new System.Drawing.Point(-3, 76);
            this.btn_addOtpusk.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_addOtpusk.Name = "btn_addOtpusk";
            this.btn_addOtpusk.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_addOtpusk.Size = new System.Drawing.Size(212, 52);
            this.btn_addOtpusk.TabIndex = 28;
            this.btn_addOtpusk.Text = "  Добавить";
            this.btn_addOtpusk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addOtpusk.UseVisualStyleBackColor = true;
            this.btn_addOtpusk.Click += new System.EventHandler(this.btn_addOtpusk_Click);
            // 
            // check_metka
            // 
            this.check_metka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_metka.AutoSize = true;
            this.check_metka.Location = new System.Drawing.Point(798, 108);
            this.check_metka.Name = "check_metka";
            this.check_metka.Size = new System.Drawing.Size(197, 20);
            this.check_metka.TabIndex = 42;
            this.check_metka.Text = "Помеченные на удаление";
            this.check_metka.UseVisualStyleBackColor = true;
            this.check_metka.CheckedChanged += new System.EventHandler(this.check_metka_CheckedChanged);
            // 
            // OtpuskSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 580);
            this.Controls.Add(this.check_metka);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_otpuskSearch);
            this.Controls.Add(this.cb_Prich);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(838, 393);
            this.Name = "OtpuskSearch";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Отпуска";
            this.Load += new System.EventHandler(this.OtpuskSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_otpuskSearch)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Prich;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_otpuskSearch;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_editOtpusk;
        private System.Windows.Forms.Button btn_deleteOtpusk;
        private System.Windows.Forms.Button btn_addOtpusk;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отметитьНаУдалениеToolStripMenuItem;
        private System.Windows.Forms.CheckBox check_metka;
    }
}