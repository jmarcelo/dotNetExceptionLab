using dotNetExceptionLab.Lib;
using System;

namespace dotNetExceptionLab.v45
{
    public class TestClassPreserved
    {
        public void badWorkPreserved()
        {
            try
            {
                int a = 10;
                int b = 1 / (a - 10);   // Line 13
            }
            catch (Exception ex)
            {
                ExceptionTools.PreserveStackTrace(ex);
                Console.WriteLine(ex);
                Console.WriteLine();
                throw;
            }
        }
    }
}
