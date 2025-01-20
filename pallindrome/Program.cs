class Program
{
    static void Main(string[] args)
    {
        string choose = "";
        do
        {
            string word = "";
            string rev = "";
            Console.WriteLine("Enter word");
            word = Console.ReadLine();
            for (var i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }
            if (word == rev)
            {
                Console.WriteLine($"{word} : Pallindrome");
            }
            else
            {
                Console.WriteLine($"{word} : Not Pallindrome");
            }
            Console.WriteLine("Do you want to continue?");
            choose = Console.ReadLine().ToUpper();
        } while (choose == "Y" || choose == "YES");

        Console.WriteLine("Thank You");
        Console.WriteLine("Please leave the Page");
        Console.ReadLine();
    }
}