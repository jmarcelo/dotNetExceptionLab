using dotNetExceptionLab.Lib;
using System;

namespace dotNetExceptionLab.v45
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WithEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
            }

            try
            {
                WithoutEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
            }

            try
            {
                Preserved();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static void WithEx()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Test with 'throw ex;'");
            Console.WriteLine();
            try
            {
                var t = new TestClassWithEx();
                t.badWorkWithEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                throw ex;
            }
        }

        private static void WithoutEx()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Test with 'throw;'");
            Console.WriteLine();
            try
            {
                var t = new TestClassWithoutEx();
                t.badWorkWithoutEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine();
                throw;
            }
        }

        private static void Preserved()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Test preserved");
            Console.WriteLine();
            try
            {
                var t = new TestClassPreserved();
                t.badWorkPreserved();
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
