
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
