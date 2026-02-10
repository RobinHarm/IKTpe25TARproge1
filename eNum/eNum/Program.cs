using System.Drawing;

namespace eNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            //kasutate enumit Weekdays ja tahaks näha Friday

            Console.WriteLine(Weekdays.Friday);
            
            //tahame friday numbrilist väärtust
            Console.WriteLine((int)Weekdays.Friday);
            Console.WriteLine("-----------------------");
            //(int) - castimine e teisendab teiseks andmetüübiks
            //juhul kui info võib kaduma minna ja ei näita soovitud tulemust.

            //tehke uus enum Colors
            //ühe värvi peab konsoolis ära näitama
            //string taustavärvus = "";
            //Console.WriteLine("Mis värvi te soovite?\n red\n blue\n white\n black\n green\n yellow");
            //taustavärvus = Console.ReadLine();
            //if (taustavärvus == "Red")
            //{
            //    Console.WriteLine(Colors.Red);
            //}
            //else if (taustavärvus == "Blue")
            //{
            //    Console.WriteLine(Colors.Blue);
            //}
            //else if (taustavärvus == "White")
            //{
            //    Console.WriteLine(Colors.White);
            //}
            //else if (taustavärvus == "Green")
            //{
            //    Console.WriteLine(Colors.Green);
            //}
            //else if (taustavärvus == "Yellow")
            //{
            //    Console.WriteLine(Colors.Yellow);
            //}
            //else if (taustavärvus == "Black")
            //{
            //    Console.WriteLine(Colors.Black);
            //}
            Console.WriteLine(Colors.Red);
        }
        enum Colors
        {
            Red = 3,
            Green = 10,
            Blue = 13,
            Yellow = 5,
            Black = 1,
            White = 8
        }
        enum Weekdays
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday,            
            Friday,
            Saturday,
            Sunday
        }
        
        
    }
}
