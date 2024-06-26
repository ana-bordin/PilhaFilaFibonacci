﻿using System.Runtime.Intrinsics.X86;

namespace FilaFibonacci
{
    internal class Program
    {
        
        static int n1, n2, aux, op;
        static void Checar()
        {
            op = int.Parse(Console.ReadLine());
            while (op < 1)
            {
                Console.WriteLine("Digite uma opção válida!");
                op = int.Parse(Console.ReadLine());
            }
        }
        static void PovoarFila(FilaFibonacci fila)
        {
            for (int i = 0; i < op; i++)
                fila.Push(Calcular());
        }
        static NumeroFibonacci Calcular()
        {
            aux = n1 + n2;
            n1 = n2;
            n2 = aux;
            NumeroFibonacci numero = new NumeroFibonacci(aux);
            return numero;
        }
        static void Main(string[] args)
        {
            do
            {
                n1 = -1;
                n2 = 1; 
                aux = 0;
                FilaFibonacci fila = new FilaFibonacci();
                Console.WriteLine(">>>Sequencia Fibonacci<<<");
                Console.WriteLine("\nQuantos Números da sequencia Fibonacci você quer ver?\n");
                Checar();
                PovoarFila(fila);
                Console.WriteLine("Elementos da Sequencia:");
                fila.Print();
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}

