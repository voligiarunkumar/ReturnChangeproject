using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ReturnChangeProject
{
    public class CaluculateChange
    {
        public int Caluculation(double paid, double cost)
        {

            List<int> values = new List<int> { 10000, 5000, 2000, 1000, 500, 100, 25, 10, 5, 1 };
            List<string> values1 = new List<string> { "100 Rupees", "50 Rupees", "20 Rupees", "10 Rupees", "5 Rupees", "1 Rupeess", "25 Paise", "10 Paise", "5 Paise", "1 Paise" };
            Console.WriteLine("Due amount  is" + cost);
            Console.WriteLine("Amount paid by the customer is:" + paid);
            //using Exception handling here
            try
            {
                
                    List<int> exc = new List<int> { };
                    List<int> cur = new List<int> { };
                    cur.AddRange(values);
                    int chg = (int)((paid - cost) * 100);
                    while (chg > 0)
                    {
                        int removed = cur[0];
                        exc.Add((chg / removed));
                        chg = chg - (exc[exc.Count - 1] * removed);
                        cur.RemoveAt(0);
                    }
                    int i = 0;
                    Console.WriteLine("Change in return would be:");
                    foreach (int item in exc)   
                    {
                        if (item > 0) { Console.WriteLine(item + "*" + values1[i]); }
                        i++;
                    }

                
            } 
            catch(Exception)
            {
                Console.WriteLine("you have entered worng input");
            }
            return 1 ;
        }

    }
}
