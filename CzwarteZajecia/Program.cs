using System;

namespace CzwarteZajecia
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table= {1,2,3,4,5};
            int[] newTable= {1,2,3,4,5};
            foreach (var VARIABLE in table)
            {
                Console.Write(VARIABLE);
            }
            foreach (var VARIABLE in newTable)
            {
                Console.Write(VARIABLE);
            }
        }
    }
}