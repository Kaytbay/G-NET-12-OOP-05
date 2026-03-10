using oop_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oop_3
{
    internal abstract class Ticket : IPrintable
    {
        public string MovieName { get; set; }

		protected decimal _price;

		public virtual decimal Price
		{
			get { return _price; }
			set { _price = value > 0 ? value : 0; }

		}
		public void SetPrice (decimal price)
		{
			_price = price;
		}

		public void SetPrice(decimal price, decimal multiplier)
		{
			_price = price * multiplier;
		}

		private static int _ticketId;

        public int TicketId { get;private set; }

        public Ticket(string movieName, decimal price)
		{
			MovieName = movieName;
			Price = price;
			_ticketId++;
			TicketId = _ticketId;
        }

		public decimal PriceAfterTax => _price + (0.14m * _price);


		public override string ToString()
		{
			return $"Ticket ID: {TicketId}, Movie Name: {MovieName}, Price After Tax: {PriceAfterTax}";
		}
		public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket ID: {TicketId}, Movie Name: {MovieName},Price :  {Price} , Price After Tax: {PriceAfterTax}");
        }

		public static int GetTotalTickets() => _ticketId;



        public abstract void Print();


        public bool IsBooked { get; private set; }

        public bool Book()
        {
            if (IsBooked)
            {
                Console.WriteLine("Booking Failed");
                return false;
            }
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine("Cancellation Failed");
                return false;
            }
            IsBooked = false;
            return true;
        }
    }
}
