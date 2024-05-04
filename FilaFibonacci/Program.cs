using System.Runtime.Intrinsics.X86;

namespace FilaFibonacci
{
    internal class Program
    {
        static FilaFibonacci fila = new FilaFibonacci();
        static int n1 = -1, n2 = 1, aux = 0, op;
        static void Checar()
        {
            op = int.Parse(Console.ReadLine());
            while (op < 1)
            {
                Console.WriteLine("Digite uma opção válida!");
                op = int.Parse(Console.ReadLine());
            }
        }
        static void PovoarFila()
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
                Console.WriteLine(">>>Sequencia Fibonacci<<<");
                Console.WriteLine("\nQuantos Números da sequencia Fibonacci você quer ver?\n");
                Checar();
                PovoarFila();
            } while (true);
        }
    }
}

