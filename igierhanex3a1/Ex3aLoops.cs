using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igierhanex3a1
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = Double.Parse(strMonthlyPayment);
                double monthlyInterestRate = Double.Parse(strMonthlyInterestRate);
                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                }
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int i = start;
                while (i < end)
                {
                    result += i + " ";
                    i += increment;
                } 
            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                int i = start;
                do
                {
                    result += i + " ";
                    i += increment;
                }
                while (i < end);
            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int start = Int32.Parse(strStart);
                int end = Int32.Parse(strEnd);
                int increment = Int32.Parse(strIncrement);
                if (increment <= 0) throw new Exception();
                for (int i = start; i < end; i += increment)
                {
                    result += i + " ";
                }
            }
            catch
            {
                result = "Invalid input";
            }

            return result;
        }

        public static string Calc6(string strNumbers, string strCount)
        {
            string result = "0";
            int startIdex = 0;
            int sum = 0;
            try
            {
                int count = Int32.Parse(strCount);
                int i = 0;
                while (i < count)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIdex);
                    string strNumber = strNumbers.Substring(startIdex, endIndex - startIdex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIdex = endIndex + 1;
                    i++;
                }
                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "0";
            int startIdex = 0;
            int sum = 0;
            try
            {
                int count = Int32.Parse(strCount);
                int i = 0;
                do
                {
                    int endIndex = strNumbers.IndexOf(' ', startIdex);
                    string strNumber = strNumbers.Substring(startIdex, endIndex - startIdex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIdex = endIndex + 1;
                    i++;
                }
                while (i < count);
                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "0";
            int startIdex = 0;
            int sum = 0;
            try
            {
                int count = Int32.Parse(strCount);
                
                for (int i = 0; i < count; i++)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIdex);
                    string strNumber = strNumbers.Substring(startIdex, endIndex - startIdex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIdex = endIndex + 1;
                }
                result = sum.ToString();
            }
            catch
            {
                result = "Invalid input";
            }
            return result;
        }
    }
}
