using System.Diagnostics;
using System.Reflection;

namespace FrameworkExample.Lib
{
    public static class AutoRunner
    {
        public static List<Result> Run()
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            Type[] types = assembly.GetTypes();
            var results = new List<Result>();
            var timer = new Stopwatch();

            foreach (Type type in types)
            {
                if (type.GetCustomAttribute<RunClassAttribute>() != null)
                {
                    InvokeMethods(type, results, timer);
                }
            }

            return results;
        }

        private static void InvokeMethods(Type type, List<Result> results, Stopwatch timer)
        {
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                if (method.GetCustomAttributes<RunMethodAttribute>() != null && method.IsStatic)
                {
                    timer.Start();
                    method.Invoke(null, null);
                    timer.Stop();

                    var result = new Result(type, method, timer.Elapsed);
                    results.Add(result);

                    timer.Reset();
                }
            }
        }
    }
}
