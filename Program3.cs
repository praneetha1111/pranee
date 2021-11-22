// See https://aka.ms/new-console-template for more information
namespace Giraffe
{
    class Maximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMax(59, 6));
            Console.ReadLine();        }
        static int getMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
    }
}