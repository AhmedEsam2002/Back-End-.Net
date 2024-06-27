namespace assignment
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run (1-18): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Program1();
                    break;
                case 2:
                    Program2();
                    break;
                case 3:
                    Program3();
                    break;
                case 4:
                    Program4();
                    break;
                case 5:
                    Program5();
                    break;
                case 6:
                    Program6();
                    break;
                case 7:
                    Program7();
                    break;
                case 8:
                    Program8();
                    break;
                case 9:
                    Program9();
                    break;
                case 10:
                    Program10();
                    break;
                case 11:
                    Program11();
                    break;
                case 12:
                    Program12();
                    break;
                case 13:
                    Program13();
                    break;
                case 14:
                    Program14();
                    break;
                case 15:
                    Program15();
                    break;
                case 16:
                    Program16();
                    break;
                case 17:
                    Program17();
                    break;
                case 18:
                    Program18();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        #region Program1
        static void Program1()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        #endregion

        #region Program2
        static void Program2()
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
        #endregion

        #region Program3
        static void Program3()
        {
            Console.WriteLine("Enter three integers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));

            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);
        }
        #endregion

        #region Program4
        static void Program4()
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        #endregion

        #region Program5
        static void Program5()
        {
            Console.WriteLine("Enter a character:");
            char ch = char.Parse(Console.ReadLine().ToLower());
            if ("aeiou".IndexOf(ch) >= 0)
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
        }
        #endregion

        #region Program6
        static void Program6()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Program7
        static void Program7()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number * i + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Program8
        static void Program8()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Program9
        static void Program9()
        {
            Console.WriteLine("Enter two integers:");
            int baseNum = int.Parse(Console.ReadLine());
            int exponent = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            Console.WriteLine("Result: " + result);
        }
        #endregion

        #region Program10
        static void Program10()
        {
            Console.WriteLine("Enter marks of five subjects:");
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += int.Parse(Console.ReadLine());
            }
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;

            Console.WriteLine("Total marks = " + total);
            Console.WriteLine("Average marks = " + average);
            Console.WriteLine("Percentage = " + percentage + "%");
        }
        #endregion

        #region Program11
        static void Program11()
        {
            Console.WriteLine("Enter the month number:");
            int month = int.Parse(Console.ReadLine());

            int days;
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                days = 31;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                days = 30;
            }
            else if (month == 2)
            {
                days = 28; // Ignoring leap years for simplicity
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid month number");
            }

            Console.WriteLine("Days in month: " + days);
        }
        #endregion

        #region Program12
        static void Program12()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose operation (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());

            double result;
            if (operation == '+')
            {
                result = num1 + num2;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }
            else if (operation == '/')
            {
                result = (double)num1 / num2;
            }
            else
            {
                throw new ArgumentException("Invalid operation");
            }

            Console.WriteLine("Result: " + result);
        }
        #endregion

        #region Program13
        static void Program13()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("Reversed string: " + new string(charArray));
        }
        #endregion

        #region Program14
        static void Program14()
        {
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());
            int reversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine("Reversed integer: " + reversedNumber);
        }
        #endregion

        #region Program15
        static void Program15()
        {
            Console.WriteLine("Enter the starting number of range:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ending number of range:");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        #endregion

        #region Program16
        static void Program16()
        {
            Console.WriteLine("Enter a number to convert to binary:");
            int number = int.Parse(Console.ReadLine());
            string binary = ConvertToBinary(number);
            Console.WriteLine("The binary of {0} is {1}", number, binary);
        }

        static string ConvertToBinary(int num)
        {
            string binary = "";
            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }
            return binary == "" ? "0" : binary;
        }
        #endregion

        #region Program17
        static void Program17()
        {
            Console.WriteLine("Enter the coordinates of three points (x1 y1) (x2 y2) (x3 y3):");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }
        }
        #endregion

        #region Program18
        static void Program18()
        {
            Console.WriteLine("Enter the time taken to complete the task (in hours):");
            double time = double.Parse(Console.ReadLine());

            string efficiency;
            if (time <= 3)
            {
                efficiency = "Highly efficient";
            }
            else if (time <= 4)
            {
                efficiency = "Increase your speed";
            }
            else if (time <= 5)
            {
                efficiency = "Training required to increase speed";
            }
            else
            {
                efficiency = "Leave the company";
            }

            Console.WriteLine("Efficiency: " + efficiency);
        }
        #endregion
    }

}
