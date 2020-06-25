using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace personalPhoneBook.utility
{
    public class PersianDateAndTime
    {
         public PersianCalendar pc = new PersianCalendar();
         public DateTime thisDate = DateTime.Now;
         public string persianDateValue;
         
        public string PersianDate()
        {
            persianDateValue = pc.GetYear(thisDate).ToString() + " / " + pc.GetMonth(thisDate).ToString() + " / " + pc.GetDayOfMonth(thisDate).ToString();
            return persianDateValue;
        }
    }
}
