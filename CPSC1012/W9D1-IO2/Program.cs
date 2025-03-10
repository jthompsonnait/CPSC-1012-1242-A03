namespace W9D1_IO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "number2.txt";

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
                        for (int i = 0; i < 10; i++)
                        {
                            writer.Write(i);
                        }
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
