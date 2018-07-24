using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Benjamin Curry", "Pam Carson", "Dianne Neal", "Dana Mcdaniel", "Lee Gonzales", "Phil Mendez", "Irma Garner", "Marguerite Kelly", "Rosemary Garza", "Jesse	Bass", "Marcella Taylor", "Cristina Wilkerson", "Margarita Morris", "Bill Tucker", "Don Morales", "Gordon Sims", "Jo Bush", "Elaine Casey", "Marty Mcgee", "Ebony Becker" };
            string[] hometown = { "Boston", "New York", "Lansing", "Austin", "San Jose", "Detroit", "Nashville", "Columbus", "Denver", "Las Vegas", "Chicago", "Flint", "Petoskey", "Grand Rapids", "Tampa Bay", "New Orleans", "San Antonio", "Madison", "Seattle", "Grand Haven" };
            string[] food = { "Pizza", "PB&J", "Chicken Noodle Soup", "Bread", "BBQ Ribs", "Spaghetti", "Butter", "Tacos", "Salad", "Sweet and Sour Chicken", "Rice", "Broccoli", "Skittles", "Beans and Rice", "Honey-baked Ham", "Corn on the cob", "Ice Cream", "Pickles", "Cereal", "Grilled Cheese" };
            bool repeat = true;
            var namePattern = @"^([1-9]|1[0-9]|20)$";
            var townPattern = @"^hometown$";
            var foodPattern = @"^favorite food$";
            Console.WriteLine("Welcome to our C# Class.");

            while (repeat == true)
            {
                Console.WriteLine("Which student would you like to learn more about? (enter a number: 1-20):");
                string personNumber = Console.ReadLine();
                if (Regex.IsMatch(personNumber, namePattern))
                {
                    int personNumber1 = int.Parse(personNumber);
                    Console.WriteLine($"Student {personNumber} is {people[personNumber1 - 1]}.");
                    bool repeat2 = true;

                    while (repeat2 == true)
                    {
                        Console.WriteLine($"What would you like to know about {people[personNumber1 - 1]}? (Enter \"hometown\" or \"favorite food\")");
                        string answer = Console.ReadLine();
                        answer = answer.ToLower();

                        if (Regex.IsMatch(answer, townPattern))
                        {
                            Console.WriteLine($"{people[personNumber1 - 1]}'s hometown is {hometown[personNumber1 - 1]}.");
                            Console.WriteLine($"Would you like to know more? (y/n)");
                            string more = Console.ReadLine();
                            more = more.ToLower();
                            if (more == "y")
                            {
                                break;
                            }
                            else
                            {
                                repeat2 = false;
                                repeat = false;
                            }
                        }

                        if (Regex.IsMatch(answer, foodPattern))
                        {
                            Console.WriteLine($"{people[personNumber1 - 1]}'s favorite food is {food[personNumber1 - 1]}.");
                            Console.WriteLine($"Would you like to know more? (y/n)");
                            string more = Console.ReadLine();
                            more = more.ToLower();
                            if (more == "y")
                            {
                                
                                break;
                            }
                            else
                            {
                                repeat2 = false;
                                repeat = false;
                            }
                        }

                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again. (Enter \"hometown\" or \"favorite food\")");
                            repeat2 = true;
                        }
                        
                    }
                    

                }
                else
                {
                    Console.WriteLine("That person does not exist. Please try again.");
                    repeat = true;
                }

            } 
        }


    }
}