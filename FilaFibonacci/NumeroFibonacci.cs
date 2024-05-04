using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaFibonacci
{
    internal class NumeroFibonacci
    {
        int Number;
        NumeroFibonacci Next;
        public NumeroFibonacci(int numero)
        {
            Number = numero;
            Next = null;
        }
        public void SetNext(NumeroFibonacci numeroFibonacci)
        {
            Next = numeroFibonacci;
        }
        public NumeroFibonacci GetNext()
        {
            return Next;
        }
        public int GetNumber()
        {
            return Number;
        }
        public override string ToString()
        {
            return $"{Number}";
        }
    }
}
