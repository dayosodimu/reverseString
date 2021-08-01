using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string aName = "Hello World";
            Console.WriteLine(aName);




            for (int pos = 10; pos >= 0; pos--)
            {
                Console.WriteLine(aName[pos]);
            }



        }

    }


}
