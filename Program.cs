namespace Exceptions
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var myArray = new int[5];

            try
            {
                // for (var index = 0; index < 8; index++)
                //     Console.WriteLine(myArray[index]);

                VerificaTexto(false);
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.InnerException);
                Console.WriteLine(exception.Message);
                Console.WriteLine("Verificou aqui");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Ops...Algo deu errado!");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Verificado e agora True");
            }
        }

        static void VerificaTexto(bool ok)
        {
            if (ok == true)
                Console.WriteLine("Verdadeiro");
            throw new Exception("Resultado da verificação do texto foi False");
        }
    }
}