using System;

class Program
{
    static void Main()
    {
        int nota1, nota2, nota3, nota4;

        Console.WriteLine("Digite as quatro notas do aluno (de 1 a 10):");

        Console.Write("Nota 1: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nota 2: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nota 3: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nota 4: ");
        nota4 = Convert.ToInt32(Console.ReadLine());

        int media = (nota1 + nota2 + nota3 + nota4) / 4;

        Console.WriteLine("Média: " + media);

        if (media >= 6)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}
