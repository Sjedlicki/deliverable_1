using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Currency_Format_Converter
{   
    class Program
    {
        static void Main(string[] args)
        {

            float[] values = new float[3];
            List<float> num = new List<float>();
            bool repeat = true;


            while (repeat == true)
            {
                Console.Write("Input Random Value 1: ");
                values[0] = float.Parse(Console.ReadLine());
                Console.Write("Input Random Value 2: ");
                values[1] = float.Parse(Console.ReadLine());
                Console.Write("Input Random Value 3: ");
                values[2] = float.Parse(Console.ReadLine());

                num.Add(values[0]);
                num.Add(values[1]);
                num.Add(values[2]);
                num.Sum();
                num.Max();
                num.Min();
                num.Average();

                decimal currency = (decimal)num.Sum();
                string format = $"{currency:C}";

                Console.WriteLine(); // ADDING SPACING
                Console.WriteLine(); // ADDING SPACING

                Console.WriteLine("Total: " + num.Sum());
                Console.WriteLine("Highest: " + num.Max());
                Console.WriteLine("Lowest: " + num.Min());
                Console.WriteLine("Average: " + num.Average());

                Console.WriteLine(); // ADDING SPACING
                Console.WriteLine(); // ADDING SPACING

                Console.WriteLine("US: {0}", currency.ToString("C", new System.Globalization.CultureInfo("en-US")));
                Console.WriteLine("Swedish: {0}", currency.ToString("C", new System.Globalization.CultureInfo("sv-SE")));
                Console.WriteLine("Japanese: {0} ", currency.ToString("C", new System.Globalization.CultureInfo("ja-JP")));
                Console.WriteLine("Thai: : {0}", currency.ToString("C", new System.Globalization.CultureInfo("th-TH")));

                //Console.WriteLine("US: " + format);
                //Console.WriteLine("Swedish: " + format + "kr");
                //Console.WriteLine("Japanese: ￥" + format);
                //Console.WriteLine("Thai: ฿" +format);

                //Console.WriteLine("Total: " + (values[0] + values[1] + values[2]));
                //Console.WriteLine("Average :" + (values[0] + values[1] + values[2])/(3));
                //Console.WriteLine((values));

                Console.WriteLine(); // ADDING SPACING
                Console.WriteLine(); // ADDING SPACING

                bool invld = true;
                while (invld == true)
                {
                    Console.Write("Would you like to enter new values? Y/N? ");
                    string go = Console.ReadLine();
                    if ((go == "Y") || (go == "y") || (go == "Yes") || (go == "yes"))
                    {
                        repeat = true;
                        Console.Clear();
                        break;

                    }
                    else if ((go == "N") || (go == "n") || (go == "No") || (go == "no"))
                    {
                        repeat = false;
                        break;
                    }
                    else if ((go != "Y") || (go != "y") || (go != "N") || (go != "n"))
                    {
                        Console.Beep(); Console.Beep(); Console.Beep();
                        Console.WriteLine("Please enter a valid response");
                    }
                    else
                    {
                        repeat = false;
                    }
                }
            }
            Console.WriteLine(); // ADDING SPACING
            Console.WriteLine("Thanks for converting currency with us today! \nPress any key to exit. . . ");
            Console.ReadKey();
        }
    }
}
