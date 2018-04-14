namespace Radiator
{
    partial class EditPersonalCard
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
            this.dtp_prik = new System.Windows.Forms.DateTimePicker();
            this.cbx_deistv = new System.Windows.Forms.ComboBox();
            this.btn_AddNewJournal = new System.Windows.Forms.Button();
            this.txbx_Prikazn = new System.Windows.Forms.TextBox();
            this.txbx_Pod = new System.Windows.Forms.TextBox();
            this.txbx_Dol = new System.Windows.Forms.TextBox();
            this.txbx_DataPrikaz = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_prik
            // 
            this.dtp_prik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_prik.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtp_prik.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_prik.Location = new System.Drawing.Point(144, 270);
            this.dtp_prik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_prik.Name = "dtp_prik";
            this.dtp_prik.Size = new System.Drawing.Size(470, 25);
            this.dtp_prik.TabIndex = 30;
            this.dtp_prik.Value = new System.DateTime(2017, 12, 16, 0, 0, 0, 0);
            // 
            // cbx_deistv
            // 
            this.cbx_deistv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_deistv.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_deistv.FormattingEnabled = true;
            this.cbx_deistv.Location = new System.Drawing.Point(144, 98);
            this.cbx_deistv.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.cbx_deistv.Name = "cbx_deistv";
            this.cbx_deistv.Size = new System.Drawing.Size(470, 28);
            this.cbx_deistv.TabIndex = 29;
            // 
            // btn_AddNewJournal
            // 
            this.btn_AddNewJournal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_AddNewJournal.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddNewJournal.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_AddNewJournal.Location = new System.Drawing.Point(409, 325);
            this.btn_AddNewJournal.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btn_AddNewJournal.Name = "btn_AddNewJournal";
            this.btn_AddNewJournal.Size = new System.Drawing.Size(205, 25);
            this.btn_AddNewJournal.TabIndex = 28;
            this.btn_AddNewJournal.Text = "Изменить";
            this.btn_AddNewJournal.UseVisualStyleBackColor = false;
            this.btn_AddNewJournal.Click += new System.EventHandler(this.btn_AddNewJournal_Click);
            // 
            // txbx_Prikazn
            // 
            this.txbx_Prikazn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_Prikazn.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_Prikazn.Location = new System.Drawing.Point(144, 222);
            this.txbx_Prikazn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txbx_Prikazn.Name = "txbx_Prikazn";
            this.txbx_Prikazn.Size = new System.Drawing.Size(470, 25);
            this.txbx_Prikazn.TabIndex = 27;
            // 
            // txbx_Pod
            // 
            this.txbx_Pod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_Pod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbx_Pod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbx_Pod.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_Pod.Location = new System.Drawing.Point(144, 186);
            this.txbx_Pod.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txbx_Pod.Name = "txbx_Pod";
            this.txbx_Pod.Size = new System.Drawing.Size(470, 25);
            this.txbx_Pod.TabIndex = 26;
            // 
            // txbx_Dol
            // 
            this.txbx_Dol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txbx_Dol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbx_Dol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbx_Dol.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_Dol.Location = new System.Drawing.Point(144, 144);
            this.txbx_Dol.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.txbx_Dol.Name = "txbx_Dol";
            this.txbx_Dol.Size = new System.Drawing.Size(470, 25);
            this.txbx_Dol.TabIndex = 25;
            // 
            // txbx_DataPrikaz
            // 
            this.txbx_DataPrikaz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txbx_DataPrikaz.AutoSize = true;
            this.txbx_DataPrikaz.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_DataPrikaz.Location = new System.Drawing.Point(19, 270);
            this.txbx_DataPrikaz.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txbx_DataPrikaz.Name = "txbx_DataPrikaz";
            this.txbx_DataPrikaz.Size = new System.Drawing.Size(101, 20);
            this.txbx_DataPrikaz.TabIndex = 24;
            this.txbx_DataPrikaz.Text = "Дата приказа ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(19, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "№ приказа";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(19, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Подразделение";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Должность";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Действие";
            // 
            // EditPersonalCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 390);
            this.Controls.Add(this.dtp_prik);
            this.Controls.Add(this.cbx_deistv);
            this.Controls.Add(this.btn_AddNewJournal);
            this.Controls.Add(this.txbx_Prikazn);
            this.Controls.Add(this.txbx_Pod);
            this.Controls.Add(this.txbx_Dol);
            this.Controls.Add(this.txbx_DataPrikaz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(1190, 390);
            this.MinimumSize = new System.Drawing.Size(384, 390);
            this.Name = "EditPersonalCard";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Изменение информации в личной карточке";
            this.Load += new System.EventHandler(this.EditPersonalCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_prik;
        private System.Windows.Forms.ComboBox cbx_deistv;
        private System.Windows.Forms.Button btn_AddNewJournal;
        private System.Windows.Forms.TextBox txbx_Prikazn;
        private System.Windows.Forms.TextBox txbx_Pod;
        private System.Windows.Forms.TextBox txbx_Dol;
        private System.Windows.Forms.Label txbx_DataPrikaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}