namespace Radiator
{
    partial class AddNewZp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewZp));
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_Summ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtm_DateZP = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_addZP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма";
            // 
            // txbx_Summ
            // 
            this.txbx_Summ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbx_Summ.Location = new System.Drawing.Point(153, 80);
            this.txbx_Summ.Margin = new System.Windows.Forms.Padding(5);
            this.txbx_Summ.Name = "txbx_Summ";
            this.txbx_Summ.Size = new System.Drawing.Size(259, 26);
            this.txbx_Summ.TabIndex = 2;
            this.txbx_Summ.TextChanged += new System.EventHandler(this.txbx_Summ_TextChanged);
            this.txbx_Summ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_Summ_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Месяц\\год";
            // 
            // dtm_DateZP
            // 
            this.dtm_DateZP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtm_DateZP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtm_DateZP.CustomFormat = "MMMMMM.yyyy";
            this.dtm_DateZP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_DateZP.Location = new System.Drawing.Point(153, 150);
            this.dtm_DateZP.Margin = new System.Windows.Forms.Padding(5);
            this.dtm_DateZP.Name = "dtm_DateZP";
            this.dtm_DateZP.Size = new System.Drawing.Size(259, 26);
            this.dtm_DateZP.TabIndex = 4;
            this.dtm_DateZP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_addZP
            // 
            this.btn_addZP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addZP.Location = new System.Drawing.Point(264, 212);
            this.btn_addZP.Margin = new System.Windows.Forms.Padding(5);
            this.btn_addZP.Name = "btn_addZP";
            this.btn_addZP.Size = new System.Drawing.Size(148, 37);
            this.btn_addZP.TabIndex = 8;
            this.btn_addZP.Text = "Добавить зарплату";
            this.btn_addZP.UseVisualStyleBackColor = true;
            this.btn_addZP.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewZp
            // 
            this.AcceptButton = this.btn_addZP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 288);
            this.Controls.Add(this.btn_addZP);
            this.Controls.Add(this.dtm_DateZP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_Summ);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(465, 288);
            this.MinimumSize = new System.Drawing.Size(465, 288);
            this.Name = "AddNewZp";
            this.Padding = new System.Windows.Forms.Padding(27, 98, 27, 34);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Добавление зарплаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_Summ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtm_DateZP;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_addZP;
    }
}