using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SomeClassBasic> listOfStringsBasic = new List<SomeClassBasic>();
            List<SomeClassAdvanced> listOFStringsAdvanced = new List<SomeClassAdvanced>();
            string input = null;

        }
        public class SomeClassBasic
        {
            public string normalString { get; set; }

            public string reversedString { get; set; }
        }

        public class SomeClassAdvanced
        { 
            public SomeClassAdvanced(string input)
            {
                this.normalString = input;
            }
            public string normalString { get; set; }

            public string reversedString => string.Join("", this.normalString.ToArray().Reverse());
        }
    }

}