using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Disclaimer: This fortune teller hates you

            //Initiallize all variables
            string firstName, lastName, location, transport, color, check, gender, spouse;
            int age, birthMonth, siblings, retire;
            float money = 0;
            while (true)
            {
                Console.WriteLine("Welcome to the magically abusive fortune teller!\nIf you want to quit, just type in \"Quit\" you quiter.\nAnd good luck making me crash! You won't be able to no matter what you do!");

                //First Name
                Console.Write("What... is your first name? ");
                check = Console.ReadLine();
                while (check == "")
                {
                    Console.Write("Maybe you should actually put a name down, stupid. ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                firstName = check;

                //Last Name
                Console.Write(firstName + "... What a stupid name!\nWhat... is your last name? ");
                check = Console.ReadLine();
                while (check == "")
                {
                    Console.Write("Maybe you should actually put a name down, stupid. ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                lastName = check;
                
                //Gender
                Console.Write(lastName + "... That's even worse!\nWhat... are you? Male or female? ");
                check = Console.ReadLine();
                while (check.ToLower() != "male" && check.ToLower() != "female" && check.ToLower() != "quit")
                {
                    Console.Write("Listen here you imbecile! There's either \"male\" or \"female\", so pick one and spell it right! ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                gender = check.ToLower();
                
                //Age
                Console.Write("Really? Well ok then.\nWhat... is your age? ");
                check = Console.ReadLine();
                while (!IsNumber(check) && check.ToLower() != "quit")
                {
                    Console.Write("Are you that stupid? That's not an acceptable answer! ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                age = int.Parse(check);

                //Birth Month
                Console.Write((age < 30 ? "Just fantastic, a child..." : "Oh great, an oldie...") + "\nWhat... Is your birth month? The number, not the actual name, idiot. ");
                check = Console.ReadLine();
                while (!IsNumber(check) && check.ToLower() != "quit")
                {
                    Console.Write("Are you that stupid? That's not an acceptable answer! ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                birthMonth = int.Parse(check);

                //Color
                Console.Write("So the worst month? Alright. What... is your favorite ROYGBIV color?\nType in \"Help\" for help if you're stupid and don't know what ROYGBIV is. ");
                check = Console.ReadLine();
                while (!IsColor(check) && check.ToLower() != "quit")
                {
                    if (check.ToLower() == "help")
                        Console.Write("Really? I thought you were smarter... Ah who am I kidding, no I wasn't!\nROYGBIV stands for Red Orange Yellow Green Blue Indigo Violet. Pick a favorite! ");
                    else
                        Console.Write("Do you have the IQ of a wet sock? That's not one of the accepted colors! ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                color = check.ToLower();

                //Siblings
                Console.Write("Thank god, final question!\nWhat... is the number of siblings you have? ");
                check = Console.ReadLine();
                while (!IsNumber(check) && check.ToLower() != "quit")
                {
                    Console.Write("Are you that stupid? That's not an acceptable answer! ");
                    check = Console.ReadLine();
                }
                if (check.ToLower() == "quit")
                    break;
                siblings = int.Parse(check);

                //Create Fortune
                //Retirement
                if (age % 2 == 0)
                    retire = 61;
                else
                    retire = 126;

                //Living Accomadations
                if (siblings == 0)
                    location = "an apartment near the world's largest ball of twine";
                else if (siblings == 1)
                    location = "a somewhat decent trailerhome";
                else if (siblings == 2)
                    location = "your dad's \"garage of disappointment\"";
                else if (siblings == 3)
                    location = "a cozy herion-scented alleyway somewhere in London";
                else if (siblings == 4)
                    location = "underneath the stairs in a really cramped room";
                else if (siblings > 4)
                    location = "a cave filled with badly designed furniture";
                else
                    location = "in a literal pile of trash";

                //Transportation
                if(color == "red")
                    transport = "a used murder-bicycle";
                else if(color == "orange")
                    transport = "a clown car with really bad gas mileage";
                else if (color == "yellow")
                    transport = "Jim, the local drunk, wearing a saddle";
                else if (color == "green")
                    transport = "a pack of racing bunnies";
                else if (color == "blue")
                    transport = "your legs";
                else if (color == "indigo")
                    transport = "a racehorse you stole";
                else
                    transport = "the Jacksonville Park Express";
                    
                //Money
                if (birthMonth < 0 || birthMonth > 12)
                    money = 0;
                else if (birthMonth <= 4)
                    money = 3.50f;
                else if (birthMonth <= 8)
                    money = 107.23f;
                else
                    money = 13.37f;

                //Spouse
                Random r = new Random();
                int rand = r.Next(0, 4);
                if (gender == "male")
                {
                    if (rand == 0)
                        spouse = "no one, becuase you'll be forever alone";
                    else if (rand == 1)
                        spouse = "a Russian \"male\" order bride";
                    else if (rand == 2)
                        spouse = "a woman that somehow managed to kidnap you";
                    else
                        spouse = "a 2D cutout of some chinese cartoon character";
                }
                else
                {
                    if (rand == 0)
                        spouse = "no one, becuase you'll be forever alone";
                    else if (rand == 1)
                        spouse = "a cute looking rock you found lying on the street";
                    else if (rand == 2)
                        spouse = "an old man whose mustache makes you really uncomfortable";
                    else
                        spouse = "this guy you somehow managed to kidnap";
                }

                //The Actual Fortune
                Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + " years with $" + money.ToString("0.00")
                    + " bucks in the bank.\nYour \"vacation\" home is " + location + " and your preferred mode of transportion is " + transport + ". Your spouse will be "
                    + spouse + ".");
                Console.Write("Would you like another fortune? Type in anything for yes, or just type in \"Quit\" or nothing at all to leave. ");
                check = Console.ReadLine();
                if (check.ToLower() == "quit" || check == "")
                {
                    check = "";
                    break;
                }
                else
                    Console.WriteLine();
            }
            if (check.ToLower() == "quit")
                Console.WriteLine("You quit?! Of course you did! Nobody likes a quiter!");
        }
        static bool IsNumber(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            if (str.Length >= 10)
                return false;
            if (str == "")
                return false;
            return true;
        }
        static bool IsColor(string str)
        {
            switch(str.ToLower())
            {
                case "red":
                case "orange":
                case "yellow":
                case "green":
                case "blue":
                case "indigo":
                case "violet":
                    return true;
                default:
                    return false;
            }
        }
    }
}
