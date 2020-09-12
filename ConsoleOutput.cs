public class ConsoleOutput : IOutput
{
    public void write(string content)
    {
        System.Console.WriteLine(content);
    }
}