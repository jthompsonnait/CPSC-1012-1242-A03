namespace W12D1_SimpleClass
{
    public class Book
    {
        #region Fields
        private string _title;  // Backing store for Title
        private string _author; // Backing store for Author
        private int _pages; // Backing store for Pages
        #endregion

        #region Properties

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }
        #endregion

        #region Methods
        // method to display all of the book information
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
        }

        //  return a string that contains the book detail
        public string GetBookDetails()
        {
            return $"Title: {Title}, Author: {Author}, Pages: {Pages}";
        }
        #endregion
    }
}
