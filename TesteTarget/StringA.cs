using System;

class StringA { 
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase");
        String input = Console.ReadLine();

        int quantidade = ContarOcorrencias(input);

        if (quantidade > 0)
        {
            Console.WriteLine("A letra 'A' aparece" + quantidade + " vezes na frase");
        }
        else 
        {
            Console.WriteLine("A letra 'A' não aparece na String");
        }
    }


    //Função que conta as ocorrências de A
    static int ContarOcorrencias(string texto)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A') 
            {
                contador++;
            }
        }

        return contador;

    }
}

