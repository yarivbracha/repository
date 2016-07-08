using System;

namespace Appendix
{
    class TestAppendix
    {
        public void RunAppendix()
        {
            Rationals.Rational firstRational = new Rationals.Rational(-1, 2);
            Rationals.Rational secondRational = new Rationals.Rational(3, 18);
            Rationals.Rational thirdRational = new Rationals.Rational(4);
            Rationals.Rational fourthRational = new Rationals.Rational(1, -6);

            Console.WriteLine("The first rational is: {0}", firstRational.ToString());
            Console.WriteLine("The second rational is: {0}", secondRational.ToString());
            Console.WriteLine("The third rational is: {0}", thirdRational.ToString());
            Console.WriteLine("The fourth rational is: {0}\n", fourthRational.ToString());

            Console.WriteLine("{0} + {1} = {2}",firstRational,secondRational, firstRational + secondRational);
            Console.WriteLine("{0} + {1} = {2}",fourthRational, secondRational, fourthRational + secondRational);
            Console.WriteLine("{0} + {1} = {2}\n",thirdRational, firstRational, thirdRational + firstRational);

            Console.WriteLine("{0} * {1} = {2}", firstRational, secondRational, firstRational * secondRational);
            Console.WriteLine("{0} * {1} = {2}", fourthRational, secondRational, fourthRational * secondRational);
            Console.WriteLine("{0} * {1} = {2}\n", thirdRational, firstRational, thirdRational * firstRational);

            Console.WriteLine("{0} - {1} = {2}", firstRational, secondRational, firstRational - secondRational);
            Console.WriteLine("{0} - {1} = {2}", fourthRational, secondRational,  fourthRational - secondRational);
            Console.WriteLine("{0} - {1} = {2}\n", thirdRational, firstRational, thirdRational - firstRational);

            Console.WriteLine("{0} / {1} = {2}", firstRational, secondRational, firstRational / secondRational);
            Console.WriteLine("{0} / {1} = {2}", fourthRational, secondRational, fourthRational / secondRational);
            Console.WriteLine("{0} / {1} = {2}\n", thirdRational, firstRational, thirdRational / firstRational);

            double firstRationalToDoubleCast = (double)firstRational;
            double fourthRationalToDoubleCast = (double)fourthRational;
            Console.WriteLine("first rational after cast to double --> {0}", firstRationalToDoubleCast);
            Console.WriteLine("fourth rational after cast to double --> {0}\n", fourthRationalToDoubleCast);

            int firstIntToCast = 100;
            int secondIntToCast = -2;
            Rationals.Rational firstRationalCastFromInt = (Rationals.Rational)firstIntToCast;
            Rationals.Rational secondRationalCastFromInt = (Rationals.Rational) secondIntToCast;
            Console.WriteLine("first rational after cast from the integer 100 --> {0}", firstRationalCastFromInt);
            Console.WriteLine("second rational after cast from the integer -2 --> {0}\n", secondRationalCastFromInt);
        }
    }
}
