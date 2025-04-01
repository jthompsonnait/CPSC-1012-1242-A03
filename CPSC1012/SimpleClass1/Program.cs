namespace W12D1_SimpleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  multiple ways of creating a class
            //  Old way
            // Book book = new Book();
            Book book = new();

            // YOU WILL LOSE MARKS
            Book badBookWay = new Book();

            book.Title = "James Best Coding Examples";

            Console.WriteLine($"Book Tile: {book.Title}");

        }
    }
}
