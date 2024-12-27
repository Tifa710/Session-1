using System.Drawing;

namespace Session_1
{
    enum Days {
        Monday, 
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday, 
    }
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter,
    }
    enum Permissions
    { 
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8 
    }
    enum Colors {
        Red,
        Green,
        Blue, 
        red,
        green,
        blue, 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Days day1 = Days.Monday;
            //Days day2 = Days.Tuesday;
            //Days day3 = Days.Wednesday;
            //Days day4 = Days.Thursday;
            //Days day5 = Days.Friday;
            //Days day6 = Days.Saturday;
            //Days day7 = Days.Sunday;
            //Console.WriteLine(day1);
            //Console.WriteLine(day2);
            //Console.WriteLine(day3);
            //Console.WriteLine(day4);
            //Console.WriteLine(day5);
            //Console.WriteLine(day6);
            //Console.WriteLine(day7);
            #endregion
            #region Q2
            //Enum.TryParse(typeof(Season), Console.ReadLine(), out object Result);
            //switch (Result) 
            //{
            //    case Season.Spring: 
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break; 
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter: Console.WriteLine("Winter: December to February");
            //        break;
            //    default: Console.WriteLine("Unknown season"); 
            //        break; 
            //}
            #endregion
            #region Q3

            #endregion
            #region Q4
            Enum.TryParse(typeof(Colors), Console.ReadLine(), out object color);
            switch (color)
            { 
                case Colors.Red:
                    Console.WriteLine("is a primary color.");
                    break;
                case Colors.Green:
                    Console.WriteLine("is a primary color.");
                    break;
                case Colors.Blue:
                    Console.WriteLine("is a primary color.");
                    break;
                case Colors.red:
                    Console.WriteLine("is a primary color.");
                    break;
                case Colors.green:
                    Console.WriteLine("is a primary color.");
                    break;
                case Colors.blue:
                    Console.WriteLine("is a primary color.");
                    break;
                default: Console.WriteLine("is not a primary color."); 
                    break;
            }
            #endregion
            #region Q5                        
            #endregion
        }
    }
}
