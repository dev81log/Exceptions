namespace Exceptions
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var myArray = new int[5];

            for (var index = 0; index < 8; index++)
            {
                Console.WriteLine(myArray[index]);
            }
        }
    }
}