using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void MyDelegate();


    public class program12
    {
        public static void Display()
        {
            Console.WriteLine("Enter your name:");
            Console.ReadLine();
            Console.WriteLine("Enter the word to be reversed:");
            Console.ReadLine();


        }

        static void Main(string[] args)
        {
            MyDelegate obj = Display;
            obj();
        }


    }

}
