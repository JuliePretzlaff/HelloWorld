using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Part One:  Greetings statement
            //string messageOne = "Hello World!";
            //string messageTwo = "I am Spartacus";

            ////Part Two: Set initial Spartacus attributes
            //int ageOne = 35;
            //int ageTwo = 45;
            //int ageThree = 80;
            //double heightOne = 72.50;
            //double heightTwo = 91.45;
            //float weightOne = 210.0284606f;
            //float weightTwo = 331.12345678f;
            //bool isGodLikeOne = true;
            //bool isGodLikeTwo = false;
            //char genderMale = 'M';
            //char genderFemale = 'F';

            ////Part Three: Display variable values
            //Console.WriteLine(messageOne);//Displays initial greeting to console
            //Console.WriteLine(messageTwo);

            ////Part Four: Mathematical operator, bool, and char examples
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(isGodLikeOne);
            //Console.WriteLine(genderMale);

            ////Part Five: Variable reassignment
            //ageTwo = 70;
            //weightTwo = -429.1234573f;
            //heightTwo = 35.12345f;

            ////Part Six: Mathematical operator examples 
            //Console.WriteLine(ageOne + ageTwo);
            //Console.WriteLine(heightOne - heightTwo);
            //Console.WriteLine(weightOne * weightTwo);
            //Console.WriteLine(ageTwo / ageOne);
            //Console.WriteLine(ageTwo % ageOne);
            //Console.WriteLine(ageThree / ageOne);
            //Console.WriteLine(ageThree % ageOne);

            ////Part Seven:  Increment and decrement operator examples
            //ageTwo++;
            //Console.WriteLine(ageTwo);
            //ageTwo--;
            //Console.WriteLine(ageTwo);

            //////Part Eight: Concatination and indexing example
            ////Console.WriteLine(messageOne + " " + messageTwo + ".");
            ////Console.WriteLine("I am " + ageOne + " years old, and yes it's " + isGodLikeOne + " I'm godlike.");
            ////Console.WriteLine("I weigh around " + weightOne + " pounds, and I am around " + heightOne + " inches tall.");
            ////Console.WriteLine("I am {0} years old, and yes it's {1} I'm godlike.", ageOne, isGodLikeOne);
            ////Console.WriteLine("I weigh around {0}, and I am around {1} inches tall.", weightOne, heightOne);

            ////Part Nine: String equality examples
            //Console.WriteLine(messageTwo.Equals(messageOne));
            //Console.WriteLine(messageTwo.Equals("I am Spartacus"));

            //string myGreeting = "Hello!";
            //Console.WriteLine(myGreeting.ToUpper());
            //Console.WriteLine(myGreeting.ToLower());


            ////Part Ten: String length examples
            //int messageOneLength = messageOne.Length;
            //int messageTwoLength = messageTwo.Length;
            //Console.WriteLine("The length of messageOne is " + messageOne.Length);
            //Console.WriteLine("The length of messageTwo is " + messageTwo.Length);
            //Console.WriteLine("The length of messageOne is " + messageOneLength);
            //Console.WriteLine("The length of messageTwo is " + messageTwoLength);

            ////Part Eleven: Conditional Examples **be sure to spell out 1, 2, 3 etc**
            //string city1 = "Vesuvius";
            //string city2 = "Nola";
            //string city3 = "Nuceria";
            //int city1Distance, city2Distance, city3Distance;

            ////Solicit user input example
            //Console.WriteLine("What is the distance to {0}?", city1);
            //city1Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to " + city2 + "?");
            //city2Distance = int.Parse(Console.ReadLine());
            //Console.WriteLine("What is the distance to Nuceria?");
            //city3Distance = int.Parse(Console.ReadLine());

            //if((city1Distance <= 125) && (city1Distance < city2Distance) && (city1Distance < city3Distance))
            //{
            //    Console.WriteLine("We will March to {0}.", city1);
            //}
            //if((city2Distance <= 125) && (city2Distance < city1Distance) && (city2Distance < city3Distance))
            //{
            //    Console.WriteLine("We will march to " + city2 + ".");
            //}
            //if((city3Distance <=125) && (city3Distance < city1Distance) && (city3Distance < city2Distance))
            //{
            //    Console.WriteLine("We will march to Nuceria.");

            //}

            ////Part Twelve: Else/if else example
            Console.WriteLine("What is your rank?");
            string rank = Console.ReadLine().ToLower();

            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your job?");
            string job = Console.ReadLine().ToLower();

            if ((rank == "officer") || (age <= 26))
            {
                Console.WriteLine("Get your gear, you're going to battle!");
            }
            else if ((job == "cook") && (age >= 26))
            {
                Console.WriteLine("My army has to eat, pack your pots & pans.");
            }
            else
            {
                Console.WriteLine("You stay home.");
            }

            //Part Thirteen: SwitchCase
            Console.WriteLine("What is your job?");
            string job = Console.ReadLine();

            switch (job)
            {
                case "infantry":
                    Console.WriteLine("Carry a sword.");
                    break;
                case "archer":
                    Console.WriteLine("carry a bow.");
                    break;
                case "supply":
                    Console.WriteLine("Carry pots.");
                    break;
                case "specialist":
                    Console.WriteLine("Operate catapault.");
                    break;
                default:
                    Console.WriteLine("Ride horseback.");
                    break;
            }



        }
    }
}
