namespace StructProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Struct");

            Coordinate point = new Coordinate(3, 5);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            IntAndString punkt = new IntAndString("Nimi", 16);
            Console.WriteLine(punkt.Name);
            Console.WriteLine(punkt.Age);
            InsertedIntAndString midagi = new InsertedIntAndString();
            midagi.City = "TAllinn";
            midagi.PostalCode = 6969;
            Console.WriteLine(midagi.City);
            Console.WriteLine(midagi.PostalCode);
        }
    }
    //Mis on struct?
    //See on väärtustüüp (value type), mis sarnaneb klassile
    struct Coordinate
    {
        public int X;
        public int Y;

        //teha konstruktor
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    //teha struct nimega IntAndString
    //string Name ja int Age
    //kutsuda see struct Maini-s välja


    struct IntAndString(string name, int age)
    {
        public string Name = name;
        public int Age = age;
    }

    //teha struct nimega InsertedIntAndString
    //string City ja int on PostalCode
    //structi sees tuleb sellele anda juba väärtus
    struct InsertedIntAndString
    {
        public string City;
        public int PostalCode;
        public InsertedIntAndString(string linn, int kood)
        {
            City = linn;
            PostalCode = kood;
        }
       
    }
       

}
    
    
