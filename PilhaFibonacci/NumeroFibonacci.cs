using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaFibonacci
{
    internal class NumeroFibonacci
    {
        int Number;
        NumeroFibonacci Previous;
        public NumeroFibonacci(int numero)
        {
            Number = numero;
            Previous = null;
        }
        public void SetPrevious(NumeroFibonacci numeroFibonacci)
        {
            Previous = numeroFibonacci;
        }
        public NumeroFibonacci GetPrevious()
        {
            return Previous;
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
