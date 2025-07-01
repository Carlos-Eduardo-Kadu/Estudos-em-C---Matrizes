using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()!);
        int[,] mat = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            string[] numero = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < N; j++)
            {
                mat[i,j] = int.Parse(numero[j]);
            }
        }

        for (int i = 0;i < N; i++) 
        {
            int maioNum = 0;

            for (int j = 0;j < N; j++)
            {
                if(maioNum < mat[i, j])
                { 
                    maioNum = mat[i, j];
                }
            }
            Console.WriteLine(maioNum);
        }
    }
}
