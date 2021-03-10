using System;

namespace urok_za_hora_koito_za_nazad
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int star =1;
            int n = rows/2;
            for(int i = 0; i <= rows / 2; i++)
            {
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', star));
                n--;
                star += 2;
            }
            for (int j = 0; j <= rows / 2; j++)
            {
                n++;
                star -= 2;
                Console.Write(new string(' ', n));
                Console.WriteLine(new string('*', star));
               
            }
        }
    }
}

