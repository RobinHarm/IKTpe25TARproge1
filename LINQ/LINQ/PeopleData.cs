using LINQ.Models;

namespace LINQ
{
    public class PeopleData
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>
        {
             new PeopleList()
             {
                 Id = 1,
                 Name = "Moona",
                 Age = 22,
                 GenderId = Guid.Parse("e6a57d34-7345-4855-8489-952f0503d7c1")
             },
             new PeopleList()
             {
                 Id = 2,
                 Name = "Poona",
                 Age = 21,
                 GenderId = Guid.Parse("44772175-8cf4-4b52-aa09-5d412ce4fa9c")
             },
             new PeopleList()
             {
                 Id = 3,
                 Name = "Ron",
                 Age = 18,
                 GenderId = Guid.Parse("44772175-8cf4-4b52-aa09-5d412ce4fa9c")
             },
             new PeopleList()
             {
                 Id = 4,
                 Name = "Anna",
                 Age = 20,
                 GenderId = Guid.Parse("e6a57d34-7345-4855-8489-952f0503d7c1")
             },
             new PeopleList()
             {
                 Id = 5,
                 Name = "EMEX",
                 Age = 69,
                 GenderId = Guid.Parse("44772175-8cf4-4b52-aa09-5d412ce4fa9c")
             },
             new PeopleList()
             {
                 Id = 6,
                 Name = "EMEX",
                 Age = 67,
                 GenderId = Guid.Parse("44772175-8cf4-4b52-aa09-5d412ce4fa9c")
             },
             new PeopleList()
             {
                 Id = 7,
                 Name = "Bill",
                 Age = 69,
                 GenderId = Guid.Parse("44772175-8cf4-4b52-aa09-5d412ce4fa9c")
             },
        };   
    }
}
