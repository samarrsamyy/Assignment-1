using System.Drawing;

namespace Assignment__1
{

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Friday,
        Saturday,
        Sunday
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    enum Persmissions: byte
    {
        Read =1,
        Write =2,
        Delete =4,
        Execute =8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }


    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point p)
        {
            double deltaX = p.X - this.X;
            double deltaY = p.Y - this.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Q2 Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Season season;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Season");
            //    string input = Console.ReadLine();

            //    Flag = Enum.TryParse<Season>(input, true, out  season);

            //} while (!Flag);

            //switch (season)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("December to February");
            //        break;
            //}

            #endregion

            #region Q3 Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Employee employee = new Employee();
            //employee.persmissions = (Persmissions)5;



            //employee.persmissions = employee.persmissions | Persmissions.Write;


            //Console.WriteLine(employee.persmissions);

            #endregion

            #region Q4 Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter Color");

            //string input = Console.ReadLine();  

            //if(Enum.TryParse<Colors>(input , true, out Colors color))
            //{
            //    Console.WriteLine("Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine("Not Primary Color");
            //}


            #endregion

            #region Q5 Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.


            //Console.WriteLine("Enter coordinates for Point 1 (X Y):");
            //Point point1 = new Point(double.Parse(Console.ReadLine()) , double.Parse(Console.ReadLine()));
          
            //Console.WriteLine("Enter coordinates for Point 2 (X Y):");
            //Point point2 = new Point(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            //double distance = point1.Distance(point2);
            //Console.WriteLine(distance);


            #endregion


        }
    }


    class Employee
    {
        public string Name;
        public int age;
        public Persmissions persmissions;
    }

}
