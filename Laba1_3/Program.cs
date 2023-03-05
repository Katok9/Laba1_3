namespace Laba_1_3
{
    class Program
    {
        static void Main()
        {
            int D = 7;
            int[] A = { 12, 23, 34, 45, 57 };

            // => - лямбда вираз
            int result = A.FirstOrDefault(number => number > 0 && number % 10 == D);
            Console.WriteLine(result);

            //test
        }
    }
}