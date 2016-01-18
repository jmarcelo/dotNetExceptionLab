//using dotNetExceptionLab.Lib;
using System;

namespace dotNetExceptionLab.v45
{
    public class TestClassWithoutEx
    {
        public void badWorkWithoutEx()
        {
            try
            {
                int a = 10;
                int b = 1 / (a - 10);   // Line 13
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                throw;
            }
        }
    }
}
