namespace W13D1_List3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  setting up a list to work with
            List<string> names = new List<string>();
            names.Add("James");
            names.Add("Bob");
            names.Add("Mike");
            names.Insert(0, "First");
            names.Insert(1, "Second");

            Console.WriteLine($"Second item in the list is {names[1]}");

            //  check to see if our list contain a value
            if(names.Contains("James"))
            {
                Console.WriteLine("Contains value");
                names.Remove("James");
            }
            else
            {
                Console.WriteLine("Dose not contains value");
            }

            Console.WriteLine($"Third item in the list is {names[2]}");

            //  sort
           names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //  get the index of a value
            int i = names.IndexOf("First");
            Console.WriteLine($"The index of the value of first is {i}");


        }
    }
}
