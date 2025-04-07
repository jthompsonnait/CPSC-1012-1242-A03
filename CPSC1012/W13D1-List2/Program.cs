namespace W13D1_List2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("James");
            names.Add("Bob");
            names.Add("Mike");

            foreach (string name in names)
            {

                Console.WriteLine(name);
            }

            //  count all of the names in our name list
            Console.WriteLine($"Total count in our list is {names.Count}");

            //  insert a new name at the beginning of the list
            Console.WriteLine("Adding a value at position 0");
            names.Insert(0, "First");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Adding a value at position 1");
            //  insert at positon 2, index of 1
            names.Insert(1, "Second");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // remove a value based on the name
            Console.WriteLine("Remove the value of James from the list");
            names.Remove("James");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            //  remove at a index locationat index 0
            Console.WriteLine("Remove the value of James from the list");
            names.RemoveAt(0);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //  clear out the list
            names.Clear();
            //  count all of the names in our name list
            Console.WriteLine($"Total count in our list is {names.Count}");
        }
    }
}