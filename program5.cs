using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLT_Programs
{
    class Program5
    {
        static void Main()
        {
            double costOfProject, totalHoursContributed, externalConsultantCost, vendorSoftwareCost, vendorInfraCost;
            double billingRate, clientInfraCost, clientSoftwareCost, profitLoss;
            //bool softwareType = false;
            Console.WriteLine("Enter Billing Rate by Vendor");
            billingRate = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Total Contributed Hours by Vendor");
            totalHoursContributed = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter External Consultant Costs by Vendor");
            externalConsultantCost = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Total Software Cost by vendor");
            vendorSoftwareCost = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter Total Infra Cost by Vendor");
            vendorInfraCost = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Is the Software Propreitory? Y/N");
            if (Console.Read() == 'N')
            {
                clientSoftwareCost = (vendorSoftwareCost * 50) / 100;
                vendorSoftwareCost = clientSoftwareCost;
            }
            else
            {
                clientSoftwareCost = vendorSoftwareCost;
                vendorSoftwareCost = 0;
            }
            clientInfraCost = vendorInfraCost * 0.3;
            vendorInfraCost = vendorInfraCost - clientInfraCost;
            costOfProject = externalConsultantCost + vendorInfraCost + vendorSoftwareCost + externalConsultantCost;
            profitLoss = (totalHoursContributed * billingRate) - costOfProject;
            if (profitLoss > 0) Console.WriteLine("Profit: "+ profitLoss);
            else if(profitLoss< 0) Console.WriteLine("Loss: " + profitLoss);
            else Console.WriteLine("No Profit, No Loss");
        }
    }
}
