using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaFibonacci
{
    internal class PilhaFibonacci
    {
        NumeroFibonacci Head;
        public PilhaFibonacci()
        {
            Head = null;
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
        public string MessageEmpty()
        {
            return "Pilha Vazia!";
        }
        public void Push(NumeroFibonacci aux)
        {
            if (IsEmpty())
                Head = aux;
            else
            {
                aux.SetPrevious(Head);
                Head = aux;
            }
        }
        public void Print()
        {
            if (IsEmpty())
                MessageEmpty();
            else
            {
                NumeroFibonacci aux = Head;
                do
                {
                    Console.Write($"{aux.ToString()}, ");
                    aux = aux.GetPrevious();
                } while (aux != null);
            }
        }
    }
}
