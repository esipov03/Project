namespace Radiator
{
    partial class AddOtpusk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOtpusk));
            this.cb_Prich = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_S = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Po = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_SaveOtpusk = new System.Windows.Forms.Button();
            this.txbx_CountDay = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Prich
            // 
            this.cb_Prich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Prich.FormattingEnabled = true;
            this.cb_Prich.Location = new System.Drawing.Point(157, 108);
            this.cb_Prich.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Prich.Name = "cb_Prich";
            this.cb_Prich.Size = new System.Drawing.Size(514, 25);
            this.cb_Prich.TabIndex = 1;
            // 
            // dateTimePicker_S
            // 
            this.dateTimePicker_S.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_S.Location = new System.Drawing.Point(157, 184);
            this.dateTimePicker_S.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_S.Name = "dateTimePicker_S";
            this.dateTimePicker_S.Size = new System.Drawing.Size(514, 23);
            this.dateTimePicker_S.TabIndex = 2;
            this.dateTimePicker_S.Value = new System.DateTime(2017, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker_S.ValueChanged += new System.EventHandler(this.dateTimePicker_S_ValueChanged);
            this.dateTimePicker_S.ClientSizeChanged += new System.EventHandler(this.dateTimePicker_S_ClientSizeChanged);
            this.dateTimePicker_S.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker_S_KeyPress);
            // 
            // dateTimePicker_Po
            // 
            this.dateTimePicker_Po.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_Po.Location = new System.Drawing.Point(157, 224);
            this.dateTimePicker_Po.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_Po.Name = "dateTimePicker_Po";
            this.dateTimePicker_Po.Size = new System.Drawing.Size(514, 23);
            this.dateTimePicker_Po.TabIndex = 3;
            this.dateTimePicker_Po.Value = new System.DateTime(2017, 12, 16, 0, 0, 0, 0);
            this.dateTimePicker_Po.ValueChanged += new System.EventHandler(this.dateTimePicker_Po_ValueChanged);
            this.dateTimePicker_Po.ClientSizeChanged += new System.EventHandler(this.dateTimePicker_Po_ClientSizeChanged);
            this.dateTimePicker_Po.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePicker_Po_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Причина";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата начала";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата конца";
            // 
            // bnt_SaveOtpusk
            // 
            this.bnt_SaveOtpusk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_SaveOtpusk.Location = new System.Drawing.Point(452, 331);
            this.bnt_SaveOtpusk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_SaveOtpusk.Name = "bnt_SaveOtpusk";
            this.bnt_SaveOtpusk.Size = new System.Drawing.Size(219, 30);
            this.bnt_SaveOtpusk.TabIndex = 8;
            this.bnt_SaveOtpusk.Text = "Добавить отпуск сотруднику";
            this.bnt_SaveOtpusk.UseVisualStyleBackColor = true;
            this.bnt_SaveOtpusk.Click += new System.EventHandler(this.bnt_SaveOtpusk_Click);
            // 
            // txbx_CountDay
            // 
            this.txbx_CountDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_CountDay.Location = new System.Drawing.Point(157, 277);
            this.txbx_CountDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbx_CountDay.Name = "txbx_CountDay";
            this.txbx_CountDay.Size = new System.Drawing.Size(234, 23);
            this.txbx_CountDay.TabIndex = 9;
            this.txbx_CountDay.TextChanged += new System.EventHandler(this.txbx_CountDay_TextChanged);
            this.txbx_CountDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbx_CountDay_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кол-во дней";
            // 
            // AddOtpusk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 391);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbx_CountDay);
            this.Controls.Add(this.bnt_SaveOtpusk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_Po);
            this.Controls.Add(this.dateTimePicker_S);
            this.Controls.Add(this.cb_Prich);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1097, 391);
            this.MinimumSize = new System.Drawing.Size(610, 391);
            this.Name = "AddOtpusk";
            this.Padding = new System.Windows.Forms.Padding(27, 78, 27, 26);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Добавление отпуска";
            this.Load += new System.EventHandler(this.Otpusk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Prich;
        private System.Windows.Forms.DateTimePicker dateTimePicker_S;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Po;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_SaveOtpusk;
        private System.Windows.Forms.TextBox txbx_CountDay;
        private System.Windows.Forms.Label label6;
    }
}