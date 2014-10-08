using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;

        public void Initialize()
        {
            Random randomNumber = new Random();
            _number = randomNumber.Next(1, 101);
            _count = 0;
        }

        public SecretNumber()
        {
            Initialize();
        }

        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)

	            {
		             throw new ApplicationException();
	            }
                        if (number < 1 || number > 100)
	            {
		             throw new ArgumentOutOfRangeException();
	            }

                if (number < _number)
                {
                    _count = _count + 1;
                    Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));

                    if (_count == MaxNumberOfGuesses)
                    {
                        Console.WriteLine("Det hemliga talet är {0}", _number);
                    }
                    return false;
                }
                else if (number > _number)
                {
                    _count = _count + 1;
                    Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count));

                    if (_count == MaxNumberOfGuesses)
                    {
                        Console.WriteLine("Det hemliga talet är {0}", _number);
                    }
                    return false;
                }
                else
                {
                    _count = _count + 1;
                    Console.WriteLine("RÄTT GISSAT! Du klarade det på {0} försök", _count);
                    return true;
                }

            }

        }

    }