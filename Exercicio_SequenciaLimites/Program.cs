using System;

namespace Exercicio_SequenciaLimites
{
    class Program
    {
        static void Main(string[] args)
        {
           //receber dois numeros inteiros seja negativou ou positivo,
           // caso o segundo numero seja menor que o primeiro exibir uma mensagem de erro (if))
           // caso não seja exibir a sequencia de numeros entre eles inclusive eles mesmo 
           //Início: Fim: 
           
           Console.WriteLine("\nSeja bem vindo !!");
           Console.WriteLine("\nO progama consiste em encontrar a sequência de números entre os algarismos digitados.");
           Console.WriteLine("Para iniciá-lo digite.......");
           
           Console.Write("Início: ");
           int inicio = Convert.ToInt32(Console.ReadLine());
           
           Console.Write("Fim:... ");
           int fim = Convert.ToInt32(Console.ReadLine());

           if (fim > inicio )
           {
               while (inicio <= fim)
               {
                   Console.WriteLine($"{inicio}"); 
                   inicio += 1;
               }
           }
           else 
           {
               Console.WriteLine("O número final não pode ser maior que o número desejado para o início da sequência.");
           }
           Console.WriteLine("\nAté a próxima........");
        }
    }
}
