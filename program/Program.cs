using System.ComponentModel;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter some numbers:\n");
            int one = int.Parse(Console.ReadLine());
            Console.Write("\n");
            int two = int.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine(Times(one, two));
        }
        public static int Times(int one, int two)
        {
            return one * two;
        }
    }
}
