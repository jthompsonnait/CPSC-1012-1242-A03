namespace W7D2_LogicalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] physicalArray = new int[10];
            physicalArray[0] = 1;
            physicalArray[1] = 2;
            physicalArray[2] = 3;
            physicalArray[3] = 4;
            physicalArray[4] = 5;

            for (int i = 0; i < physicalArray.Length; i++)
            {
                Console.WriteLine(physicalArray[i]);
            }

            ////  second way of create physical arrays
            //int j = 0;
            //int[] physicalArray2 = new int[10];
            //physicalArray2[j++] = j;
            //physicalArray2[j++] = j;
            //physicalArray2[j++] = j;
            //physicalArray2[j++] = j;
            //physicalArray2[j++] = j;

            //for (int i = 0; i < physicalArray2.Length; i++)
            //{
            //    Console.WriteLine(physicalArray2[i]);
            //}

            int[] logicalArray = new int[10];
            int logicalSize = 0;
            Console.WriteLine($"Logical Size {logicalSize}");
            logicalArray[logicalSize++] = 10;
            Console.WriteLine($"Logical Size {logicalSize}");
            logicalArray[logicalSize++] = 20;
            Console.WriteLine($"Logical Size {logicalSize}");
            logicalArray[logicalSize++] = 30;
            Console.WriteLine($"Logical Size {logicalSize}");
            logicalArray[logicalSize++] = 40;
            Console.WriteLine($"Logical Size {logicalSize}");
            logicalArray[logicalSize++] = 50;
            Console.WriteLine($"Logical Size {logicalSize}");

            for (int i = 0; i < logicalSize; i++)
            {
                Console.WriteLine(logicalArray[i]);
            }

            int[] smallArray = new int[3];
            smallArray[0] = 100;
            smallArray[1] = 200;
            smallArray[2] = 300;

            List<int> largeList = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                largeList.Add(1000 + i);
            }

            //largeList = largeList.OrderByDescending(x => x).ToList();

            foreach (var number in largeList)
            {
                Console.WriteLine(number);
            }

        }

    }
}
