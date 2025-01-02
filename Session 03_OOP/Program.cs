
namespace Session_03_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //#region Question 1
            //Person[] persons = new Person[3];

            //persons[0] = new Person { Name = "Ahmed", Age = 25 };
            //persons[1] = new Person { Name = "Hassan", Age = 30 };
            //persons[2] = new Person { Name = "Mohsen", Age = 28 };

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine($"Name : {person.Name}, Age: {person.Age}");

            //}
            //#endregion


            #region Question 2

            Console.WriteLine("Enter the coordinates of the first point (X Y): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Point point1 = new Point { X = x1, Y = y1 };

            Console.WriteLine("Enter the coordinates of the second point (X Y): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Point point2 = new Point { X = x2, Y = y2 };

            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            Console.WriteLine($"The distance between the two points is: {distance}");

            #endregion

            #region Question 3


            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Enter Name Of Person {i + 1}: ");
                persons[i].Name = Console.ReadLine();

                Console.WriteLine($"Enter Age Of Person  {i + 1}: ");
                persons[i].Age = int.Parse(Console.ReadLine());
            }

            Person olderperson = persons[0];
            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > olderperson.Age)
                {
                    olderperson = persons[i];
                }
            }

            Console.WriteLine($"The Older Person is {olderperson.Name}, Age: {olderperson.Age}");

        }

        #endregion

    }
}



