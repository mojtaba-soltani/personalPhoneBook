namespace personalPhoneBook
{
    partial class personalPhoneBook
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
            this.showResult = new System.Windows.Forms.DataGridView();
            this.ppb_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppb_fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppb_fLame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppb_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppb_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppb_sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppb_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewPersonBtn = new System.Windows.Forms.Button();
            this.deletePersonBtn = new System.Windows.Forms.Button();
            this.updatePersonBtn = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.sexFilterLabel = new System.Windows.Forms.Label();
            this.femaleCheckbox = new System.Windows.Forms.CheckBox();
            this.maleCheckbox = new System.Windows.Forms.CheckBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.nationalCodeLabel = new System.Windows.Forms.Label();
            this.NationalCodeTxt = new System.Windows.Forms.TextBox();
            this.nationalCodeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showResult)).BeginInit();
            this.SuspendLayout();
            // 
            // showResult
            // 
            this.showResult.AllowUserToAddRows = false;
            this.showResult.AllowUserToDeleteRows = false;
            this.showResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ppb_order,
            this.ppb_fName,
            this.ppb_fLame,
            this.ppb_age,
            this.ppb_email,
            this.ppb_sex,
            this.ppb_tel});
            this.showResult.Location = new System.Drawing.Point(14, 142);
            this.showResult.Name = "showResult";
            this.showResult.ReadOnly = true;
            this.showResult.Size = new System.Drawing.Size(800, 600);
            this.showResult.TabIndex = 0;
            // 
            // ppb_order
            // 
            this.ppb_order.DataPropertyName = "id";
            this.ppb_order.HeaderText = "ردیف";
            this.ppb_order.Name = "ppb_order";
            this.ppb_order.ReadOnly = true;
            // 
            // ppb_fName
            // 
            this.ppb_fName.DataPropertyName = "pName";
            this.ppb_fName.HeaderText = "نام";
            this.ppb_fName.Name = "ppb_fName";
            this.ppb_fName.ReadOnly = true;
            // 
            // ppb_fLame
            // 
            this.ppb_fLame.DataPropertyName = "pFamily";
            this.ppb_fLame.HeaderText = "نام خانوادگی";
            this.ppb_fLame.Name = "ppb_fLame";
            this.ppb_fLame.ReadOnly = true;
            // 
            // ppb_age
            // 
            this.ppb_age.DataPropertyName = "pAge";
            this.ppb_age.HeaderText = "سن";
            this.ppb_age.Name = "ppb_age";
            this.ppb_age.ReadOnly = true;
            // 
            // ppb_email
            // 
            this.ppb_email.DataPropertyName = "pEmail";
            this.ppb_email.HeaderText = "ایمیل";
            this.ppb_email.Name = "ppb_email";
            this.ppb_email.ReadOnly = true;
            // 
            // ppb_sex
            // 
            this.ppb_sex.DataPropertyName = "pSex";
            this.ppb_sex.HeaderText = "جنسیت";
            this.ppb_sex.Name = "ppb_sex";
            this.ppb_sex.ReadOnly = true;
            // 
            // ppb_tel
            // 
            this.ppb_tel.DataPropertyName = "pTel";
            this.ppb_tel.HeaderText = "تلفن";
            this.ppb_tel.Name = "ppb_tel";
            this.ppb_tel.ReadOnly = true;
            // 
            // addNewPersonBtn
            // 
            this.addNewPersonBtn.Location = new System.Drawing.Point(12, 12);
            this.addNewPersonBtn.Name = "addNewPersonBtn";
            this.addNewPersonBtn.Size = new System.Drawing.Size(100, 23);
            this.addNewPersonBtn.TabIndex = 1;
            this.addNewPersonBtn.Text = "ثبت فرد جدید";
            this.addNewPersonBtn.UseVisualStyleBackColor = true;
            this.addNewPersonBtn.Click += new System.EventHandler(this.addNewPersonBtn_Click);
            // 
            // deletePersonBtn
            // 
            this.deletePersonBtn.Location = new System.Drawing.Point(118, 12);
            this.deletePersonBtn.Name = "deletePersonBtn";
            this.deletePersonBtn.Size = new System.Drawing.Size(99, 23);
            this.deletePersonBtn.TabIndex = 2;
            this.deletePersonBtn.Text = "حذف فرد";
            this.deletePersonBtn.UseVisualStyleBackColor = true;
            this.deletePersonBtn.Click += new System.EventHandler(this.deletePersonBtn_Click);
            // 
            // updatePersonBtn
            // 
            this.updatePersonBtn.Location = new System.Drawing.Point(223, 12);
            this.updatePersonBtn.Name = "updatePersonBtn";
            this.updatePersonBtn.Size = new System.Drawing.Size(130, 23);
            this.updatePersonBtn.TabIndex = 3;
            this.updatePersonBtn.Text = "ویرایش اطلاعات فرد";
            this.updatePersonBtn.UseVisualStyleBackColor = true;
            this.updatePersonBtn.Click += new System.EventHandler(this.updatePersonBtn_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 64);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(113, 14);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "جستجو بر اساس نام";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(147, 61);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(247, 22);
            this.searchTxt.TabIndex = 5;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // sexFilterLabel
            // 
            this.sexFilterLabel.AutoSize = true;
            this.sexFilterLabel.Location = new System.Drawing.Point(16, 104);
            this.sexFilterLabel.Name = "sexFilterLabel";
            this.sexFilterLabel.Size = new System.Drawing.Size(123, 14);
            this.sexFilterLabel.TabIndex = 6;
            this.sexFilterLabel.Text = "فیلتر بر اساس جنسیت";
            // 
            // femaleCheckbox
            // 
            this.femaleCheckbox.AutoSize = true;
            this.femaleCheckbox.Location = new System.Drawing.Point(147, 104);
            this.femaleCheckbox.Name = "femaleCheckbox";
            this.femaleCheckbox.Size = new System.Drawing.Size(49, 18);
            this.femaleCheckbox.TabIndex = 7;
            this.femaleCheckbox.Text = "خانم";
            this.femaleCheckbox.UseVisualStyleBackColor = true;
            this.femaleCheckbox.Click += new System.EventHandler(this.femaleCheckbox_Click);
            // 
            // maleCheckbox
            // 
            this.maleCheckbox.AutoSize = true;
            this.maleCheckbox.Location = new System.Drawing.Point(224, 104);
            this.maleCheckbox.Name = "maleCheckbox";
            this.maleCheckbox.Size = new System.Drawing.Size(38, 18);
            this.maleCheckbox.TabIndex = 8;
            this.maleCheckbox.Text = "آقا";
            this.maleCheckbox.UseVisualStyleBackColor = true;
            this.maleCheckbox.Click += new System.EventHandler(this.maleCheckbox_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(689, 12);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLabel.Size = new System.Drawing.Size(29, 14);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "تاریخ";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(565, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLabel.Size = new System.Drawing.Size(41, 14);
            this.timeLabel.TabIndex = 10;
            this.timeLabel.Text = "ساعت";
            // 
            // nationalCodeLabel
            // 
            this.nationalCodeLabel.AutoSize = true;
            this.nationalCodeLabel.Location = new System.Drawing.Point(414, 64);
            this.nationalCodeLabel.Name = "nationalCodeLabel";
            this.nationalCodeLabel.Size = new System.Drawing.Size(116, 14);
            this.nationalCodeLabel.TabIndex = 11;
            this.nationalCodeLabel.Text = "اعتبار سنجی کد ملی";
            // 
            // NationalCodeTxt
            // 
            this.NationalCodeTxt.Location = new System.Drawing.Point(538, 61);
            this.NationalCodeTxt.Name = "NationalCodeTxt";
            this.NationalCodeTxt.Size = new System.Drawing.Size(189, 22);
            this.NationalCodeTxt.TabIndex = 12;
            // 
            // nationalCodeBtn
            // 
            this.nationalCodeBtn.Location = new System.Drawing.Point(732, 60);
            this.nationalCodeBtn.Name = "nationalCodeBtn";
            this.nationalCodeBtn.Size = new System.Drawing.Size(75, 23);
            this.nationalCodeBtn.TabIndex = 13;
            this.nationalCodeBtn.Text = "کلیک کنید";
            this.nationalCodeBtn.UseVisualStyleBackColor = true;
            this.nationalCodeBtn.Click += new System.EventHandler(this.nationalCodeBtn_Click);
            // 
            // personalPhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 485);
            this.Controls.Add(this.nationalCodeBtn);
            this.Controls.Add(this.NationalCodeTxt);
            this.Controls.Add(this.nationalCodeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.maleCheckbox);
            this.Controls.Add(this.femaleCheckbox);
            this.Controls.Add(this.sexFilterLabel);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.updatePersonBtn);
            this.Controls.Add(this.deletePersonBtn);
            this.Controls.Add(this.addNewPersonBtn);
            this.Controls.Add(this.showResult);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "personalPhoneBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "دفترچه تلفن";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showResult;
        private System.Windows.Forms.Button addNewPersonBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_fLame;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppb_tel;
        private System.Windows.Forms.Button deletePersonBtn;
        private System.Windows.Forms.Button updatePersonBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label sexFilterLabel;
        private System.Windows.Forms.CheckBox femaleCheckbox;
        private System.Windows.Forms.CheckBox maleCheckbox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label nationalCodeLabel;
        private System.Windows.Forms.TextBox NationalCodeTxt;
        private System.Windows.Forms.Button nationalCodeBtn;
    }
}

