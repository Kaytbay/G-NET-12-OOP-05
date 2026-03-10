using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }

        public decimal ServiceFee { get { return 50; } }


        public VIPTicket (string movieName, decimal price,bool loungeAccess):base (movieName, price)
        {
            LoungeAccess= loungeAccess;
        }

        public override string ToString()
        {
            return $"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax}"
                  + $", Lounge Access: {LoungeAccess}, Service Fee: {ServiceFee}";
        }
        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($" LoungeAccess : {LoungeAccess} , Fee : {ServiceFee} ");

        }





        public override void Print()
        {
            Console.WriteLine($"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax}"
                  + $", Lounge Access: {LoungeAccess}, Service Fee: {ServiceFee}");
        }

    }
}
