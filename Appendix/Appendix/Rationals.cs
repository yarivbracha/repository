using System;

namespace Appendix
{
    class Rationals
    {
        public struct Rational
        {
            int numerator;
            int denumerator;
            public Rational(int numerator, int denumerator)
            {
                if (denumerator != 0)
                {
                    this.numerator = numerator;
                    this.denumerator = denumerator;
                    if ((numerator < 0) && (denumerator < 0))
                    {
                        this.numerator *= -1;
                        this.denumerator *= -1;
                    }
                    else if (denumerator < 0)
                    {
                        this.numerator *= -1;
                        this.denumerator *= -1;
                    }
                }
                else
                {
                    throw new Exception("The denumerator can't be zero!!");
                }
            }

            public Rational(int numerator)
            {
                this.numerator = numerator;
                denumerator = 1;
            }

            public int Numerator
            {
                get
                {
                    return this.numerator;
                }
            }

            public int Denumerator
            {
                get
                {
                    return this.denumerator;
                }
            }

            public double Value
            {
                get
                {
                    return (double)this.Numerator / this.Denumerator;
                }
            }

            public Rational Add(Rational firstRational, Rational secondRational)
            {
                return firstRational + secondRational;
            }

            public Rational Mul(Rational firstRational, Rational secondRational)
            {
                return firstRational * secondRational;
            }

            public static Rational operator +(Rational firstRational, Rational secondRational)
            {
                firstRational.numerator *= secondRational.Denumerator;
                secondRational.numerator *= firstRational.Denumerator;
                Rational tempRational = new Rational(firstRational.numerator + secondRational.Numerator, firstRational.denumerator * secondRational.denumerator);
                return tempRational;
            }


            public static Rational operator *(Rational firstRational, Rational secondRational)
            {
                int tempNumerator = firstRational.Numerator * secondRational.Numerator;
                int tempDenumerator = firstRational.Denumerator * secondRational.Denumerator;
                Rational tempRational = new Rational(tempNumerator, tempDenumerator);
                return tempRational;
            }

            public static Rational operator -(Rational firstRational, Rational secondRational)
            {
                firstRational.numerator *= secondRational.Denumerator;
                secondRational.numerator *= firstRational.Denumerator;
                Rational tempRational = new Rational(firstRational.numerator - secondRational.Numerator, firstRational.denumerator * secondRational.denumerator);
                return tempRational;
            }

            public static Rational operator /(Rational firstRational, Rational secondRational)
            {
                if (secondRational.Value != 0)
                {
                    int tempNumerator = firstRational.Numerator * secondRational.Denumerator;
                    int tempDenumerator = firstRational.Denumerator * secondRational.Numerator;
                    Rational tempRational = new Rational(tempNumerator, tempDenumerator);
                    return tempRational;
                }
                else
                {
                    throw new Exception("Division in 0 is forbidden!");
                }
            }

            public void Reduce()
            {
                if ((this.Numerator != 1) && (this.Denumerator != 1))
                {
                    int min = Math.Min(this.Numerator, this.Denumerator);
                    for (int i = min; i > 1; i--)
                    {
                        if ((this.Denumerator % i == 0) && (this.Numerator % i == 0))
                        {
                            this.numerator /= i;
                            this.denumerator /= i;
                            break;
                        }
                    }
                }
            }

            public static explicit operator double(Rational tempRational)  
            {
                return tempRational.Value;
            }

            public static explicit operator Rational(int numToExplicit) 
            {
                Rational tempRational = new Rational(numToExplicit);  
                return tempRational;
            }

            public override string ToString()
            {
                string rationalString;
                if (this.Numerator == 0)
                {
                    rationalString = "0";
                }
                else
                {
                    rationalString = this.Numerator + "/" + this.Denumerator;
                }
                return rationalString;
            }

            public override bool Equals(object obj)
            {
                bool isEquals = false;
                Rational rational = (Rational)obj;

                double thisProportion = this.Denumerator / this.Numerator;
                double rationalProportion = rational.Denumerator / rational.Numerator;

                if (((this.Denumerator > this.Numerator) && (rational.Denumerator > rational.Numerator)) ||
                   ((this.Numerator > this.Denumerator) && (rational.Numerator > rational.Denumerator)))
                {
                    if (thisProportion == rationalProportion)
                    {
                        isEquals = true;
                    }
                }
                return isEquals;
            }

            public override int GetHashCode()
            {
                this.Reduce();
                return (this.Numerator.GetHashCode() *18) ^ this.Denumerator.GetHashCode();
            }
        }
    }
}

