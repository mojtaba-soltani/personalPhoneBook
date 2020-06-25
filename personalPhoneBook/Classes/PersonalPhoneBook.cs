using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnectionNamespace.Classes;

namespace PersonalPhoneBookNamespace.Classes
{
    public class PersonalPhoneBook
    {
        public string successMessage ="";
        public string errorMessage ="";
        //Add New Person To Database
        public string AddNewPerson(string name, string family, string age, string email, string sex, string tel, string adress)

        {
            try
            {
                DatabaseConnection.OPenConnection();
                DatabaseConnection.CreateCommand("INSERT INTO personPhoneBook_tb" +
                    "(pName,pFamily,pAge,pEmail,pSex,pTel,pAdress)" +
                    "VALUES(@NAME,@FAMILY,@AGE,@EMAIL,@SEX,@TEL,@ADRESS)"
                    );
                DatabaseConnection.BindValues("@NAME", name);
                DatabaseConnection.BindValues("@FAMILY", family);
                DatabaseConnection.BindValues("@AGE", Convert.ToString(age));
                DatabaseConnection.BindValues("@EMAIL", email);
                DatabaseConnection.BindValues("@SEX", sex);
                DatabaseConnection.BindValues("@TEL", tel);
                DatabaseConnection.BindValues("@ADRESS", adress);
                DatabaseConnection.ExecuteNonQueries();
                successMessage = "فرد جدید با موفقیت به دفترچه تلفن شما اضافه شد";
                return successMessage;
            }
            catch(Exception e)
            {
                errorMessage = e.Message;
                return errorMessage;
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
            
        }
        
        //Show All Persons In DataGridView
        public object ShowAllPersons()
        {
            DatabaseConnection.OPenConnection();
            DatabaseConnection.CreateCommand("SELECT * FROM personPhoneBook_tb");
            return DatabaseConnection.ExecuteQueries();
        }

        //Select Person By ID
        public DataTable SelectPersonByID(int personID)
        {
            DatabaseConnection.OPenConnection();
            DatabaseConnection.CreateCommand($"SELECT * FROM personPhoneBook_tb WHERE id={personID}");
            return DatabaseConnection.ExecuteQueries();
        }

        //Select Person By Sex
        public DataTable SelectPersonBySex(int pSex)
        {
            DatabaseConnection.OPenConnection();
            DatabaseConnection.CreateCommand($"SELECT * FROM personPhoneBook_tb WHERE pSex={pSex}");
            return DatabaseConnection.ExecuteQueries();
        }

        //Delete Person From Database
        public bool DeletePerson(int personID)
        {
            try
            {
                DatabaseConnection.OPenConnection();
                DatabaseConnection.CreateCommand("DELETE FROM personPhoneBook_tb WHERE id = @personID");
                DatabaseConnection.BindValues("@personID", personID.ToString());
                DatabaseConnection.ExecuteNonQueries();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        public string UpdatePerson(int personID, string name, string family, string age, string email, string sex, string tel, string adress)
        {
            try
            {
                DatabaseConnection.OPenConnection();
                DatabaseConnection.CreateCommand("UPDATE personPhoneBook_tb SET pName = @NAME,pFamily = @FAMILY,pAge = @AGE,pEmail = @EMAIL,pSex = @SEX,pTel = @TEL,pAdress = @ADRESS WHERE id=@ID");
                DatabaseConnection.BindValues("@ID", Convert.ToString(personID));
                DatabaseConnection.BindValues("@NAME", name);
                DatabaseConnection.BindValues("@FAMILY", family);
                DatabaseConnection.BindValues("@AGE", Convert.ToString(age));
                DatabaseConnection.BindValues("@EMAIL", email);
                DatabaseConnection.BindValues("@SEX", sex);
                DatabaseConnection.BindValues("@TEL", tel);
                DatabaseConnection.BindValues("@ADRESS", adress);
                DatabaseConnection.ExecuteNonQueries();
                successMessage = "اطلاعات با موفقیت ویرایش شد";
                return successMessage;
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return errorMessage;
            }
            finally
            {
                DatabaseConnection.CloseConnection();
            }
        }

        public DataTable Search(string parameter)
        {
            DatabaseConnection.OPenConnection();
            DatabaseConnection.CreateCommand("SELECT * FROM personPhoneBook_tb WHERE pName LIKE @parameter OR pFamily LIKE @parameter");
            DatabaseConnection.BindValues("@parameter", "%" + parameter.ToString() + "%" );
            return DatabaseConnection.ExecuteQueries();
        }
    }
}
