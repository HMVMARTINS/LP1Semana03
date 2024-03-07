using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length !=6)
            {
                Console.WriteLine("Indique 6 argumentos: arg1, arg2, arg3, arg4, arg5, arg6");
                return           
            }    
            
            // Parse dos argumentos para float
            float arg1 = float.Parse(args[0]);
            float arg2 = float.Parse(args[1]);
            float arg3 = float.Parse(args[2]);
            float arg4 = float.Parse(args[3]);
            float arg5 = float.Parse(args[4]);
            float arg6 = float.Parse(args[5]);

            //Defenir a matriz A e o vector B

            float[,] A = { arg1, arg2}, {arg3, arg4} };
            float[] B = {arg5, arg6};

            // Realizar a multiplicação da matriz A pelo vector B
            float[] result = MultiplyMatrixVector (A, B);

            //Imprime o resultado
            Console.WriteLine("Resultado da multiplicação: " + result[0]); 
            Console.WriteLine("Resultado da multiplicação: " + result[1]); 
        }
        static float[] MultiplyMatrixVector(float[,]matrix, float [] vector)
        {
        float[] result = new float[2];
        result[0] = matrix[0,0] * vector [0] + matrix [0,1] * vector[1];
        result[1] = matrix[1,0] * vector [0] + matrix [1,1] * vector[1];
        return result;
    }
}
