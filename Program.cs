using System;

class Program
{
    static void Main(string[] args)
    {
        string[] valores;
        string Linhas = Console.ReadLine();
        valores = Linhas.Split (' ');
        int N = int.Parse(valores[0]);
        int M = int.Parse(valores[1]);

        int[] vetor = new int[N];

        for(int i = 0; i<M; i++)
        {
            string[] tres;
            string divisao = Console.ReadLine();
            tres = divisao.Split (' ');
            int P = int.Parse(tres[0]);
            int I = int.Parse(tres[1]);

            if (P==1)
            {
                int V = int.Parse(tres[2]);
                while(I < N || V > 0)
                {
                    vetor[I] = V;
                    I++;
                    V--;
                }
            } else if (P==2)
            {
                int V = int.Parse(tres[2]);
                while(I > 1 || V > 0)
                {
                    vetor[I-1] = V;
                    I--;
                    V--;
                }
            } else if (P==3)
            {
                Console.WriteLine(vetor[I-1]);
            }
        }
    }
}
