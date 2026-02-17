namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kutsume esile LINQ läbi switchi");
            //Console.WriteLine("Vali vastav link numriga");
            //Console.WriteLine("1. Where");

            //int choice = int.Parse(Console.ReadLine());
            WhereBynameLINQ();

        //    switch (choice)
        //    {
        //        case 1:
        //            WhereLINQ();
        //            break;

        //        default:
        //            break;
        //    }
        //    WhereLINQ();
        }


        //teeme uue meetodid
        //public static void WhereLINQ()
        //{

        //    var peopleAge = PeopleData.peoples
        //        .Where(x => x.Age > 20 && x.Age < 23);

        //    foreach (var people in peopleAge)
        //    {
        //        Console.WriteLine(people.Name);
        //    }


        //    //kasutada muutujat peopleAge ja kuvada andmed esile
        //    //kasuta foreachi
        //}

        public static void WhereBynameLINQ()
        {
            Console.WriteLine("Kirjuta inimese nimi: ");
            string name = Console.ReadLine();
            var peopleName = PeopleData.peoples
                .Where(x => x.Name == name);

            foreach (var people in peopleName)
            {
                Console.WriteLine(people.Name + people.Age);
            }
        }
           
    }
            
    


}








