using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        /*This allows everything ONLY in THIS class to see 
        the language variable
        If there was no private keyword, 
        any class could see it*/ 
        private string language;

        /*The next statement initializes
         this constructor*/
        public PrintStuff(string temp) 
        {
            language = temp;
        }

        public PrintStuff() 
        {
            language = "EN";
        }

        /*This is a method*/
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }

        /*The process of handling default values
         (i.e. the user enters no default language)
        is called overloading methods. They have the same
        exact name, but handle user input (or no imput)
        differently. The method signature 
        (the statement to construct the method) 
        needs to be different,
        but the method name can be the same.
        Below is an example of how that could be done:*/
        /*public void PrintName()
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, John or Jane Doe!");
            }
            if (language == "PT")
            {
                System.Console.WriteLine("Oi, John or Jane Doe!");
            }
        }*/
    }
}
