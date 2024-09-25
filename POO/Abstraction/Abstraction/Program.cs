using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PremiumMember premiumMember = new PremiumMember("John Doe", 25);
            premiumMember.DisplayMembershipDetails();
        }
    }
}
