using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnectionNamespace.Classes;
using PersonalPhoneBookNamespace.Classes;

namespace personalPhoneBook
{
    public partial class addOrEditPerson : Form
    {
        public PersonalPhoneBook insertToDb ;
        public int formName = 0;
        public addOrEditPerson()

        {    
            InitializeComponent();
            insertToDb = new PersonalPhoneBook();
        }

        private void addOrEditPerson_Load(object sender, EventArgs e)
        {
            if (formName == 0)
            {
                this.Text = "افزودن فرد جدید";
            }
            else
            {
                this.Text = "ویرایش اطلاعات";
                DataTable dt = insertToDb.SelectPersonByID(formName);
                nameTxt.Text = dt.Rows[0][1].ToString();
                familyTxt.Text = dt.Rows[0][2].ToString();
                ageTxt.Value = int.Parse(dt.Rows[0][3].ToString());
                emailTxt.Text = dt.Rows[0][4].ToString();
                sexTxt.Text = dt.Rows[0][5].ToString();
                telTxt.Text = dt.Rows[0][6].ToString();
                adressTxt.Text = dt.Rows[0][7].ToString();
                btnNewPerson.Text = "ثبت ویرایش";
            }
        }

      
        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            if (formName == 0)
            {
                insertToDb.AddNewPerson(nameTxt.Text, familyTxt.Text, Convert.ToString(ageTxt.Value),
                emailTxt.Text, sexTxt.Text, telTxt.Text, adressTxt.Text);
                if (insertToDb.successMessage != "")
                {
                    MessageBox.Show(insertToDb.successMessage, "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else if (insertToDb.errorMessage != "")
                {
                    MessageBox.Show(insertToDb.errorMessage);
                }
            }
            else
            {
                insertToDb.UpdatePerson(formName, nameTxt.Text, familyTxt.Text, Convert.ToString(ageTxt.Value),
                emailTxt.Text, sexTxt.Text, telTxt.Text, adressTxt.Text);
                if (insertToDb.successMessage!="")
                {
                    MessageBox.Show(insertToDb.successMessage, "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else if (insertToDb.errorMessage != "")
                {
                    MessageBox.Show(insertToDb.errorMessage);
                }
            }
        }
    }
}
