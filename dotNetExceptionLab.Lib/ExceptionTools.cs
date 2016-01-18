using System;
using System.Reflection;

namespace dotNetExceptionLab.Lib
{
    public class ExceptionTools
    {
        public static void PreserveStackTrace(Exception exception)
        {
            MethodInfo preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace",
              BindingFlags.Instance | BindingFlags.NonPublic);
            preserveStackTrace.Invoke(exception, null);
        }
    }
}
