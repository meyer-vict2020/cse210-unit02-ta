using System;
using Cse210_Unit02_Ta;

namespace Cse210_Unit02_Ta
{
    public class Address
    {
        public string Street;
        public string City;
        public string State;

        public void DisplayMailingLabel()
        {
            Console.WriteLine($"{Street}");
            Console.WriteLine($"{City}, {State}");
        }
        
    }
}
