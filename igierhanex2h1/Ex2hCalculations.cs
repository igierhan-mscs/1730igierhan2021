using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace igierhanex2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;
        }

        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }

        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date, dueDate;
            
            try
            {
                date = DateTime.Parse(strDateA);
                dueDate = DateTime.Parse(strDateB);
                TimeSpan timeTillDue = date - dueDate;
                result = timeTillDue.Days + " days";
            }
            catch { }

            return result;
        }

        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime date, dueDate;

            try
            {
                date = DateTime.Parse(strDateA);
                dueDate = DateTime.Parse(strDateB);
                TimeSpan timeTillDue = date - dueDate;
                result = timeTillDue.Days + " days";
                if (date > dueDate)
                    result = timeTillDue.Days + " days past due";
                else if (date <= dueDate)
                    result = "On time";
            }
            catch { }

            return result;
        }

        public static string StringCalc01(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(0, 1);
                s = s.Insert(0, "cr");
            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc02(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc03(string s)
        {
            s = s.Trim();
            if (s.Length >= 6)
            {
                s = s.Substring(2, 4).ToUpper();
            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc04(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.PadLeft(10, '*');
            }
            else return "**********";
            return s;
        }

        public static string StringCalc05(string s)
        {
            s = s.Trim();
            if (s.Length > 1)
            {
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");
            }  
            else return "Invalid input";
            return s;
        }

        public static string StringCalc06(string s)
        {
            s = s.Trim();
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace(" ", "");
            s = s.Replace("-", "");
            if (s.Length == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
            }
            else if (s.Length == 7)
            {
                s = s.Insert(3, ".");
            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc07(string s)
        {
            s = s.Trim();
            
            
            if (s.Length > 1)
            {
                s = s.ToLower();
                if (s.Contains("pioneer"))
                     return "Found";
                
                if (! s.Contains("Pioneer"))
                    return "Not found";


            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc08(string s)
        {
            string address = s;
            s = s.Trim();
            if (s.Contains(","))
            {
                int cityIndex = address.IndexOf(",");
                s = address.Substring(cityIndex + 2);
                
            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc09(string s)
        {
            
            s = s.Trim();
            if (s.Contains(" "))
            {
                string address = s;
                int cityIndex = address.LastIndexOf(" ");
                s = address.Substring(cityIndex + 1);

            }
            else return "Invalid input";
            return s;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            
            StringBuilder address1 = new StringBuilder(100);
            address1.Append(s1);
            address1.Insert(s1.Length, ", ");
            StringBuilder address2 = new StringBuilder(100);
            address2.Append(s2);
            address2.Insert(s2.Length, ", ");
            StringBuilder address3 = new StringBuilder(100);
            address3.Append(s3);
            

            s1 = address1.ToString();
            s2 = address2.ToString();
            s3 = address3.ToString();

            return s1 + s2 + s3;
        }
    }    
}