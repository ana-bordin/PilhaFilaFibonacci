namespace PilhaFibonacci
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
        static void PovoarPilha(PilhaFibonacci pilha)
        {
            for (int i = 0; i < op; i++)
                pilha.Push(Calcular());
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
                PilhaFibonacci pilha = new PilhaFibonacci();
                Console.WriteLine(">>>Sequencia Fibonacci<<<");
                Console.WriteLine("\nQuantos Números da sequencia Fibonacci você quer ver?\n");
                Checar();
                PovoarPilha(pilha);
                Console.WriteLine("Elementos da Sequencia:");
                pilha.Print();
                Console.ReadKey();
                Console.Clear();
            } while (true);
        }
    }
}
