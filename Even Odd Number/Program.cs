namespace Even_Odd_Number
{
    class EvenOddCheck
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"{num} is an Even number.");
            else
                Console.WriteLine($"{num} is an Odd number.");
            Console.ReadLine();
        }

     
    }
     
}
