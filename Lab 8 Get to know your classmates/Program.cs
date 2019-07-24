﻿using System;

namespace Lab_8_Get_to_know_your_classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Please choose the corresponding number to the student you would like to learn more about:"+"\n"+"1. Dan" + "\n" +"2. Zack" + "\n" +"3. Evan" + "\n" +"4. Mitch" + "\n" +"5. Mallory");
                string studentNum1 = Console.ReadLine();
                int studentNum = 0;
                try
                {
                    studentNum = int.Parse(studentNum1);
                    if (studentNum < 1 || studentNum >5)
                    {
                        Console.WriteLine("That was outside of the given range, let's try again.");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That was not valid, let's try again.");
                    continue;
                }
                
                string studentName = ChooseStudent(studentNum-1);
                Console.WriteLine($"The student's name is {studentName}");

                //asking to know favorite food
                string studentFood = ChooseFood($"Would you like to know {studentName}'s favorite food?", (studentNum-1));
                if (studentFood != "")
                {
                    Console.WriteLine($"{studentName}'s favorite food is {studentFood}.");
                }
                
                //asking to know hometown
                string studentHometown = ChooseHometown($"Would you like to know which town {studentName} grew up in?", (studentNum-1));
                if (studentHometown != "")
                {
                    Console.WriteLine($"{studentName}'s hometown is {studentHometown}.");
                }
                
                //asking to know favorite drink
                string studentDrink = ChooseDrink($"Would you like to know {studentName}'s favorite drink?", (studentNum-1));
                if (studentDrink != "")
                {
                    Console.WriteLine($"{studentName}'s favorite drink is {studentDrink}.");
                }
                
                //asking to continue
                cont = ChooseContinue();
            }
        }
        public static string ChooseStudent(int studentNum)
        {
            string[] nameArray = { "Dan", "Zack", "Evan", "Mitch", "Mallory" };
            bool cont = true;
            string studentName = "";
            while (cont)
            {
                try
                {
                    studentName = nameArray[studentNum];
                    cont = false;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That was not valid, let's try again.");
                    continue;
                }
            }
            return studentName;

        }
        public static string ChooseFood(string message, int studentNum)
        {
            Console.WriteLine(message);
            string[] foodArray = { "hot dog", "cheeseburger", "milkshake", "curry", "tacos" };
            string foodChoice = "";
            bool cont = true;
            while (cont)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    foodChoice = foodArray[studentNum];
                    cont = false;
                }
                else if (response == "n")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid response, let't try that again.");
                    continue;
                }
            }
            return foodChoice;
        }
        public static string ChooseHometown(string message, int studentNum)
        {
            Console.WriteLine(message);
            string[] hometownArray = { "Detroit", "Chicago", "Boston", "Los Angeles", "Seattle" };
            string hometown = "";
            bool cont = true;
            while (cont)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    hometown = hometownArray[studentNum];
                    cont = false;
                }
                else if (response == "n")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid response, let't try that again.");
                    continue;
                }
            }
            return hometown;
        }
        public static string ChooseDrink(string message, int studentNum)
        {
            Console.WriteLine(message);
            string[] drinkArray = { "Coke", "Pepsi", "Sprite", "Jeager", "Red-Bull" };
            string drink = "";
            bool cont = true;
            while (cont)
            {
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    drink = drinkArray[studentNum];
                    cont = false;
                }
                else if (response == "n")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid response, let't try that again.");
                    continue;
                }
            }
            return drink;

        }
        public static bool ChooseContinue()
        {
            bool cont = true;
            bool cont1 = true;
            while (cont1)
            {
                Console.WriteLine("Would you like to learn about another student?");
                string response = Console.ReadLine().ToLower();
                if(response == "y")
                {
                    cont = true;
                    cont1 = false;
                }
                else if(response == "n")
                {
                    cont = false;
                    cont1 = false;
                }
                else
                {
                    Console.WriteLine("That was not a valid input, please try again.");
                    continue;
                }

            }
            return cont;
        }
    }
}
