namespace W3D3_CalcTrangleSideC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  https://www.omnicalculator.com/math/right-triangle-side-angle
            //  calculate the length of side c of a triangle given the length of side a and b  
            double sideA;   // 3
            double sideB;   // 4
            double sideC;   // calculated length will be 5

            //  calculated results
            double sideASqr;
            double sideBSqr;
            double resultSideAandBSqr;

            // math
            // (sideA power 2 + sideB power 2) and the solution will then be the square root of sideA and B square.
            //  get side a
            Console.Write("Please enter in the length of side A: ");
            sideA = double.Parse(Console.ReadLine());

            //  get side b
            Console.Write("Please enter in the length of side B: ");
            sideB = double.Parse(Console.ReadLine());

            //  calcuations
            sideASqr = Math.Pow(sideA, 2);
            sideBSqr = Math.Pow(sideB, 2);
            resultSideAandBSqr = sideASqr + sideBSqr;

            sideC = Math.Sqrt(resultSideAandBSqr);

            Console.WriteLine($"Given the length of side A = {sideA}, side B = {sideB} the result for side C is {sideC}");
        }
    }
}
