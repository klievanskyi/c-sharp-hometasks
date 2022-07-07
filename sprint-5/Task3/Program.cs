//We have the next collection:  

//Dictionary<string, string> persons = new Dictionary<string, string>();
//{
//    persons.Add("id11111", "Admin");
//    persons.Add("id12345", "User1");
//    persons.Add("id98765", "User2");
//    persons.Add("id56743", "User3");
//    persons.Add("id73920", "User4");
//}
//1) In class MyProgram please create a method that should take a collection of arguments SearchKeys(Dictionary<string, string> persons) in which print all keys from this collection

//2) method that should take a collection of arguments SearchValues(Dictionary<string, string> persons) in which print all values from this collection

//3) and method that should take a collection of arguments SearchAdmin(Dictionary<string, string> persons) in which search value "Admin" and print information in format Key + " " + Value 

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> persons = new Dictionary<string, string>();
            {
                persons.Add("id11111", "Admin");
                persons.Add("id12345", "User1");
                persons.Add("id98765", "User2");
                persons.Add("id56743", "User3");
                persons.Add("id73920", "User4");
            }
            SearchKeys(persons);
            SearchValues(persons);
            SearchAdmin(persons);
        }

        public static void SearchKeys(Dictionary<string, string> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Key);
            }
        }

        public static void SearchValues(Dictionary<string, string> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Value);
            }
        }

        public static void SearchAdmin(Dictionary<string, string> persons)
        {
            foreach (var person in persons)
            {
                if (person.Value == "Admin")
                {
                    Console.WriteLine(person.Key + " " + person.Value);
                }
            }
        }
    }
}
