using System;

namespace Cse210_Unit02_Ta
{
    public class PhoneNumber
    {
        public string AreaCode = "760";
        public string Prefix = "301";
        public string Suffix = "4683";

        public void DisplayNumber(){
            Console.WriteLine($"({AreaCode}){Prefix}-{Suffix}");
        }
    }
}
