namespace FilaFibonacci
{
    internal class FilaFibonacci
    {
        NumeroFibonacci Head;
        NumeroFibonacci Tail;
        public FilaFibonacci()
        {
            Head = null;
            Tail = null;
        }
        public bool IsEmpty()
        {
            return Head != null && Tail != null;
        }
        public string MessageEmpty()
        {
            return "Fila Vazia!";
        }
        public void Push(NumeroFibonacci aux)
        {
            if (IsEmpty())
                Head = Tail = aux;
            else
            {
                Tail.SetNext(aux);
                Tail = aux;
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
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetNext();
                } while (aux != Tail.GetNext());
            }
        }
    }
}
