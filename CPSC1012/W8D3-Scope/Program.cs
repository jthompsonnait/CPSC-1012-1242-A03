namespace W8D3_Scope
{    
    internal class Program
    {
        //  global variables are bad.
        static string name2 = "Thompson";
        static void Main(string[] args)
        {
            //  name cannot be seen outside of this method
            //  name is a local variable.
            string name = "James";            
            Print(name);

            //  print and update name2 using global variable
            BadPrintUsingGlobal();
            //  print again after global variable has been change
            Print(name);

            name = PrintAndUpdateName(name);
            name = PrintAndUpdateName(name);
            PrintAndUpdateName(name);
        }

        static void Print(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine(name2);
        }

        static void BadPrintUsingGlobal()
        {
            Console.WriteLine(name2);
            name2 = "Thompson2";
            Console.WriteLine(name2);
        }

        static string PrintAndUpdateName(string name)
        {
            Console.WriteLine(name);
            return $"{name}a";
        }
    }
}