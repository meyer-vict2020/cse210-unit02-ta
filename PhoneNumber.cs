using System;

namespace Cse210_Unit02_Ta
{
    public class PhoneNumber
    {
        public string AreaCode;
        public string Prefix;
        public string Suffix;

        public void DisplayNumber(){
            Console.WriteLine($"({AreaCode}){Prefix}-{Suffix}");
        }
    }
}
