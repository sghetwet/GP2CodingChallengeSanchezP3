﻿using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;



class Challenges
{
    public static void Main(string[] args)
    {
        bool run = true;
        while (run == true)
        {
            Console.WriteLine("Welcome to my coding challenge program. There will be a variety of different functions you will have to choose from. Please pick one of these numbers:");
            Console.WriteLine("1: Adding Numbers");
            Console.WriteLine("2: Converting Minutes to seconds.");
            Console.WriteLine("3: Adding 1 to any given number.");
            Console.WriteLine("4: Calculating Circut Power.");
            Console.WriteLine("5: Converting age (in years) to days old.");
            Console.WriteLine("6: Finding the area of a triangle.");
            Console.WriteLine("7: Finding out if a number is less than 0.");
            Console.WriteLine("8: Seeing if the sum of two numbers is less than 100.");
            Console.WriteLine("9: Seeing it two numbers are equal to eachother.");
            Console.WriteLine("10: adding something to a sentence.");
            Console.WriteLine("11: Determining if it is a true or false statement.");
            Console.WriteLine("12: Converting Hours to seconds.");
            Console.WriteLine("13: Returning the sum of internal angles of a polygon.");
            Console.WriteLine("14: Adding 'edabit' to the end of a sentence.");
            Console.WriteLine("15: Checking if both values are true and marking them AS true, otherwise marking AS false.");
            Console.WriteLine("16: Finding the score of a basketball game.");
            Console.WriteLine("17: Finding the perimeter of a rectangle.");
            Console.WriteLine("18: Greeting someone with their name.");
            Console.WriteLine("19: Counting how many total legs there are between chickens, cows, and pigs.");
            Console.WriteLine("20: Finding a football teams score based one wins, draws, and losses.");
            Console.WriteLine("21: Fidning the month name based on its number.");
            Console.WriteLine("22:");
            Console.WriteLine("23: Finding the sum of the absolute value to integers.");
            Console.WriteLine("24: Finding a number to the power of another number.");
            Console.WriteLine("25: Multiplying any given amount of numbers by the total amount of numbers given.");
            Console.WriteLine("26: Hamming Distance.");
            Console.WriteLine("27: Swapping your first and last name.");
            Console.WriteLine("28: Returning the smaller #");
            Console.WriteLine("29: Doing factorials.");
            Console.WriteLine("Counting vowels in a word.");
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

            else if (choiceint == 9)
            {
                Console.WriteLine("Let's see if two numbers are equal to one another, give me a number to use.");
                var Mario = Console.ReadLine();
                int Marioint = int.Parse(Mario);

                Console.WriteLine("Now give me another number to compare it to.");
                var Luigi = Console.ReadLine();
                int Luigiint = int.Parse(Luigi);

                Console.WriteLine("Are your numbers are equal? Survey says: " + equal(Marioint, Luigiint));
                equal(Marioint, Luigiint);
            }
            else if (choiceint == 10)
            {
                Console.WriteLine("I will add something to the sentence you give me, so give me a sentence");
                var words = Console.ReadLine();
                Console.WriteLine("Something " + words + ".");

            }
            else if (choiceint == 11)
            {
                Console.WriteLine("I will give you the 100% real and legit answer to a true or false question. \n Type true or false");
                var trueorfalse = Console.ReadLine();
                if (trueorfalse == "true")
                {
                    Console.WriteLine(" false ");
                }
                else if (trueorfalse == "false")
                {
                    Console.WriteLine(" true ");
                }
            }
            else if (choiceint == 12)
            {
                Console.WriteLine("Thou shall give me a number for hours that I will convert to seconds.");
                var thosewhoknow = Console.ReadLine();
                int thosewhoknowint = int.Parse(thosewhoknow);

                Console.WriteLine(thosewhoknow + " hours converted to seconds is: " + WinterArc(thosewhoknowint) + " seconds");
            }
            else if (choiceint == 13)
            {
                Console.WriteLine("Give me a polygon with any sides greater than 1 and I will return the sum of it's internal angles.");
                var egg = Console.ReadLine();
                int eggint = int.Parse(egg);
                Console.WriteLine("Your polygons internal angles equals: " + Angler(eggint) + " degrees.");
            }
            else if (choiceint == 14)
            {
                Console.WriteLine("I will add the word 'Edabit' to a sentence you give me.");
                Console.WriteLine("Give me a sentence please.");
                var uhhuh = Console.ReadLine();
                Console.WriteLine(uhhuh + " edabit.");
            }
            else if (choiceint == 15)
            {
                Console.WriteLine("Give me either true or false");
                var a = Console.ReadLine();
                bool abool = bool.Parse(a);
                Console.WriteLine("Give me true or false again");
                var b = Console.ReadLine();
                bool bbool = bool.Parse(b);
                Console.WriteLine("And (" + a + ", " + b + ") -> " + how(abool, bbool) + ".");

            }
            else if (choiceint == 16)
            {
                Console.WriteLine("We're going tro count the score of a basketball game based on the amount of 2 pointers and 3 pointers, give me the number of 2 point shots.");
                var yuhhuh = Console.ReadLine();
                int yuhhuhint = int.Parse(yuhhuh);
                Console.WriteLine("Now give me the number of 3 point shots.");
                var GREENBEAN = Console.ReadLine();
                int GREENBEANint = int.Parse(GREENBEAN);
                Console.WriteLine("Points (" + yuhhuh + ", " + GREENBEAN + ") -> " + Baller(GREENBEANint, yuhhuhint) + ".");
                Baller(GREENBEANint, yuhhuhint);

            }
            else if (choiceint == 17)
            {
                Console.WriteLine("Let's find the perimter of a reactangle! Give me the length of your rectangle.");
                var Lbozo = Console.ReadLine();
                int Lbozoint = int.Parse(Lbozo);
                Console.WriteLine("Now give me the width of your rectangle.");
                var Ratio = Console.ReadLine();
                int Ratioint = int.Parse(Ratio);
                Console.WriteLine(" Your length and width of (" + Lbozo + ", " + Ratio + ") equals a perimeter of " + perm(Lbozoint, Ratioint) + ".");
                perm(Lbozoint, Ratioint);
            }
            else if (choiceint == 18)
            {
                Console.WriteLine("Give me your name, so I can greet you.");
                var name = Console.ReadLine();
                Console.WriteLine("Hello " + name + "!");
            }
            else if (choiceint == 19)
            {
                Console.WriteLine("Let's see the total amount of legs that there is between chickens, cows, and pigs. Give me the amount of pigs there is.");
                var oink = Console.ReadLine();
                int oinkint = int.Parse(oink);
                Console.WriteLine("Now give me the amount of cows there will be.");
                var MOO = Console.ReadLine();
                int MOOint = int.Parse(MOO);
                Console.WriteLine("Now give me the number of chickens there is.");
                var wellwellwell = Console.ReadLine();
                int wellwellwellint = int.Parse(wellwellwell);
                Console.WriteLine("Animals(" + oink + ", " + MOO + ", " + wellwellwell + ") -> " + sigma(oinkint, MOOint, wellwellwellint) + ".");

            }
            else if (choiceint == 20)
            {
                Console.WriteLine("Let's see the total score of a football team based on their wins, draws, and losses. Give me the total number of wins.");
                var winnerwinner = Console.ReadLine();
                int winnerwinnerint = int.Parse(winnerwinner);
                Console.WriteLine("Now give me the number of draws.");
                var drawing = Console.ReadLine();
                int drawingint = int.Parse(drawing);
                Console.WriteLine("Now give me the number of losses.");
                var imaginelosing = Console.ReadLine();
                int imaginelosingint = int.Parse(imaginelosing);
                Console.WriteLine("Footbal points(" + winnerwinner + ", " + drawing + ", " + imaginelosing + ") -> " + rizzler(winnerwinnerint, drawingint, imaginelosingint) + ".");
            }

            else if (choiceint == 21)
            {
                Console.WriteLine("You will pick a month between the numbers 1-12. Please give me a number between 1-12.");
                var months = Console.ReadLine();
                int monthsint = int.Parse(months);

                if (monthsint == 1)
                {
                    Console.WriteLine("MonthName(1) -> January");
                }
                else if (monthsint == 2)
                {
                    Console.WriteLine("MonthName(2) -> February");
                }
                else if (monthsint == 3)
                {
                    Console.WriteLine("MonthName(3) -> March");
                }
                else if (monthsint == 4)
                {
                    Console.WriteLine("MonthName(4) -> April");
                }
                else if (monthsint == 5)
                {
                    Console.WriteLine("MonthName(5) -> May");
                }
                else if (monthsint == 6)
                {
                    Console.WriteLine("MonthName(6) -> June");
                }
                else if (monthsint == 7)
                {
                    Console.WriteLine("MonthName(7) -> July");
                }
                else if (monthsint == 8)
                {
                    Console.WriteLine("MonthName(8) -> August");
                }
                else if (monthsint == 9)
                {
                    Console.WriteLine("MonthName(9) -> September");
                }
                else if (monthsint == 10)
                {
                    Console.WriteLine("MonthName(10) -> October");
                }
                else if (monthsint == 11)
                {
                    Console.WriteLine("MonthName(11) -> November");
                }
                else if (monthsint == 12)
                {
                    Console.WriteLine("MonthName(12) -> December");
                }
                else
                {
                    Console.WriteLine("This doesn't corospond to a month and you know it >:(");
                }

            }
            else if (choiceint == 22)
            {

            }
            else if (choiceint == 23)
            {
                Console.WriteLine("We will be adding the sum of the absolute values you give me, please give me one of five numbers.");
                var num1 = Console.ReadLine();
                int num1int = int.Parse(num1);
                Console.WriteLine("And the next one.");
                var num2 = Console.ReadLine();
                int num2int = int.Parse(num2);
                Console.WriteLine("And the next one.");
                var num3 = Console.ReadLine();
                int num3int = int.Parse(num3);
                Console.WriteLine("And the next one.");
                var num4 = Console.ReadLine();
                int num4int = int.Parse(num4);
                Console.WriteLine("And the next one.");
                var num5 = Console.ReadLine();
                int num5int = int.Parse(num5);
                Console.WriteLine("getAbsSum ([" + num1 + ", " + num2 + ", " + num3 + ", " + num4 + ", " + num5 + "]) --> " + AbsoluteRadiance(num1int, num2int, num3int, num4int, num5int) + ".");
            }
            else if (choiceint == 24)
            {
                Console.WriteLine("Let's try getting the power of an inputted number. Give me the base.");
                var POWER1 = Console.ReadLine();
                int POWER1int = int.Parse(POWER1);
                Console.WriteLine("Now give me the exponent.");
                var POWER2 = Console.ReadLine();
                int POWER2int = int.Parse(POWER2);
                Console.WriteLine("CalculateExponents(" + POWER1 + ", " + POWER2 + ") -> " + POWER(POWER1int, POWER2int) + ".");
            }
            else if (choiceint == 25)
            {
                Console.WriteLine("Enter any amount of numbers in an array and I will multiply them by the total amount of numbers in the array.");
                string input = Console.ReadLine();
                int[] arr = input.Split(' ').Select(int.Parse).ToArray();
                int[] result = MultiplyByLength(arr);
                Console.WriteLine("MultiplyByLengt: [" + string.Join(", ", result) + "]");
            }
            else if (choiceint == 26)
            {
                Console.WriteLine("I will find the hamming distance of 2 strings, give me a string");
                var firstStrand = Console.ReadLine();
                Console.WriteLine("Now the next.");
                var SecondStrand = Console.ReadLine();
                Console.WriteLine("HammingDistance(" + firstStrand + ", " + SecondStrand + ") -> " + Distance(firstStrand, SecondStrand) + ".");
            }
            else if (choiceint == 27)
            {
                Console.WriteLine("Let's get your first name and last name and swap them, give me your first name.");
                var firstname = Console.ReadLine();
                Console.WriteLine("Now give me your last name.");
                var lastname = Console.ReadLine();
                Console.WriteLine("NameShuffle( ''" + firstname + " " + lastname + "'') -> " + lastname + " " + firstname + ".");
            }
            else if (choiceint == 28)
            {
                Console.WriteLine("Let's see which of two numbers is smaller, give me a number");
                var numfirst = Console.ReadLine();
                int numfirstint = int.Parse(numfirst);
                Console.WriteLine("Now the second number.");
                var numsecond = Console.ReadLine();
                int numsecondint = int.Parse(numsecond);
                Console.WriteLine(" (" + numfirst + ", " + numsecond + ") -> " + sizedontmatter(numfirstint, numsecondint) + ".");
            }
            else if (choiceint == 29)
            {
                Console.WriteLine("We will be doing the factorial to a number you give me, give me a number.");
                var userinput = Console.ReadLine();
                int userinputint = int.Parse(userinput);
                Console.WriteLine("Factorial (" + userinput + ") -> " + factor(userinputint) + ".");

            }
            else if (choiceint == 30)
            {
                Console.WriteLine("Let's count the total vowels in a word, give me a word.");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid input :(");

                }
                else
                {
                    Console.WriteLine("CountVowels(" + input + ") -> " + sad(input));
                }
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

    public static bool equal(int Mario, int Luigi)
    {
        if (Mario == Luigi)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Gimmie()
    {
        Console.WriteLine("I will add something to the sentence you give me, so give me a sentence");
        var words = Console.ReadLine();
        Console.WriteLine("Something " + words + ".");
    }

    public static int WinterArc(int thosewhoknow)
    {
        return thosewhoknow * 3600;
    }

    public static int Angler(int egg)
    {
        if (egg < 2)
        {
            Console.WriteLine("Invalid Number");
            return 0;
        }
        else
        {
            return (egg - 2) * 180;
        }
    }

    public static void huh()
    {
        Console.WriteLine("I will add the word 'Edabit' to a sentence you give me.");
        Console.WriteLine("Give me a sentence please.");
        var uhhuh = Console.ReadLine();
        Console.WriteLine(uhhuh + " edabit.");
    }

    public static bool how(bool a, bool b)
    {
        if (a == true && b == true)
        {
            Console.WriteLine(" True ");
            return true;
        }
        else
        {
            Console.WriteLine(" False ");
            return false;
        }
    }

    public static int Baller(int GREENBEAN, int yuhhuh)
    {
        return (yuhhuh * 2) + (GREENBEAN * 3);
    }

    public static int perm(int Lbozo, int Ratio)
    {
        return (Lbozo * 2) + (Ratio * 2);
    }

    public static void namepls()
    {
        Console.WriteLine("Give me your name, so I can greet you.");
        var name = Console.ReadLine();
        Console.WriteLine("Hello " + name + "!");
    }

    public static int sigma(int oink, int MOO, int wellwellwell)
    {
        return (oink * 4) + (MOO * 4) + (wellwellwell * 2);

    }

    public static int rizzler(int winnerwinner, int drawing, int imaginelosing)
    {
        return (winnerwinner * 3) + (drawing) + (imaginelosing * 0);
    }

    public static int AbsoluteRadiance(int num1, int num2, int num3, int num4, int num5)
    {
        return ((Math.Abs(num1)) + (Math.Abs(num2)) + (Math.Abs(num3)) + (Math.Abs(num4)) + (Math.Abs(num5)));

    }

    public static double POWER(double POWER1, double POWER2)
    {
        return (Math.Pow(POWER1, POWER2));
    }
    public static int[] MultiplyByLength(int[] arr)
    {
        int length = arr.Length; int[] result = new int[length]; for (int i = 0; i < length; i++) { result[i] = arr[i] * length; }
        return result;
    }
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length) { throw new ArgumentException(); }

        return firstStrand.Zip(secondStrand, (abcde, bcdef) => abcde != bcdef).Count(f => f);
    }
    public static int sizedontmatter(int numfirst, int numsecond)
    {
        if (numfirst < numsecond)
        {
            return numfirst;
        }
        else
        {
            return numsecond;
        }
    }
    public static int factor(int userinput)
    {
        int res = 1;
        for (int i = 2; i <= userinput; i++)
            res *= i;
        return res;
    }
    public static int sad(string vow)
    {
        int count = 0;
        string vowels = "aeiou";

        foreach (char c in vow)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }
}
