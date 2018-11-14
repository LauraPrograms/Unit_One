using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            string mood, 
                inputM,
                transport ="",
                goodFood = "To Taco Bell - hahaha no, go to Steak & Shake"; 
            
            int inputP;

            Console.WriteLine("Howdy user! What are you in the mood for? (please type in one of the following inputs)");
            string m = "1. Action" + "\r\n" + "2. Chilling" + "\r\n" + "3. Danger" + "\r\n" + "4. Good Food" + "\r\n" + "5. Celebratory" + "\r\n";
            Console.Write(m);
            inputM = Console.ReadLine();
            mood = inputM.ToLower();

            Console.WriteLine("How many people are you bringing with you? (please enter an integer)");
            inputP = Convert.ToInt32(Console.ReadLine());
            if (inputP == 0)
            {
                transport = "sneakers.";
            }
            else if (inputP >= 1 && inputP <= 4)
            {
                transport = "a sedan.";
            }
            else if (inputP >= 5 && inputP <= 10)
            {
                transport = "a Volkswagen bus.";
            }
            else if (inputP >= 11)
            {
                transport = "an airplane.";
            }
            else
            {
                Console.WriteLine("I'm sorry, that is a number I do not know.");
            }


            if (transport != "")
            {
                if (mood == "action" || mood == "1" || mood == "one" || mood == "1.")
                {
                    Console.WriteLine("You should go Stock Car Racing and travel in  " + transport);

                }
                else if (mood == "chilling" || mood == "2" || mood == "two" || mood == "2.")
                {
                    Console.WriteLine("You should go Hiking and travel in " + transport);

                }
                else if (mood == "danger" || mood == "3" || mood == "three" || mood == "3.")
                {
                    Console.WriteLine("You should go Skydiving and travel in " + transport);

                }
                else if (mood == "good food" || mood == "4" || mood == "four" || mood == "4.")
                {
                    Console.WriteLine("You should go " + goodFood +"and travel in " + transport);
                    
                }
                else if (mood == "celebratory" || mood == "5" || mood == "five" || mood == "5.")
                {
                    Console.WriteLine("You should go dancing and travel in " + transport);
                    
                }

                else
                {
                    Console.WriteLine("I'm sorry, your input was not understood. Try again with the listed ones.");

                }

            }
            else
            {
                Console.WriteLine("I'm sorry, your input was not understood. Please enter an integer.");
            }

            Console.WriteLine("Have fun, goodbye.");

            Console.ReadKey();
                         
        }
    }
}
