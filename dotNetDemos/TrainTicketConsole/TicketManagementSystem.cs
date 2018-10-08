using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainTicketConsole
{
    public class TicketManagementSystem
    {
        public List<Train> Trains = new List<Train>();

        public double GetTotalAmountCollected()
        {
            double amt = 0;
            foreach(var train in Trains)
            {
                foreach (var passenger in train.Passengers)
                {
                    foreach (var ticket in passenger.tickets)
                    {
                        amt += ticket.Amount;
                    }
                }
            }
            return amt;
        }
        public List<Ticket> GetTickets(Passenger passenger)
        {
            return passenger.tickets;
        }
        public List<Passenger> GetPassengers(Train train)
        {
            return train.Passengers;
        }
    }
}