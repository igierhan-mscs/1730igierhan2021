using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igierhan3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            for (int i = 0; i < days.Length; i++) ;
                
            return days.ToString();

        }

        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            search = search.Trim();
            return "";
        }

        public static int Calc2(int[] numbers)
        {
            return 0;
        }
        public static double Calc3(double[] numbers, int count)
        {
            return 0.0;
        }
        public static double Calc5(double[] numbers)
        {
            double sum = 0.0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            double average = sum / numbers.Length;
            return 0.0;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);

                foreach (int total in aboveAvgList)
                {
                    if (total > avg)
                        aboveAvgList.Add(total);
                }
            }

            return aboveAvgList.ToArray();
        }
    }
}
