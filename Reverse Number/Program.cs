namespace Reverse_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int num = 123568;
             int temp = 0;


             while (num>0)
             {
                 temp =num % 10 + temp*10;
                 //temp *= 10;

                 num /= 10;
             }

             Console.WriteLine(temp);
         }*/


            // second way

            int num = 1002;
            int reversed = 0;
            

            string x= num.ToString();   

            char[] arr= x.ToArray();

            for (int i = arr.Length-1; i>=0 ; i--) {

                reversed = (arr[i]-'0') + reversed * 10;

            }
            Console.WriteLine(reversed);    


            // find asccii  value

            for(int i = 0; i <= 127; i++)
            {
                Console.WriteLine($" {i} Asscii value = {(char)i} " );
            }
        }
    }
}
