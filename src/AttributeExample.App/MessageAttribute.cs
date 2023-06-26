namespace AttributeExample.App
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MessageAttribute : Attribute
    {
        public string Value { get; set; }
    }
}
