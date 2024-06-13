using System;

namespace Assignment1
{
    class Program
    {
        static void Main()
        {

            #region run all 
            Console.WriteLine("Choose the question number to run (1-10):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Question1();
                    break;
                case "2":
                    Question2();
                    break;
                case "3":
                    Question3();
                    break;
                case "4":
                    Question4();
                    break;
                case "5":
                    Question5();
                    break;
                case "6":
                    Question6();
                    break;
                case "7":
                    Question7();
                    break;
                case "8":
                    Question8();
                    break;
                case "9":
                    Question9();
                    break;
                case "10":
                    Question10();
                    break;
            }


                    #endregion


            }

        #region Question 1
        static void Question1()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        #endregion

        #region Question 2
        static void Question2()
        {
            string input = "123abc";
            try
            {
                int number = int.Parse(input);
                Console.WriteLine("Converted number: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: Input string was not in a correct format.");
            }
        }
        #endregion

        #region Question 3
        static void Question3()
        {
            float num1 = 5.75f;
            float num2 = 2.25f;
            float result = num1 + num2;
            Console.WriteLine("Result: " + result);
        }
        #endregion

        #region Question 4
        static void Question4()
        {
            string input = "Hello, World!";
            string substring = input.Substring(7, 5);
            Console.WriteLine("Extracted substring: " + substring);
        }
        #endregion

        #region Question 5
        static void Question5()
        {
            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine("a: " + a); // a remains 10
            Console.WriteLine("b: " + b); // b is 20
        }
        #endregion

        #region Question 6
        class MyClass
        {
            public int Value;
        }

        static void Question6()
        {
            //Refrance VAlue
            MyClass obj1 = new MyClass();
            MyClass obj2 = obj1;
            obj2.Value = 20;
            Console.WriteLine("obj1.Value: " + obj1.Value); // obj1.Value is 20
            Console.WriteLine("obj2.Value: " + obj2.Value); // obj2.Value is 20
        }
        #endregion

        #region Question 7
        static void Question7()
        {
            string str1 = "Hello, ";
            string str2 = "Route!";
            string str = str1 + str2;
            Console.WriteLine(str);
        }
        #endregion

        #region Question 8
        static void Question8()
        {
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine("d: " + d); // A value 1 will be assigned to d
        }
        #endregion

        #region Question 9
        static void Question9()
        {
            Console.WriteLine(13 / 2 + " " + 13 % 2); // Output: 6 1
            /// int/int =>int       
        }
        #endregion

        #region Question 10
        static void Question10()
        {
            int num = 1, z = 5;

            if (!(num <= 0))  // 1<=0 false   not false equal true  
            {
                Console.WriteLine(++num + z++ + " " + ++z); // Output: 7 7     //// ++num =>2  z++=>5      ++num + z++ =7    ++z => 7 
            }
            else
            {
                Console.WriteLine(--num + z-- + " " + --z);
            }
        }
        #endregion


      
    }
}
