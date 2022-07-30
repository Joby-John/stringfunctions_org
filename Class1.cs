using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringfunctions_org
{
      class Class1
    {
        public void upper()// function
        {
            //using uppercase function
            string str = ("Whats your name dear dear ?");
            Console.WriteLine(str.ToUpper());
            //using lowercase function
            Console.WriteLine(str.ToLower());
            //using contain function
            Console.WriteLine(str.Contains("dear"));
            //to access using index
            Console.WriteLine(str[1]);
            //to find index of something in a string
            Console.WriteLine( str.IndexOf("name"));//-1 for absent charcaters
            //to print a substring
            Console.WriteLine(str.Substring(11,5));//5 is number of characters to grab
        }
    }

}
