using System.Reflection;

namespace FrameworkExample.Lib
{
    public class Result
    {
        public Type ClassType { get; private set; }
        public MethodInfo Method { get; private set; }
        public TimeSpan Time { get; private set; }

        public Result(Type classType, MethodInfo method, TimeSpan time)
        {
            ClassType = classType;
            Method = method;
            Time = time;
        }

        public override string ToString() =>
            $"Class: {ClassType.Name}, Method: {Method.Name}, Time: {Time.Hours:00}h:{Time.Minutes:00}m:{Time.Seconds:00}s:{Time.Milliseconds:000}ms";
    }
}
