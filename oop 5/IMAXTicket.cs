using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class IMAXTicket : Ticket
    {

        public bool Is3D { get; set;}

        public override decimal Price
        {
            get { return Is3D ? _price + 30m : _price; }
            set { _price = value > 0 ? value : 0; }

        }



        public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, price)
        {
            Is3D = is3D;
        }


        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax}"
                + $"Is 3D: {Is3D}";
        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" Is3D: {Is3D}");
        }







        public override void Print()
        {
            string s = IsBooked ? "Yes" : "No";
            Console.WriteLine($"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax}"
                + $"Is 3D: {Is3D} , Booked : {s} ");
        }

    }
}
