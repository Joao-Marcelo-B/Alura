using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto - Caracteres e Textos\n");

        char letra = (char)65; //(char) 65 ou 'A'
        Console.WriteLine(letra);

        string nome = "João Marcelo ";
        string sobrenome = "Batista Narciso";
        Console.WriteLine(nome);
        Console.WriteLine(nome.Length);
        Console.WriteLine(nome + sobrenome);

        string cursos = @"Cursos de : 
- C# 
- Python 
- Java";
        Console.WriteLine("\n" + cursos);

        Console.WriteLine("\nTecle Enter para fechar ...");
        Console.Read();
    }
}