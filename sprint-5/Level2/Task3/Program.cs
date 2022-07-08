//Implement the ReverseNotebook() method that creates a new dictionary with name as key and list of phones as value.  The method receives a dictionary  with phone as key and name as value.

//For example, for a given dictionary {0967654321=Petro, 0677654321=Petro, 0501234567=Ivan, 0970011223=Stepan, 0631234567=Ivan} you should get {Ivan=[0501234567, 0631234567], Petro =[0967654321, 0677654321], Stepan =[0970011223]}.

//The method should work with entry notebook containing empty or null names without throwing exceptions. Use empty string as a key for null names.

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string> {
                { "0967654321", "Petro" },
                { "0677654321", "Petro" },
                { "0501234567", "Ivan" },
                { "0970011223", "Stepan" },
                { "0631234567", "Ivan" }
            };

            ReverseNotebook(dictionary);
        }

        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        {
            ILookup<string, string> lookup = phonesToNames.ToLookup(name => name.Value ?? string.Empty, phones => phones.Key);
            return lookup.ToDictionary(name => name.Key, list => list.ToList());
        }
    }
}
