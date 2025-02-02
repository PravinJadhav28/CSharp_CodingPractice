
   // string inputString = "Hello, World! 123 @#$%";
    Console.Write("Plz Enter special chracter string: ");
    string name = Console.ReadLine();
   string outputString = RemoveSpecialCharacters(name);
    Console.WriteLine($"After Removal Special Character:{outputString}");


 static string RemoveSpecialCharacters(string inputString)
{
    string result = "";
    foreach (char c in inputString)
    {
        if ((c >= 'a' && c <= 'z') ||
         (c >= 'A' && c <= 'Z') ||
          (c >= '0' && c <= '9') ||
           c == ' ')
        {
            result += c;
        }
    }
    return result;
    Console.ReadLine();
}