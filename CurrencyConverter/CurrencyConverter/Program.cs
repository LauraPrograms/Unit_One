using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double amountOne, amountTwo, amountThree, amountSum, amountAverage;
                string input;
                
               
                Console.WriteLine("Welcome to Currency Converter. There seems to be three of you. How much money does the first person have?");
                input = Console.ReadLine();
                bool success = Double.TryParse(input, out amountOne);

                Console.WriteLine("How much does the second person have?");
                input = Console.ReadLine();
                success = Double.TryParse(input, out amountTwo);

                Console.WriteLine("What about the third person?");
                input = Console.ReadLine();
                success = Double.TryParse(input, out amountThree);

                //first part of the deliverable//
                amountSum = amountOne + amountTwo + amountThree;
                amountAverage = amountSum / 3;
                Console.WriteLine("Your average is $" + Math.Round(amountAverage,2));

                double[] array1 = { amountOne, amountTwo, amountThree };
                Console.WriteLine("Your smallest value is $" + array1.Min());
                Console.WriteLine("Your largest value is $" + array1.Max());

                //second part of deliverable - exchange rate is based off values of 11-11-2018//
                //$1 = 113.94 Japanese yen, ￥//
                //$1 = 9.08 Swedish Krona, kr//
                //$1 = 33.08 Thai Baht, ฿//

                int JapaneseYen;
                double SwedishKrona, ThaiBaht;
                
                JapaneseYen = (int)(amountSum*113.94);
                SwedishKrona = amountSum * 9.08;
                ThaiBaht = amountSum * 33.08;

                Console.WriteLine("Your total sum is converted into the three currencies below:");
                Console.WriteLine("Japanese currency (Yen) = " + JapaneseYen);
                Console.WriteLine("Swedish currency (Krona) = " + SwedishKrona);
                Console.WriteLine("Thai currency (Baht) = " + ThaiBaht);

                Console.ReadKey();


            }
        }
    }
    //create a consol app in C# that takes in 3 different dollar amounts. Total up those amounts, then calculate and print the following to the console: average, smallest, and largest amount.//
    //next format and print the total of the three inputs to look like the proper us format as well as the Japanese, Swedish, and Thai//
    //only two decimal places are allowed.//

}
    

