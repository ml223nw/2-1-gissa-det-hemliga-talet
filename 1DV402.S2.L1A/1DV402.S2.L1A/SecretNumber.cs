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
            _number = randomNumber.Next(1, 100);
            _count = 0;
        }

        public SecretNumber()
        {
            Initialize();
        }

        public bool MakeGuess
        {
            if (_number >= MaxNumberOfGuesses)
	            {
		             throw new ApplicationException();
	            }
                        if (_number < 1 || _number > 100)
	            {
		             throw new ArgumentOutOfRangeException();
	            }