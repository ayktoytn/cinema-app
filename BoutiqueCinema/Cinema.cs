using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueCinema
{
    internal class Cinema
    {
       // Properties 
        public string MovieName;
        public int Capacity { get; }
        public float FullTicketPrice { get; set; }
        public float HalfTicketPrice { get; set; }
        public int SumFullTicket { get; set; }
        public int SumHalfTicket { get; set; }
        public float Turnover
        {
            get 
            {
                return this.FullTicketPrice * this.SumFullTicket + this.HalfTicketPrice * this.SumHalfTicket;
            }
           
        }

        //constructor with parameters


        // defining the object parameters
        public Cinema(string movie, int cap, float full, float half)
        {
            this.MovieName = movie;
            this.Capacity = cap;
            this.HalfTicketPrice = half;
            this.FullTicketPrice = full;
        }
        public void SellingTicket(int full, int half)
        {
            if (GetEmptySeat() >= full + half)
            {
                this.SumFullTicket += full;
                this.SumHalfTicket += half;

                
                Console.WriteLine("Purchase complete.");
            }
            else
            {
                Console.WriteLine("There are not enough empty seats. Number of the available seats is: " + GetEmptySeat());
            }
        }
        public void RefundTicket(int full, int half)
        {
            if (this.SumFullTicket >= full && this.SumHalfTicket >= half)
            {
                this.SumFullTicket -= full;
                this.SumHalfTicket -= half;
                
                Console.WriteLine("Ticket has been refunded.");
            }
            else
            {
                Console.WriteLine("You have exceeded the amount of refundable tickets.");
            }
        }
       
        public int GetEmptySeat()
        {
            return this.Capacity - this.SumHalfTicket - this.SumFullTicket;
        }
    }
}
