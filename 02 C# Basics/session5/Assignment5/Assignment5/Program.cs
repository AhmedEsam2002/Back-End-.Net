using System;

namespace Assignment5
{
    // Question 1: Enum for WeekDays
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Question 2,7: Struct for Person
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    // Question 3: Enum for Season
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    // Question 4: Enum for Permissions
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    // Question 5: Enum for Colors
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    // Question 6: Struct for Point
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Question 1: Enum for WeekDays
            Console.WriteLine("WeekDays Enum:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();

            // Question 2: Struct for Person
            Console.WriteLine("Person Struct Array:");
            Person[] persons = new Person[3];
            persons[0] = new Person { Name = "ahmed", Age = 30 };
            persons[1] = new Person { Name = "mohamed", Age = 25 };
            persons[2] = new Person { Name = "sayed", Age = 35 };

            foreach (Person person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            Console.WriteLine();

            // Question 3: Enum for Season
            Console.WriteLine("Season Enum:");
            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string seasonInput = Console.ReadLine();
            Season season;
            if (Enum.TryParse(seasonInput, true, out season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season");
            }
            Console.WriteLine();

            // Question 4: Enum for Permissions
            Console.WriteLine("Permissions Enum:");
            Permissions userPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine("User permissions: " + userPermissions);

            userPermissions |= Permissions.Execute;
            Console.WriteLine("Added Execute permission: " + userPermissions);

            userPermissions &= ~Permissions.Write;
            Console.WriteLine("Removed Write permission: " + userPermissions);

            bool hasReadPermission = (userPermissions & Permissions.Read) == Permissions.Read;
            Console.WriteLine("Has Read permission: " + hasReadPermission);
            Console.WriteLine();

            // Question 5: Enum for Colors
            Console.WriteLine("Colors Enum:");
            Console.WriteLine("Enter a color (Red, Green, Blue):");
            string colorInput = Console.ReadLine();
            Colors color;
            if (Enum.TryParse(colorInput, true, out color))
            {
                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{color} is a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{color} is not a primary color.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid color");
            }
            Console.WriteLine();

            // Question 6: Struct for Point
            Console.WriteLine("Point Struct:");
            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("Enter the first point (X and Y):");
            p1.X = Convert.ToDouble(Console.ReadLine());
            p1.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second point (X and Y):");
            p2.X = Convert.ToDouble(Console.ReadLine());
            p2.Y = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            Console.WriteLine($"The distance is: {distance}");
            Console.WriteLine();

            // Question 7: Struct for Person
            Console.WriteLine("Oldest Person Struct:");
            Person[] persons2 = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for person {i + 1}:");
                persons2[i].Name = Console.ReadLine();
                persons2[i].Age = Convert.ToInt32(Console.ReadLine());
            }

            Person oldest = persons2[0];
            for (int i = 1; i < persons2.Length; i++)
            {
                if (persons2[i].Age > oldest.Age)
                {
                    oldest = persons2[i];
                }
            }
            Console.WriteLine($"The oldest person is {oldest.Name} with age {oldest.Age}");
        }
    }
}
