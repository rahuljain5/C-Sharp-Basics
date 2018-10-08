using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipApp
{
    /// <summary>
    /// Singleton class usedfor creating membership objects based on the Specification
    /// </summary>
    class MembershipFactory
    {
        public static readonly MembershipFactory Instance = new MembershipFactory();//readonly for singleton classes
        private Dictionary<string, Membership> memberships = new Dictionary<string,Membership>();
        private MembershipFactory()
        {
            memberships.Add( "silver", new Membership { TypeOfMembership = "Silver", Fee = 2000, Discount = 10 });
            memberships.Add("gold", new Membership { TypeOfMembership = "Gold", Fee = 5000, Discount = 15 });
            memberships.Add("platinum", new Membership { TypeOfMembership = "Platinum", Fee = 10000, Discount = 20 });
        }
        /// <summary>
        /// Returns the type of membership 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public Membership GetMembership(string type)
        {
            return memberships[type];
        }
    }
}
