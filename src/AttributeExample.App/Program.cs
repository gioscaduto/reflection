using AttributeExample.App;
using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();
Type[] types = assembly.GetTypes();

ShowClassWithMessageAttribute(types);

static void ShowClassWithMessageAttribute(Type[] types)
{
    foreach (Type type in types)
    {
        // Another way
        //MessageAttribute attr = (MessageAttribute)type.GetCustomAttribute(typeof(MessageAttribute));
        MessageAttribute attr = type.GetCustomAttribute<MessageAttribute>();    

        if (attr != null)
        {
            Console.WriteLine($"Class: {type.FullName}, value: {attr.Value}");
        }
    }
}
