namespace Radiator
{
    partial class HomeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_user = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_max = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_min = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.отметитьНаУдалениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_metka = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Otpusk = new System.Windows.Forms.Button();
            this.btn_EditCustomer = new System.Windows.Forms.Button();
            this.btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.add_Journal = new System.Windows.Forms.Button();
            this.btn_Salary = new System.Windows.Forms.Button();
            this.btn_add_Customers = new System.Windows.Forms.Button();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txbx_custmerSearch = new MetroFramework.Controls.MetroTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 38);
            this.panel1.TabIndex = 17;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_user
            // 
            this.btn_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.btn_user.Image = global::Radiator.Properties.Resources.icons8_Customer_26px;
            this.btn_user.ImageActive = null;
            this.btn_user.Location = new System.Drawing.Point(1298, 5);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(21, 27);
            this.btn_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_user.TabIndex = 17;
            this.btn_user.TabStop = false;
            this.btn_user.Visible = false;
            this.btn_user.Zoom = 10;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.btn_cancel.Image = global::Radiator.Properties.Resources.icons8_Delete_24px_5;
            this.btn_cancel.ImageActive = null;
            this.btn_cancel.Location = new System.Drawing.Point(1391, 9);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(27, 23);
            this.btn_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cancel.TabIndex = 17;
            this.btn_cancel.TabStop = false;
            this.btn_cancel.Zoom = 10;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.btn_max.Image = global::Radiator.Properties.Resources.icons8_Collapse_24px;
            this.btn_max.ImageActive = null;
            this.btn_max.Location = new System.Drawing.Point(1353, 9);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(32, 23);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_max.TabIndex = 17;
            this.btn_max.TabStop = false;
            this.btn_max.Zoom = 10;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.btn_min.Image = global::Radiator.Properties.Resources.niz;
            this.btn_min.ImageActive = null;
            this.btn_min.Location = new System.Drawing.Point(1325, 5);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(22, 27);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min.TabIndex = 18;
            this.btn_min.TabStop = false;
            this.btn_min.Zoom = 10;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // lbl_Role
            // 
            this.lbl_Role.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.lbl_Role.Location = new System.Drawing.Point(702, 649);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(0, 20);
            this.lbl_Role.TabIndex = 19;
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.AllowUserToResizeColumns = false;
            this.dgv_Customers.AllowUserToResizeRows = false;
            this.dgv_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Customers.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Customers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgv_Customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Customers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Customers.Location = new System.Drawing.Point(235, 190);
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(255)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Customers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.dgv_Customers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Customers.Size = new System.Drawing.Size(1174, 468);
            this.dgv_Customers.TabIndex = 28;
            this.dgv_Customers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customers_CellClick);
            this.dgv_Customers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Customers_CellMouseDown);
            this.dgv_Customers.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dgv_Customers_RowContextMenuStripNeeded);
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
            // cbx_metka
            // 
            this.cbx_metka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_metka.AutoSize = true;
            this.cbx_metka.Location = new System.Drawing.Point(1193, 152);
            this.cbx_metka.Name = "cbx_metka";
            this.cbx_metka.Size = new System.Drawing.Size(156, 17);
            this.cbx_metka.TabIndex = 33;
            this.cbx_metka.Text = "Помеченные на удаление";
            this.cbx_metka.UseVisualStyleBackColor = true;
            this.cbx_metka.CheckedChanged += new System.EventHandler(this.cbx_metka_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(213)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(360, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 41);
            this.label2.TabIndex = 32;
            this.label2.Text = "Архив сотрудников";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btn_Otpusk);
            this.panel2.Controls.Add(this.btn_EditCustomer);
            this.panel2.Controls.Add(this.btn_DeleteCustomer);
            this.panel2.Controls.Add(this.add_Journal);
            this.panel2.Controls.Add(this.btn_Salary);
            this.panel2.Controls.Add(this.btn_add_Customers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 660);
            this.panel2.TabIndex = 29;
            // 
            // btn_Otpusk
            // 
            this.btn_Otpusk.BackColor = System.Drawing.Color.Transparent;
            this.btn_Otpusk.FlatAppearance.BorderSize = 0;
            this.btn_Otpusk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Otpusk.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Otpusk.ForeColor = System.Drawing.Color.Black;
            this.btn_Otpusk.Image = global::Radiator.Properties.Resources.RadiatorVacation1;
            this.btn_Otpusk.Location = new System.Drawing.Point(0, 540);
            this.btn_Otpusk.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_Otpusk.Name = "btn_Otpusk";
            this.btn_Otpusk.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Otpusk.Size = new System.Drawing.Size(212, 78);
            this.btn_Otpusk.TabIndex = 33;
            this.btn_Otpusk.Text = "  Отпуск";
            this.btn_Otpusk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Otpusk.UseVisualStyleBackColor = false;
            this.btn_Otpusk.Click += new System.EventHandler(this.добавитьОтпускToolStripMenuItem_Click);
            // 
            // btn_EditCustomer
            // 
            this.btn_EditCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btn_EditCustomer.FlatAppearance.BorderSize = 0;
            this.btn_EditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditCustomer.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_EditCustomer.Image = global::Radiator.Properties.Resources.RadiatorEdit1;
            this.btn_EditCustomer.Location = new System.Drawing.Point(0, 126);
            this.btn_EditCustomer.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_EditCustomer.Name = "btn_EditCustomer";
            this.btn_EditCustomer.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_EditCustomer.Size = new System.Drawing.Size(212, 67);
            this.btn_EditCustomer.TabIndex = 32;
            this.btn_EditCustomer.Text = "  Изменить сотрудника";
            this.btn_EditCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_EditCustomer.UseVisualStyleBackColor = false;
            this.btn_EditCustomer.Click += new System.EventHandler(this.btn_EditCustomer_Click);
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btn_DeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btn_DeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteCustomer.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCustomer.ForeColor = System.Drawing.Color.Black;
            this.btn_DeleteCustomer.Image = global::Radiator.Properties.Resources.RadiatorDelete1;
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(0, 223);
            this.btn_DeleteCustomer.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(212, 75);
            this.btn_DeleteCustomer.TabIndex = 31;
            this.btn_DeleteCustomer.Text = "  Удалить сотрудника";
            this.btn_DeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_DeleteCustomer.UseVisualStyleBackColor = false;
            this.btn_DeleteCustomer.Click += new System.EventHandler(this.btn_DeleteCustomer_Click);
            // 
            // add_Journal
            // 
            this.add_Journal.BackColor = System.Drawing.Color.Transparent;
            this.add_Journal.FlatAppearance.BorderSize = 0;
            this.add_Journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Journal.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Journal.ForeColor = System.Drawing.Color.Black;
            this.add_Journal.Image = global::Radiator.Properties.Resources.RadiatorPersonalCard1;
            this.add_Journal.Location = new System.Drawing.Point(0, 329);
            this.add_Journal.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.add_Journal.Name = "add_Journal";
            this.add_Journal.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.add_Journal.Size = new System.Drawing.Size(212, 74);
            this.add_Journal.TabIndex = 30;
            this.add_Journal.Text = "  Личная карточка";
            this.add_Journal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_Journal.UseVisualStyleBackColor = false;
            this.add_Journal.Click += new System.EventHandler(this.add_Journal_Click);
            // 
            // btn_Salary
            // 
            this.btn_Salary.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salary.FlatAppearance.BorderSize = 0;
            this.btn_Salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salary.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salary.ForeColor = System.Drawing.Color.Black;
            this.btn_Salary.Image = global::Radiator.Properties.Resources.RadiatorSalary1;
            this.btn_Salary.Location = new System.Drawing.Point(0, 431);
            this.btn_Salary.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_Salary.Name = "btn_Salary";
            this.btn_Salary.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_Salary.Size = new System.Drawing.Size(212, 71);
            this.btn_Salary.TabIndex = 29;
            this.btn_Salary.Text = "  Зарплата";
            this.btn_Salary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Salary.UseVisualStyleBackColor = false;
            this.btn_Salary.Click += new System.EventHandler(this.btn_Salary_Click);
            // 
            // btn_add_Customers
            // 
            this.btn_add_Customers.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_Customers.FlatAppearance.BorderSize = 0;
            this.btn_add_Customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_Customers.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_Customers.ForeColor = System.Drawing.Color.Black;
            this.btn_add_Customers.Image = global::Radiator.Properties.Resources.RadiatorCustomr;
            this.btn_add_Customers.Location = new System.Drawing.Point(0, 24);
            this.btn_add_Customers.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btn_add_Customers.Name = "btn_add_Customers";
            this.btn_add_Customers.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btn_add_Customers.Size = new System.Drawing.Size(212, 73);
            this.btn_add_Customers.TabIndex = 28;
            this.btn_add_Customers.Text = " Добавить сотрудника";
            this.btn_add_Customers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_add_Customers.UseVisualStyleBackColor = false;
            this.btn_add_Customers.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton2.Image = global::Radiator.Properties.Resources.icons8_User_Groups_50px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(283, 98);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 31;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // txbx_custmerSearch
            // 
            this.txbx_custmerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txbx_custmerSearch.CustomButton.Font = new System.Drawing.Font("Century Schoolbook", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_custmerSearch.CustomButton.Image = null;
            this.txbx_custmerSearch.CustomButton.Location = new System.Drawing.Point(430, 2);
            this.txbx_custmerSearch.CustomButton.Name = "";
            this.txbx_custmerSearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txbx_custmerSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbx_custmerSearch.CustomButton.TabIndex = 1;
            this.txbx_custmerSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbx_custmerSearch.CustomButton.UseSelectable = true;
            this.txbx_custmerSearch.CustomButton.Visible = false;
            this.txbx_custmerSearch.DisplayIcon = true;
            this.txbx_custmerSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txbx_custmerSearch.Icon = global::Radiator.Properties.Resources.icons8_Search_26px_21;
            this.txbx_custmerSearch.Lines = new string[0];
            this.txbx_custmerSearch.Location = new System.Drawing.Point(874, 98);
            this.txbx_custmerSearch.MaxLength = 32767;
            this.txbx_custmerSearch.Name = "txbx_custmerSearch";
            this.txbx_custmerSearch.PasswordChar = '\0';
            this.txbx_custmerSearch.PromptText = "Поиск";
            this.txbx_custmerSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbx_custmerSearch.SelectedText = "";
            this.txbx_custmerSearch.SelectionLength = 0;
            this.txbx_custmerSearch.SelectionStart = 0;
            this.txbx_custmerSearch.ShortcutsEnabled = true;
            this.txbx_custmerSearch.Size = new System.Drawing.Size(456, 28);
            this.txbx_custmerSearch.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbx_custmerSearch.TabIndex = 30;
            this.txbx_custmerSearch.UseCustomBackColor = true;
            this.txbx_custmerSearch.UseSelectable = true;
            this.txbx_custmerSearch.UseStyleColors = true;
            this.txbx_custmerSearch.WaterMark = "Поиск";
            this.txbx_custmerSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbx_custmerSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txbx_custmerSearch.TextChanged += new System.EventHandler(this.btn_custmomerSearch_OnTextChange);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1421, 698);
            this.Controls.Add(this.cbx_metka);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.txbx_custmerSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_Customers);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(967, 516);
            this.Name = "HomeForm";
            this.Text = "Архив";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HomeForm_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_user;
        private Bunifu.Framework.UI.BunifuImageButton btn_cancel;
        private Bunifu.Framework.UI.BunifuImageButton btn_max;
        private Bunifu.Framework.UI.BunifuImageButton btn_min;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Otpusk;
        private System.Windows.Forms.Button btn_EditCustomer;
        private System.Windows.Forms.Button btn_DeleteCustomer;
        private System.Windows.Forms.Button add_Journal;
        private System.Windows.Forms.Button btn_Salary;
        private System.Windows.Forms.Button btn_add_Customers;
        private MetroFramework.Controls.MetroTextBox txbx_custmerSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отметитьНаУдалениеToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbx_metka;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label2;
    }
}

