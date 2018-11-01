using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.App
{
    public class Math : IMath
    {
        public  List<int> GetListOfIntItems(int numberOfItems)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < numberOfItems; i++)
                res.Add(i);

            return res;
        }
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }

        public bool IsOdd(int value)
        {
            return value % 2 == 1;
        }
        public int GetGcd(int a, int b)
        {
            
            var firstNumber = a > 0 ? a : a * -1;
            var secondNumber = b > 0 ? b : b * -1;
            if (secondNumber == 0)
                throw new DivideByZeroException();
            do
            {
                var temp = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = temp;


            } while (secondNumber > 0);
            return firstNumber;
        }
        
    }
}
