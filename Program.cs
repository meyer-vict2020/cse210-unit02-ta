using System;
using Cse210_Unit02_Ta;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Address address1 = new Address();
            address1.Street = "649 S 2nd W";
            address1.City = "Rexburg";
            address1.State = "Idaho";
            address1.DisplayMailingLabel();

            PhoneNumber phoneNumber1 = new PhoneNumber();
            phoneNumber1.DisplayNumber();
        }
    }
}
