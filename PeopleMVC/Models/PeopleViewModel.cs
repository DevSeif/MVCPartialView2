namespace PeopleMVC.Models
{
    public class PeopleViewModel
    {
        static public List<Person> people = new List<Person>
        {
            new Person(Guid.NewGuid().ToString(), "Olof Olofsson", "0733456028", "Göteborg"),
            new Person(Guid.NewGuid().ToString(), "Per Persson", "0722456128", "Stockholm"),
            new Person(Guid.NewGuid().ToString(), "Anders Andersson", "0736426028", "Malmö"),
            new Person(Guid.NewGuid().ToString(), "Rolf Rolfsson", "0733456843", "Borås"),
            new Person(Guid.NewGuid().ToString(), "Björn Björnsson", "0733444028", "Göteborg"),
        };

        public List<Person> peopleList = new List<Person>();

        //public Person person { get; set; }
    }
}
