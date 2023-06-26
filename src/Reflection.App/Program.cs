using System.Reflection;

Console.WriteLine("Document class:");
Type t = Type.GetType("Reflection.App.Document");

ShowProperties(t);
CallMethod(t);

static void ShowProperties(Type t)
{
    PropertyInfo[] props = t.GetProperties();
    
    Console.WriteLine("Properties:");

    foreach (PropertyInfo prop in props)
    {
        Console.WriteLine($"{prop.Name} => {prop.PropertyType}");
    }
}

static void CallMethod(Type t)
{
    MethodInfo method = t.GetMethod("Init");
    
    Console.WriteLine("Init method:");
    
    if (method == null)
    {
        Console.WriteLine("Method not found");
    }
    else
    {
        object obj = Activator.CreateInstance(t);
        method.Invoke(obj, null);
    }
}