using FrameworkExample.Lib;

namespace FrameworkExample.App
{
    [RunClass]
    public class A
    {
        [RunMethod]
        public static void Execute()
        {
            Console.WriteLine("A.Execute");
            Thread.Sleep(2000);
        }
    }
}
