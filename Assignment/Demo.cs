namespace Demo
{
    enum Gender
    {
        Male = 0, Female = 1, male = 0, female = 1,
    }

    enum Days
    {
        Saturday,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    enum Grades
    {
        A, B, C, D, E, F
    }

    enum Branches : byte // 0 : 255
    {
        NasrCity, Maadi = 251, Alex, Dokki, Enhas, SmartVillag
    }
    enum Roles
    {
        Admin = 10, Viewer = 20, Editor = 30
    }
    //[Flags]
    //enum Permissions : byte
    //{
    //    Delete = 1, Execute = 2 , Read = 4 , Write = 8
    //}

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    enum Seasons
    {
        Spring, Summer, Autumn, Winter
    }
    class Employee
    {
        public string Name;
        public int Age;
        public decimal Salary;
        public Gender Gender; // Male - Female
        public Permissions Permissions;
    }
    [Flags]
    enum Permissions
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }

    enum Colors
    {
        Red, Green, Blue
    }

    internal class Program
    {
            public static void DoSomeCode()
            {
                //try
                //{

                //    int x, y, z;
                //    x = int.Parse(Console.ReadLine()); // FormatException
                //    y = int.Parse(Console.ReadLine());

                //    z = x / y; // DividedByZeroException

                //    int[] Numbers = { 1, 2, 3 };

                //    Numbers[10] = 100; // IndexOutOfRangeException
                //}
                //// CLR Create Object From Exception
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    // Log in file
                //    // Store in DB
                //}

            }

            public static void DoSomeProtectiveCode()
            {

                //    int x, y, z;
                //    bool Flag;
                //    //x = int.Parse(Console.ReadLine()); // FormatException
                //   do
                //   {
                //        Console.WriteLine("Enter First Number");
                //        Flag = int.TryParse(Console.ReadLine(), out x);
                //    } while (!Flag);

                //    //y = int.Parse(Console.ReadLine());
                //    do
                //    {
                //        Console.WriteLine("Enter Second Number");
                //        Flag = int.TryParse(Console.ReadLine(), out y);
                //    } while (!Flag || y == 0);

                //    z = x / y; // DividedByZeroException

                ////int[] Numbers = { 1, 2, 3 };
                //int[] Numbers = null;
                //if (Numbers?.Length > 10)
                //{
                //    Numbers[10] = 100; // IndexOutOfRangeException
                //}

            }
            static void Main(string[] args)
            {
                #region Exception Handling
                DoSomeCode();

                // Exceptions
                // 1. System Exceptions
                //// 1.1 Format Exceptions
                //// 1.2 Index Out Of Range Exceptions
                //// 1.3 Null Reference Exceptions
                //// 1.4 Invalid Operation Exceptions (Casting)
                //// 1.5 Arithmetic Exceptions\
                //// 1.5.1 Divided By Zero Exception
                //// 1.5.2 Overflow Exception (Size => Long stored in Int)
                // 2. Applications Exception

                //try
                //{
                //    DoSomeProtectiveCode();
                //    throw new Exception();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                ////Console.WriteLine("After Try Catch");
                //finally
                //{
                //    // Close - Free - Delete - Deallocate Unmanaged Resources
                //    // Open File
                //    // Open Connection Database
                //    Console.WriteLine("Finally");
                //}

                ////DoSomeProtectiveCode();
                ////throw new Exception();
                ////Console.WriteLine("After Try Catch");

                #endregion

                #region Access Modifer

                //TypeB
                //TypeA.x = 10;
                //TypeA.y = 10;
                //typeA.z = 10;   

                #endregion

                #region Enums
                #region Ex01
                ////string Day = "Hamada";
                ////Days Day = Days.Monday;
                //Grades grade = Grades.B;
                //if (grade == Grades.A)
                //{
                //    Console.WriteLine(":)");
                //}
                //else
                //{
                //    Console.WriteLine(":(");
                //}
                #endregion

                #region Ex02
                ////Grades grades =(Grades)2; // Explicit Casting

                ////Console.WriteLine(grades); // C

                //Grades grades = (Grades)10; // Explicit Casting

                //Console.WriteLine(grades); // 10

                #endregion

                #region Ex03
                //Grades grade = (Grades) Enum.Parse(typeof(Grades), Console.ReadLine());
                // Console.WriteLine(grade);

                //Enum.TryParse(typeof(Grades), Console.ReadLine(), out object Result);
                //Grades grades = (Grades)Result;
                //Console.WriteLine(Result);
                #endregion

                #region Ex04
                //string gender = "male";
                ////Enum.TryParse(typeof(Gender), gender, out object Result);
                ////Console.WriteLine(Result);

                //Enum.TryParse<Gender>(gender, true, out Gender Result);
                //Console.WriteLine(Result);
                #endregion

                #endregion

                #region Permissions
                //Employee employee = new Employee(); 
                //employee.Name = "Ali";
                //employee.Age = 20;
                //employee.Permissions =(Permissions)3;
                //Console.WriteLine(employee.Permissions); //Delete , Execute

                ////XOR
                //employee.Permissions = employee.Permissions ^ Permissions.Read;

                //Console.WriteLine(employee.Permissions); //Delete , Execute , Read

                //employee.Permissions = employee.Permissions ^ Permissions.Read;

                //Console.WriteLine(employee.Permissions); //Delete , Execute 

                //// &
                //if ((employee.Permissions & Permissions.Read) == Permissions.Read)
                //{
                //    Console.WriteLine("Permission is exist");
                //}
                //else
                //{
                //    employee.Permissions = employee.Permissions ^ Permissions.Write;
                //}

                //Console.WriteLine(employee.Permissions);    

                //// OR
                //employee.Permissions = employee.Permissions | Permissions.Read;
                //Console.WriteLine(employee.Permissions);

                #endregion

                #region Struct
                //Point P01;

                //// Console.WriteLine(P01.X); // It's not initialized
                ////P01.X = 10;
                ////P01.Y = 20;
                ////Console.WriteLine(P01.X);
                ////Console.WriteLine(P01.Y);

                //P01 = new Point(2, 7);
                //Console.WriteLine(P01.X);
                //Console.WriteLine(P01.Y);

                //Console.WriteLine(P01);  //Assignment06.Point
                //Console.WriteLine(P01.ToString()); //Assignment06.Point

                //int X = 10;
                //Console.WriteLine(X); // 10
                //Console.WriteLine(X.ToString()); // 10

                //Point P02 = new();

                #endregion



            }
    }
}

