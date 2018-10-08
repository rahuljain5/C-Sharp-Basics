using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketManagementSystem tms = new TicketManagementSystem();
            Train t1 = new Train();
            tms.Trains.Add(t1);
            Passenger p1 = new Passenger();
            t1.Passengers.Add(p1);
            Ticket ti1 = new Ticket { Amount = 750.00 };
            Ticket ti2 = new Ticket { Amount = 950.00 };
            p1.tickets.Add(ti1);
            p1.tickets.Add(ti2);
            
            foreach (var pass in tms.GetPassengers(t1))
            {
                Console.WriteLine(pass.GetHashCode());
            }
            Console.WriteLine("Total Amount: " + tms.GetTotalAmountCollected());
            foreach (var ticket in tms.GetTickets(p1))
            {
                Console.WriteLine(ticket.GetHashCode());
            }
        }
    }
}
