using GroupPractice;
List<Person> Names = new List<Person>()
{
    new Person("Michael Blackburn", 28),
    new Person("Mourad Al-fadil", 26),
    new Person("Cameron Dixon", 22)
};

foreach (Person p in Names)
{
    Console.WriteLine($"{p.Name}, {p.Age}");
}



