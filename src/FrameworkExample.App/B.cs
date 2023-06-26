using FrameworkExample.Lib;

namespace FrameworkExample.App
{
    [RunClass]
    public class B
    {
        [RunMethod]
        public static void Start()
        {
            Console.WriteLine("B.Start()");
            Thread.Sleep(1000);
        }
    }
}
