namespace W9D1_IO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "names.txt";

            Console.WriteLine("=======  Basic File Read  ========");

            //  check if the file exist
            if (File.Exists(fileName))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            Console.WriteLine(line);
                        }
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something went wrong: {e.Message}");
                }
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine("James");
                        writer.WriteLine("Jan");
                        writer.WriteLine("Jam");
                        writer.WriteLine("Bob");
                        writer.WriteLine("Mike");
                    }
                    //  No need for writer.Close() - using statement handles disposal
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Something went wrong: {e.Message}");
                }
            }
        }
    }
}
