using System;
namespace LineComparison
{
    class Program
    {
        static void Main(String[] args)
        {
            LengthOfLine computation = new LengthOfLine(30, 65, 87, 100);
            double line1 = computation.CalculateLength();
            LengthOfLine line = new LengthOfLine(35, 74, 82, 110);
            double line2 = line.CalculateLength();
            if (line1.Equals(line2))
                Console.WriteLine("Length of both lines are equal");
            else
                Console.WriteLine("Length of both lines are not equal");
                
        }
    }
}
