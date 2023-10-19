using System;

namespace resubmitionH
{
    class Program
    {

        private static qusetionilbrary1 qusetionilbrary1 = new qusetionilbrary1();
        

        static void Main(string[] args)
        {
            bool Menu = true;
            while (Menu)
            {

                Menu = View();
            }


            static bool View()
            {
                Console.WriteLine("\n.......................Software Development and Modeling.......................\n\n");
                Console.WriteLine("\n........................ Welcome to Greenfield Academy........................\n");
                Console.WriteLine("\n.............................Learn without Limits.............................\n\n");
                Console.WriteLine("Select your Respective Account to Continue\n");
                Console.WriteLine("      Main Menu\n");
                Console.WriteLine("      For Students      -  Enter 1\n      For Tutors        -  Enter 2\n      For Examinators   -  Enter 3\n      Exit              -  Enter 4");
                Console.Write("\nEnter Your Choice : ");

                string choice = Console.ReadLine();
                    if (choice=="1")
                    {
                        StudentView();
                        return true;
                }
                else if (choice=="2")
                    {
                        TutorView();
                        return true;
                }
                else if (choice=="3")
                {

                    ExaminatorView();
                    return true;

                }
                else if (choice=="4")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter a valid key");
                    string v = Console.ReadLine();
                    return true;
                }
            }


            static bool StudentView()
            {
                Console.WriteLine("\n Please choose a subject:\n\n");
                Console.WriteLine("1) Environmental Science\n2) Life Processes\n3) Menu");
                int choice2 = Convert.ToInt32(Console.ReadLine());


                if (choice2 == 1)
                {
                    ValidatStId1();
                    return true;
                }
                else if (choice2 == 2)
                {
                    ValidatStId2();
                    return true;
                }
                else if (choice2 == 3)
                {

                    return false;

                }
                else
                {
                    Console.WriteLine("Please enter a valid key");
                    string e = Console.ReadLine();
                    return true;
                }

            }

            static bool TutorView()
            {
                Console.WriteLine("\n Please choose a subject:\n\n");
                Console.WriteLine("1) Environmental Science\n2) Life Processes\n3) Menu");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        ValidatTutId1();
                        return true;
                    case 2:
                        ValidatTutId2();
                        return true;
                    case 3:
                        return false;
                    default:
                        Console.WriteLine("Please enter a valid key");
                        string v = Console.ReadLine();
                        StudentView();
                        return true;
                }

            }


            static bool ExaminatorView()
            {
                Console.WriteLine("\n Please choose a subject:\n\n");
                Console.WriteLine("1) Environmental Science\n2) Life Processes\n3) Menu");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                

                if (choice2 == 1)
                {
                    ValidatExId1();
                    return true;
                }
                else if (choice2 == 2)
                {
                    ValidatExId2();
                    return true;
                }
                else if (choice2 == 3)
                {

                    return false;

                }
                else
                {
                    Console.WriteLine("Please enter a valid key");
                    _ = Console.ReadLine();
                    return true;
                }

            }

            static void ValidatStId1()
            {

                try
                {
                    qusetionilbrary1.ValidatStId();
                }
                catch 
                {
                    Console.WriteLine("Error: Index out of range");
                }

            }

            static void ValidatStId2()
            {
                try
                {
                    qusetionilbrary1.ValidatStId1();
                }
                catch 
                {
                    Console.WriteLine("Error: Index out of range");
                }
            }

            static void ValidatTutId1()
            {
                try
                {
                    qusetionilbrary1.ValidatTutId();
                }
                catch 
                {
                    Console.WriteLine("Error: Index out of range");
                }
            }

            static void ValidatTutId2()
            {
              try
                {
                    qusetionilbrary1.ValidatTutId1();
                }
                catch 
                {
                    Console.WriteLine("Error: Index out of range");
                }
            }

            static void ValidatExId1()
            {
                try
                {
                    qusetionilbrary1.ValidatExId();
                }
                catch 
                {
                    Console.WriteLine("Error: Index out of range");
                }
            }

            static void ValidatExId2()
            {
                try
                {
                    qusetionilbrary1.ValidatExId1();
                }
                catch 
                {
                    Console.WriteLine("Error: Index out of range");
                }
            }
        }
    }
}
