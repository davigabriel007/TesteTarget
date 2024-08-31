using System;

class Soma
{
    static void Main(string[] args)
    {
        int indice = 12;
        int soma = 0;
        int K = 1;

        while (K < indice)
        {
            K += K;
            soma = soma + K;
        }

        Console.WriteLine("O valor final da soma é:" + soma);
    }
}

