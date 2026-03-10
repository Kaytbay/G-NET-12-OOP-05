using oop_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class Projector
    {
        public void Start()
        {
            Console.WriteLine("Projector Start.");
        }

        public void Stop()
        {
            Console.WriteLine("Projector stop.");
        }
    }
    internal class Cinema : IPrintable
    {
        public string CinemaName { get; set; }
        private Ticket[] _tickets;

        private Projector projector;

        private int counter;


        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
            _tickets = new Ticket[20];
            counter = 0;
            projector = new Projector();
        }

        public void AddTicket(Ticket t)
        {
            if (counter < _tickets.Length)
            {
                _tickets[counter] = t;
                counter++;
            }
        }
        public void PrintAllTickets()
        {
            for (int i = 0; i < counter; i++)
            {
                _tickets[i].PrintTicket();
            }
        }
        public void OpenCinema()
        {
            projector.Start();
        }
        public void CloseCinema()
        {
            projector.Stop();
        }









        public void Print()
        {
            Console.WriteLine("--- All Cinema Tickets ---");
            foreach (var ticket in _tickets)
            {
                ticket.Print();
            }
        }


    }
}
