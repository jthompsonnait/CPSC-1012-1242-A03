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
            //var badBookWay = new Book();

            //  populating out properties
            book.Title = "James Best Coding Examples";
            book.Author = "James Thompson";
            book.Pages = 200;

            // output the values of properties
            //  comment out, so we can use display details
            //Console.WriteLine($"Book Tile: {book.Title}");
            //Console.WriteLine($"Book Author: {book.Author}");
            //Console.WriteLine($"Book Page Count: {book.Pages}");



            //  call the display details method
            book.DisplayDetails();

            //  call get the book details methods
            Console.WriteLine(book.GetBookDetails());


            //  change page count from 200 to 321
            book.Pages = 321;
            //Console.WriteLine($"The updated page count is: {book.Pages}");

        }
    }
}
