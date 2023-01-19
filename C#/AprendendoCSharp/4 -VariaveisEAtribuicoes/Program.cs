using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atribuições de variáveis");

        int idade = 30;
        int idadeAna = idade;

        idade = 25;
        //A variável idadeAna continuará valendo 30
        //Já a variável idade agora ficará valendo 25 

        Console.WriteLine("Precione Enter para fechar ...");
        Console.Read();
    }
}