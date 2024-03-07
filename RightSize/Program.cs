using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                if (arg.Length > 6)
                {
                    // Se um argumento tiver mais de 6 caracteres, termina o programa
                    return;
                }
                else if (args.Length > 3)
                {
                    // Mostra o argumento se tiver mais de 3 caracteres
                    Console.WriteLine(arg);
                }            
            }
        }
    }
}
