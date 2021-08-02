using System;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Returning a reverse string 

            string aName = "Hello World";
         
            for (int pos = 10; pos >= 0; pos--)
            {
                Console.Write(aName[pos]);
            }
            
        }

    }


}
