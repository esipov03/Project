namespace Radiator
{
    partial class EditSalary
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
            this.btn_editSalary = new System.Windows.Forms.Button();
            this.dtm_DateZP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_Summ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_editSalary
            // 
            this.btn_editSalary.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_editSalary.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_editSalary.Location = new System.Drawing.Point(242, 199);
            this.btn_editSalary.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_editSalary.Name = "btn_editSalary";
            this.btn_editSalary.Size = new System.Drawing.Size(200, 26);
            this.btn_editSalary.TabIndex = 13;
            this.btn_editSalary.Text = "Изменить";
            this.btn_editSalary.UseVisualStyleBackColor = true;
            this.btn_editSalary.Click += new System.EventHandler(this.btn_editSalary_Click);
            // 
            // dtm_DateZP
            // 
            this.dtm_DateZP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtm_DateZP.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtm_DateZP.CustomFormat = "MMMMMM.yyyy";
            this.dtm_DateZP.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtm_DateZP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm_DateZP.Location = new System.Drawing.Point(108, 141);
            this.dtm_DateZP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtm_DateZP.Name = "dtm_DateZP";
            this.dtm_DateZP.Size = new System.Drawing.Size(334, 25);
            this.dtm_DateZP.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Месяц\\год";
            // 
            // txbx_Summ
            // 
            this.txbx_Summ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_Summ.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_Summ.Location = new System.Drawing.Point(108, 73);
            this.txbx_Summ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbx_Summ.Name = "txbx_Summ";
            this.txbx_Summ.Size = new System.Drawing.Size(334, 25);
            this.txbx_Summ.TabIndex = 10;
            this.txbx_Summ.TextChanged += new System.EventHandler(this.txbx_Summ_TextChanged);
            this.txbx_Summ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_Summ_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сумма";
            // 
            // EditSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 278);
            this.Controls.Add(this.btn_editSalary);
            this.Controls.Add(this.dtm_DateZP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_Summ);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(911, 278);
            this.MinimumSize = new System.Drawing.Size(268, 278);
            this.Name = "EditSalary";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editSalary;
        private System.Windows.Forms.DateTimePicker dtm_DateZP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_Summ;
        private System.Windows.Forms.Label label1;
    }
}