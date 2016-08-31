using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xaml_Ex
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Mult 
    {
        public Mult()
        {

        }
        public Mult(Plus plus, Scalar scalar)
        {
            Result.Num = plus.Result.Num * scalar.Num;
        }
        public Scalar Result { get; set; }
        public Plus plus { get; set; }
    }

    public class Plus 
    {
        public Plus()
        {

        }
        public Plus(Scalar first, Scalar second)
        {
            Result.Num = first.Num + second.Num;
        }
        public Scalar Result { get; set; }
    }

    public class Scalar
    {
        public Scalar()
        {

        }
        public int Num { get; set; }
    }
}
