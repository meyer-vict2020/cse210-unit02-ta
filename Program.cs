using System;
using Cse210_Unit02_Ta;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Address address1 = new Address();
            address1.Street = "S 2nd W";
            address1.City = "Rexburg";
            address1.State = "Idaho";
            
            PhoneNumber phoneNumber1 = new PhoneNumber();
            phoneNumber1.AreaCode = "123";
            phoneNumber1.Prefix = "456";
            phoneNumber1.Suffix = "7890";

            address1.DisplayMailingLabel();

        }
    }
}
