

namespace TDD.App
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public interface IMath
    {
        int GetGcd(int a, int b);
        List<int> GetListOfIntItems(int numberOfItems);
        bool IsOdd(int value);
        bool IsPrime(int a);
    }
}
