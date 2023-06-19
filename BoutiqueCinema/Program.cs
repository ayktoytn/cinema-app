using System;

namespace BoutiqueCinema
{
    internal class Program
    {
        
        static Cinema Cnm;
        static void Main(string[] args)
        {
            Application();
           
        }
       
        static int GetNumber(string message)
        {
            bool answer;
            int num;
            while (true)
            {
                Console.Write(message);
                answer = int.TryParse(Console.ReadLine(), out num);
                if (!answer)
                {
                    Console.WriteLine("Wrong entry. Please try again.");
                    continue;
                }
                return num;
            }
        }




        static void Application() // this method includes the Menu and switch case structure. The program will be executing according to user's input.
        {
            Input();
            Console.WriteLine();
            Menu();
            while (true)
            {
                Console.WriteLine();
                string choice = GetChoice();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                    case "S":
                        SellTicket(); break;
                    case "2":
                    case "R":
                        RefundTicket(); break;
                    case "3":
                    case "D":
                        StatusInfo(); break;
                    case "4":
                    case "X":
                        Environment.Exit(0); break;
                }
            }
        }
        static void Input()
        {

            Console.WriteLine("-------Boutique Cinema-------");
            Console.WriteLine("");
            Console.Write("Movie name: ");
            string movie = Console.ReadLine();

            Console.Write("Capacity: ");
            int capacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Full Ticket Price: ");
            float FullTicket = Convert.ToSingle(Console.ReadLine());

            Console.Write("Half Ticket Price: ");
            float halfTicket = Convert.ToSingle(Console.ReadLine());

            Cnm = new Cinema(movie, capacity, FullTicket, halfTicket);

        }
        static void Menu()
        {
            Console.WriteLine("1 - Sell Ticket(S)         ");
            Console.WriteLine("2 - Refund Ticket(R)       ");
            Console.WriteLine("3 - Status Information(D)  ");
            Console.WriteLine("4 - Exit(X)                ");
            Console.WriteLine("                           ");

        }
        static string GetChoice()
        {
            Console.Write("Your Choice: ");
            return Console.ReadLine().ToUpper();
        }
        static void StatusInfo()
        {
            Console.WriteLine("Status Information ");
            Console.WriteLine("Movie: " + Cnm.MovieName);
            Console.WriteLine("Capacity: " + Cnm.Capacity);
            Console.WriteLine("Full Ticket Price : " + Cnm.FullTicketPrice);
            Console.WriteLine("Half Ticket Price : " + Cnm.HalfTicketPrice);
            Console.WriteLine("Number of Total Full Tickets:  " + Cnm.SumFullTicket);
            Console.WriteLine("Number of Total Half Tickets: " + Cnm.SumHalfTicket);
            Console.WriteLine("Turnover: " + Cnm.Turnover);
            Console.WriteLine("Empty Seat Number: " + Cnm.GetEmptySeat());
        }


        static void SellTicket()
        {
            Console.WriteLine("Sell Ticket: ");
            Console.Write("Number of Full Tickets: ");
            int full = int.Parse(Console.ReadLine());
            Console.Write("Number of Half Tickets: ");
            int half = int.Parse(Console.ReadLine());

            Cnm.SellingTicket(full, half);
        }
        static void RefundTicket()
        {
            Console.WriteLine("Refund Ticket: ");
            Console.Write("Number of Full Tickets: ");
            int full = int.Parse(Console.ReadLine());
            Console.Write("Number of Half Tickets: ");
            int half = int.Parse(Console.ReadLine());

            Cnm.RefundTicket(full, half);

         
        }
    }
}
