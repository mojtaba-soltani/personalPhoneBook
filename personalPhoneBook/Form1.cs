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
using personalPhoneBook.utility;
using NationalCodeNameSpace.utility;



namespace personalPhoneBook
{
    public partial class personalPhoneBook : Form
    {
        //GW: Grid View
        public PersonalPhoneBook PersonalPhoneBook;
        public PersianDateAndTime PersianDateAndTime;
        Timer timer = new Timer();

        public personalPhoneBook()
        {
            InitializeComponent();
            PersonalPhoneBook = new PersonalPhoneBook();
            PersianDateAndTime = new PersianDateAndTime();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.dateLabel.Text = PersianDateAndTime.PersianDate() + " :تاریخ ";
            this.timeLabel.Text = DateTime.Now.ToString("HH:mm:ss") + " :ساعت ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showResult.DataSource = PersonalPhoneBook.ShowAllPersons();
        }

        private void addNewPersonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addOrEditPerson frm = new addOrEditPerson();
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    showResult.DataSource = PersonalPhoneBook.ShowAllPersons();
                }
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void deletePersonBtn_Click(object sender, EventArgs e)
        {
            if (showResult.CurrentRow != null)
            {
                int personID = int.Parse(showResult.CurrentRow.Cells[0].Value.ToString());
                string name = showResult.CurrentRow.Cells[1].Value.ToString();
                string family = showResult.CurrentRow.Cells[2].Value.ToString();
                string fullName = " " + name + " " + family + " ";
                if (MessageBox.Show($"آیا از حذف کاربر {fullName} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    if (PersonalPhoneBook.DeletePerson(personID))
                    {
                        MessageBox.Show("عملیات حذف با موفقیت انجام شد","موفقیت",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
                        showResult.DataSource = PersonalPhoneBook.ShowAllPersons();
                    }
                }
            }
        }

        private void updatePersonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int personID = int.Parse(showResult.CurrentRow.Cells[0].Value.ToString());
                addOrEditPerson frm = new addOrEditPerson();
                frm.formName = personID;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    showResult.DataSource = PersonalPhoneBook.ShowAllPersons();
                }
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            showResult.DataSource = PersonalPhoneBook.Search(searchTxt.Text);
        }

        private void femaleCheckbox_Click(object sender, EventArgs e)
        {
            
            if (femaleCheckbox.Checked)
            {
                int female = 2;
                showResult.DataSource = PersonalPhoneBook.SelectPersonBySex(female);
            }
            else
            {
                showResult.DataSource = PersonalPhoneBook.ShowAllPersons();
            }
        }

        private void maleCheckbox_Click(object sender, EventArgs e)
        {
            if (maleCheckbox.Checked)
            {
                int male = 1;
                showResult.DataSource = PersonalPhoneBook.SelectPersonBySex(male);
            }
            else
            {
                showResult.DataSource = PersonalPhoneBook.ShowAllPersons();
            }
        }

        private void nationalCodeBtn_Click(object sender, EventArgs e)
        {
            if (NationalCode.check_code(NationalCodeTxt.Text))
            {
                MessageBox.Show("کد ملی وارد شده صحیح می باشد");
            }
            else
            {
                MessageBox.Show("کد ملی وارد شده صحیح نمی باشد");
            }
        }
    }
}
