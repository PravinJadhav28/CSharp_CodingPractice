class Program
{
    static void Main(string[] args)
    {
        int a = 22;
        int b = 40;
        Console.WriteLine($"a : {a} b : {b}");
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"After swap a: {a}");
        Console.WriteLine($"After swap b : {b}");

        Console.ReadLine();
    }
}
