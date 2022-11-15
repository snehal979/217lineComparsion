namespace LineComparisionPart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CalculateLenght line1 = new CalculateLenght();
            double line1 =CalculateLenght.LenghtOfLine(1, 2, 4, 3);
            Console.WriteLine(line1);

            //CalculateLenght line2 = new CalculateLenght();
            double line2 = CalculateLenght.LenghtOfLine(2, 8, 4, 7);
            Console.WriteLine(line2);

            EqualLenght(line1, line2);
        }

        public static void EqualLenght(double line1, double line2)
        {
            // comparison

            double compare = line1.CompareTo(line2);

            if (compare > 0)
            {
                Console.WriteLine("the line 1 is greater than line 2 ");

            }
            else if (compare < 0)
            {
                Console.WriteLine("line 1 is less than line 2 ");
            }
            else
            {
                Console.WriteLine("line 1 is equal to line 2");
            }
        }
    }
}
