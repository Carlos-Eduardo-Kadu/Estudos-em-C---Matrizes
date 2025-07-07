using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()!);
        int[,] mat = new int[N, N];
        int somaAcimaDiagonal = 0;

        for (int i = 0; i < N; i++)
        {
            string[] num = Console.ReadLine()!.Split(' ');

            for (int j = 0; j < N; j++)
            {
                mat[i, j] = int.Parse(num[j]);
            }
        }

        for (int i = 0;i < N; i++)
        { 
            for(int j = 0;j < N; j++) 
            {
                if (j > i) 
                {
                    somaAcimaDiagonal += mat[i, j];
                }
            }
        }
        Console.WriteLine(somaAcimaDiagonal);
    }

}
