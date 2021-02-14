using System;

namespace MyDictonary
{
    class Program
    {
       

        static void Main(string[] args)
        {


            List<int, string> Students = new List<int, string>();


            int select = 0;
            while (select != -1)
            {

                select = 0;

                Console.WriteLine("Add to Student\n(first data : student number + enter + second data : student name)\n");

                Students.Add((Convert.ToInt32(Console.ReadLine())), (Console.ReadLine()));

                Console.WriteLine("press 1 to continue\nTo Exit : -1\n");

                select = Convert.ToInt32(Console.ReadLine());


            }

            Students.Show();
            
           




        }
    }
}
