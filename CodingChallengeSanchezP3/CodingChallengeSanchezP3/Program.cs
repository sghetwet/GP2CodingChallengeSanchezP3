using System;


class Challenges
{
    public static void Main(string[] args)
    {
        bool run = true;
        while (run == true)
        {
            Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from. Please pick one of these numbers:");
            Console.WriteLine("1: Adding Numbers");
            Console.WriteLine("2: Converting Minutes to seconds");
            Console.WriteLine("3: Adding 1 to any given number");
            Console.WriteLine("4: Calculating Circut Power");
            Console.WriteLine("5: Converting age (in years) to days old");
            Console.WriteLine("6: Finding the area of a triangle");
            Console.WriteLine("7: Finding out if a number is less than 0");
            Console.WriteLine("8: Seeing if the sum of two numbers is less than 100");
            Console.WriteLine("0: exit program");

            var choice = Console.ReadLine();
            int choiceint = int.Parse(choice);
            if (choiceint == 0)
            {
                run = false;
            }
            else if (choiceint == 1)
            {
                Console.WriteLine("Today we are going to use the number added called SUM. Please input two numbers for us to add. \n");

                var number1 = Console.ReadLine();
                int number1int = int.Parse(number1);
                Console.WriteLine("Awesome! Please input a second number.");

                var number2 = Console.ReadLine();
                int number2int = int.Parse(number2);

                Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(number1int, number2int));
            }
            else if (choiceint == 2)
            {
                Console.WriteLine("Let's try converting minutes into seconds. Give me a number to convert minutes to seconds.");
                var number3 = Console.ReadLine();
                int number3int = int.Parse(number3);

                Console.WriteLine(number3 + " Minutes converted to seconds is: " + Convert(number3int) + " seconds ");

            }
            else if (choiceint == 3)
            {
                Console.WriteLine("Now, give me a number that I will add a digit to.");
                var appendicitis = Console.ReadLine();
                int appendicitisint = int.Parse(appendicitis);

                Console.WriteLine(appendicitis + " Your number plus 1 is equal to: " + AddOne(appendicitisint));
            }
            else if (choiceint == 4)
            {
                Console.WriteLine("Let's calculatethe circut power. \n");

                Console.WriteLine("Give me a value for your voltage.");
                var shocktuah = Console.ReadLine();
                int shocktuahint = int.Parse(shocktuah);

                Console.WriteLine("Now give me a value for your current.");
                var lightningonthatthang = Console.ReadLine();
                int lightningonthatthangint = int.Parse(lightningonthatthang);

                Console.WriteLine("Your circut power is equal to: " + VoltConvert(shocktuahint, lightningonthatthangint));
                VoltConvert(shocktuahint, lightningonthatthangint);
            }
            else if (choiceint == 5)
            {
                Console.WriteLine("Now tell me how many years old you are so I can convert it to days");
                var geezer = Console.ReadLine();
                int geezerint = int.Parse(geezer);

                Console.WriteLine("You are: " + Oldie(geezerint) + " days old.");
            }
            else if (choiceint == 6)
            {
                Console.WriteLine("Now let's find the area of a triangle, first give me a height.");
                var height = Console.ReadLine();
                int heightint = int.Parse(height);

                Console.WriteLine("Now give me the base of your triangle.");
                var width = Console.ReadLine();
                int widthint = int.Parse(width);

                Console.WriteLine("The area of your triangle is: " + area(heightint, widthint));
                area(heightint, widthint);
            }
            else if (choiceint == 7)
            {
                Console.WriteLine("Now give me a number and I will see if it's less then 0. \n please give me a number to look at and check");
                var number10 = Console.ReadLine();
                int number10int = int.Parse(number10);

                Console.WriteLine(lessthanorequaltozero(number10int));
            }

            else if (choiceint == 8)
            {
                Console.WriteLine("Let's see if the sum of two numbers is less than 100, give me a number!");
                var one = Console.ReadLine();
                int oneint = int.Parse(one);

                Console.WriteLine("Now give me a number to add to your first number.");
                var two = Console.ReadLine();
                int twoint = int.Parse(two);

                Console.WriteLine(lessthanhundred(oneint, twoint));
            }
            else
            {
                Console.WriteLine("Invaled number, please type an avaible number");
            }
        }
   }

    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Convert(int number)
    {
        return number * 60;
    }
    public static int AddOne(int appendicitis)
    {
        return appendicitis += 1;
    }

    public static int VoltConvert(int shocktuah, int lightningonthatthang)
    {
        return shocktuah * lightningonthatthang;
    }

    public static int Oldie(int geezer)
    {
        return geezer * 365;
    }

    public static float area(float height, int width)
    {
        return (height * width) / 2;
    }

    public static bool lessthanorequaltozero(int number10)
    {
        if (number10 <= 0)
        {
            return true;
        }
        return false;
    }

    public static bool lessthanhundred(int one, int two)
    {
        if (one + two < 100)
        {
            return true;
        }
        return false;
    }
}
