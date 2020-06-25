namespace personalPhoneBook
{
    partial class addOrEditPerson
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.familyTxt = new System.Windows.Forms.TextBox();
            this.familyLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.NumericUpDown();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sexTxt = new System.Windows.Forms.TextBox();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.telLabel = new System.Windows.Forms.Label();
            this.adressTxt = new System.Windows.Forms.TextBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.btnNewPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(726, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(20, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "نام";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(415, 33);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(294, 21);
            this.nameTxt.TabIndex = 1;
            // 
            // familyTxt
            // 
            this.familyTxt.Location = new System.Drawing.Point(23, 33);
            this.familyTxt.Name = "familyTxt";
            this.familyTxt.Size = new System.Drawing.Size(294, 21);
            this.familyTxt.TabIndex = 3;
            // 
            // familyLabel
            // 
            this.familyLabel.AutoSize = true;
            this.familyLabel.Location = new System.Drawing.Point(323, 36);
            this.familyLabel.Name = "familyLabel";
            this.familyLabel.Size = new System.Drawing.Size(65, 13);
            this.familyLabel.TabIndex = 2;
            this.familyLabel.Text = "نام خانوادگی";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(726, 94);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "سن";
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(415, 86);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(294, 21);
            this.ageTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(23, 86);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(294, 21);
            this.emailTxt.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(323, 89);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "ایمیل";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(726, 150);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(44, 13);
            this.sexLabel.TabIndex = 8;
            this.sexLabel.Text = "جنسیت";
            // 
            // sexTxt
            // 
            this.sexTxt.Location = new System.Drawing.Point(415, 147);
            this.sexTxt.Name = "sexTxt";
            this.sexTxt.Size = new System.Drawing.Size(294, 21);
            this.sexTxt.TabIndex = 9;
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(23, 147);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(294, 21);
            this.telTxt.TabIndex = 11;
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Location = new System.Drawing.Point(323, 150);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(28, 13);
            this.telLabel.TabIndex = 10;
            this.telLabel.Text = "تلفن";
            // 
            // adressTxt
            // 
            this.adressTxt.Location = new System.Drawing.Point(23, 205);
            this.adressTxt.Multiline = true;
            this.adressTxt.Name = "adressTxt";
            this.adressTxt.Size = new System.Drawing.Size(686, 124);
            this.adressTxt.TabIndex = 13;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Location = new System.Drawing.Point(726, 208);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(32, 13);
            this.adressLabel.TabIndex = 12;
            this.adressLabel.Text = "آدرس";
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.Location = new System.Drawing.Point(23, 354);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(75, 23);
            this.btnNewPerson.TabIndex = 15;
            this.btnNewPerson.Text = "ثبت کاربر";
            this.btnNewPerson.UseVisualStyleBackColor = true;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // addOrEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewPerson);
            this.Controls.Add(this.adressTxt);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.telLabel);
            this.Controls.Add(this.sexTxt);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.familyTxt);
            this.Controls.Add(this.familyLabel);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "addOrEditPerson";
            this.Text = "addOrEditPerson";
            this.Load += new System.EventHandler(this.addOrEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox familyTxt;
        private System.Windows.Forms.Label familyLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown ageTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox sexTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.TextBox adressTxt;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Button btnNewPerson;
    }
}