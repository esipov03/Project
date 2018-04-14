namespace Radiator
{
    partial class PersonalCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalCard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_nameCard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Spravka = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_EditCard = new System.Windows.Forms.Button();
            this.btn_DeleteCard = new System.Windows.Forms.Button();
            this.btn_add_Card = new System.Windows.Forms.Button();
            this.dgv_Journal = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отметитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.check_metka = new System.Windows.Forms.CheckBox();
            this.dgv_dateEmlpoy = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Journal)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dateEmlpoy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nameCard
            // 
            this.lbl_nameCard.AutoSize = true;
            this.lbl_nameCard.BackColor = System.Drawing.Color.White;
            this.lbl_nameCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nameCard.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_nameCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.lbl_nameCard.Location = new System.Drawing.Point(231, 24);
            this.lbl_nameCard.Name = "lbl_nameCard";
            this.lbl_nameCard.Size = new System.Drawing.Size(0, 28);
            this.lbl_nameCard.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.btn_Spravka);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.btn_EditCard);
            this.panel2.Controls.Add(this.btn_DeleteCard);
            this.panel2.Controls.Add(this.btn_add_Card);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 664);
            this.panel2.TabIndex = 37;
            // 
            // btn_Spravka
            // 
            this.btn_Spravka.FlatAppearance.BorderSize = 0;
            this.btn_Spravka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Spravka.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Spravka.Image = global::Radiator.Properties.Resources.Spravka;
            this.btn_Spravka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Spravka.Location = new System.Drawing.Point(2, 332);
            this.btn_Spravka.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_Spravka.Name = "btn_Spravka";
            this.btn_Spravka.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Spravka.Size = new System.Drawing.Size(207, 52);
            this.btn_Spravka.TabIndex = 36;
            this.btn_Spravka.Text = "  Сформировать справку";
            this.btn_Spravka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Spravka.UseVisualStyleBackColor = true;
            this.btn_Spravka.Click += new System.EventHandler(this.btn_Spravka_Click_1);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.bunifuImageButton1.Image = global::Radiator.Properties.Resources.Bezymyanny1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(51, 536);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(113, 97);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 35;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btn_EditCard
            // 
            this.btn_EditCard.FlatAppearance.BorderSize = 0;
            this.btn_EditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditCard.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EditCard.Image = global::Radiator.Properties.Resources.icons8_Pencil_24px;
            this.btn_EditCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditCard.Location = new System.Drawing.Point(0, 161);
            this.btn_EditCard.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_EditCard.Name = "btn_EditCard";
            this.btn_EditCard.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_EditCard.Size = new System.Drawing.Size(209, 52);
            this.btn_EditCard.TabIndex = 32;
            this.btn_EditCard.Text = "  Изменить";
            this.btn_EditCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_EditCard.UseVisualStyleBackColor = true;
            this.btn_EditCard.Click += new System.EventHandler(this.btn_EditCard_Click);
            // 
            // btn_DeleteCard
            // 
            this.btn_DeleteCard.FlatAppearance.BorderSize = 0;
            this.btn_DeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteCard.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_DeleteCard.Image = global::Radiator.Properties.Resources.icons8_Delete_24px;
            this.btn_DeleteCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteCard.Location = new System.Drawing.Point(2, 248);
            this.btn_DeleteCard.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_DeleteCard.Name = "btn_DeleteCard";
            this.btn_DeleteCard.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_DeleteCard.Size = new System.Drawing.Size(207, 52);
            this.btn_DeleteCard.TabIndex = 31;
            this.btn_DeleteCard.Text = "  Удалить";
            this.btn_DeleteCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeleteCard.UseVisualStyleBackColor = true;
            this.btn_DeleteCard.Click += new System.EventHandler(this.btn_DeleteCard_Click);
            // 
            // btn_add_Card
            // 
            this.btn_add_Card.FlatAppearance.BorderSize = 0;
            this.btn_add_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_Card.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_Card.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_Card.Image")));
            this.btn_add_Card.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_Card.Location = new System.Drawing.Point(0, 76);
            this.btn_add_Card.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_add_Card.Name = "btn_add_Card";
            this.btn_add_Card.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_add_Card.Size = new System.Drawing.Size(212, 52);
            this.btn_add_Card.TabIndex = 28;
            this.btn_add_Card.Text = "  Добавить";
            this.btn_add_Card.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_add_Card.UseVisualStyleBackColor = true;
            this.btn_add_Card.Click += new System.EventHandler(this.btn_add_Card_Click);
            // 
            // dgv_Journal
            // 
            this.dgv_Journal.AllowUserToResizeColumns = false;
            this.dgv_Journal.AllowUserToResizeRows = false;
            this.dgv_Journal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Journal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Journal.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Journal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Journal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_Journal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Journal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Journal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Journal.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Journal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Journal.Location = new System.Drawing.Point(221, 131);
            this.dgv_Journal.Name = "dgv_Journal";
            this.dgv_Journal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Journal.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Journal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgv_Journal.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Journal.Size = new System.Drawing.Size(738, 254);
            this.dgv_Journal.TabIndex = 38;
            this.dgv_Journal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Journal_CellMouseDown);
            this.dgv_Journal.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgv_Journal_RowContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отметитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 26);
            // 
            // отметитьToolStripMenuItem
            // 
            this.отметитьToolStripMenuItem.Name = "отметитьToolStripMenuItem";
            this.отметитьToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.отметитьToolStripMenuItem.Text = "отметить на удаление";
            this.отметитьToolStripMenuItem.Click += new System.EventHandler(this.отметитьToolStripMenuItem_Click);
            // 
            // check_metka
            // 
            this.check_metka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.check_metka.AutoSize = true;
            this.check_metka.Location = new System.Drawing.Point(785, 95);
            this.check_metka.Name = "check_metka";
            this.check_metka.Size = new System.Drawing.Size(194, 18);
            this.check_metka.TabIndex = 40;
            this.check_metka.Text = "Помеченные на удаление";
            this.check_metka.UseVisualStyleBackColor = true;
            this.check_metka.CheckedChanged += new System.EventHandler(this.check_metka_CheckedChanged);
            // 
            // dgv_dateEmlpoy
            // 
            this.dgv_dateEmlpoy.AllowUserToResizeColumns = false;
            this.dgv_dateEmlpoy.AllowUserToResizeRows = false;
            this.dgv_dateEmlpoy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dateEmlpoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dateEmlpoy.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dateEmlpoy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dateEmlpoy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_dateEmlpoy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dateEmlpoy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_dateEmlpoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dateEmlpoy.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dateEmlpoy.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_dateEmlpoy.Location = new System.Drawing.Point(221, 405);
            this.dgv_dateEmlpoy.Name = "dgv_dateEmlpoy";
            this.dgv_dateEmlpoy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dateEmlpoy.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_dateEmlpoy.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgv_dateEmlpoy.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_dateEmlpoy.Size = new System.Drawing.Size(738, 260);
            this.dgv_dateEmlpoy.TabIndex = 41;
            this.dgv_dateEmlpoy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PersonalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1012, 668);
            this.Controls.Add(this.dgv_dateEmlpoy);
            this.Controls.Add(this.check_metka);
            this.Controls.Add(this.dgv_Journal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_nameCard);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(772, 500);
            this.Name = "PersonalCard";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 30, 0);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Search_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Journal)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dateEmlpoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nameCard;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btn_EditCard;
        private System.Windows.Forms.Button btn_DeleteCard;
        private System.Windows.Forms.Button btn_add_Card;
        private System.Windows.Forms.DataGridView dgv_Journal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отметитьToolStripMenuItem;
        private System.Windows.Forms.CheckBox check_metka;
        private System.Windows.Forms.Button btn_Spravka;
        private System.Windows.Forms.DataGridView dgv_dateEmlpoy;
    }
}