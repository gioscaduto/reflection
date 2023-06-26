using FrameworkExample.Lib;

List<Result> results = AutoRunner.Run();

foreach (Result result in results)
{
    Console.WriteLine(result);
}