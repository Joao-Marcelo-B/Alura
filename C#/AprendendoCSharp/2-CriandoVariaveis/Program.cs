using System;

class Programa
{
    static void Main(string[] args)
    {
        int idade = 19; //32Bits 
        Console.WriteLine(idade);
  
        double salario = 1312.73; //64 Bits
        Console.WriteLine(salario);

        long x = 2000000000000000000; //64Bits
        Console.WriteLine(x);

        short pequena = 16000;
        Console.WriteLine(pequena);

        float altura = 1.79f;
        Console.WriteLine(altura);

        Console.WriteLine("Pressiona qualquer tecla para fechar ...");
        Console.ReadLine();
    }
}