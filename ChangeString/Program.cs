using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicita uma string ao utilizador
            Console.WriteLine("String:");
            string inputString = Console.ReadLine();

            //Solicita um caracter ao utilizador
            Console.WriteLine("Caracter: ");
            char charToReplace = Console.ReadKEY() .KeyChar;
            Console.WriteLine() // Para saltar linha após entrada do caracter

            // Substitui o caracter na string por "X"
            String modifiedString = ReplaceChar(inputString,charToReplace);

            // Imprime a string modificada
            Console.WriteLine("Será impresso: " + modifiedString);
        }
        
        // Método para substituir um caracter por X na string
        static string ReplaceChar (string input, char, charToReplace)
        {
            // Converte a string num array de caracteres
            char[] charArray = input.ToCharArray();

            // Percorre o array do caracter e substitui o caracter quando necessário
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == charToReplace)
                {
                    charArray[i] = 'X'; // Substitui o caracter por 'X'
                }
            }

            // Retorna a string modificada
            return new string (charArray)
        }
    }
}
