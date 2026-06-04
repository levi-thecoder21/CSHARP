namespace RailwayBooking
{
    class TicketBooking
    {
        public static void Main(string[] args)
        {
            int General_Trainseats = 700;
            int Senior_seats = 200;
            int Ladies_seat = 20;
            int Defence_seat = 2;
            int EQ_seat = 30;

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n===== Railway Reservation System =====");
                Console.WriteLine("1. General Quota: " + General_Trainseats);
                Console.WriteLine("2. Senior Citizen Quota: " + Senior_seats);
                Console.WriteLine("3. Ladies Quota: " + Ladies_seat);
                Console.WriteLine("4. Defence Quota: " + Defence_seat);
                Console.WriteLine("5. Emergency Quota: " + EQ_seat);
                Console.WriteLine("6. Exit");

                Console.Write("Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                int seat;

                switch (option)
                {
                    case 1:
                        Console.WriteLine("You chose General Quota");
                        Console.Write("Choose number of seats (1-6): ");
                        seat = Convert.ToInt32(Console.ReadLine());

                        while (seat < 1 || seat > 6)
                        {
                            Console.Write("Enter a valid number (1-6): ");
                            seat = Convert.ToInt32(Console.ReadLine());
                        }

                        if (seat <= General_Trainseats)
                        {
                            General_Trainseats -= seat;
                            Console.WriteLine($"Booked successfully! {seat} seats. Remaining: {General_Trainseats}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough seats available.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("You chose Senior Citizen Quota");
                        Console.WriteLine("Ladies 45+ and Gents 60+ only.");
                        Console.Write("Choose number of seats (1-2): ");
                        seat = Convert.ToInt32(Console.ReadLine());

                        while (seat < 1 || seat > 2)
                        {
                            Console.Write("Enter a valid number (1-2): ");
                            seat = Convert.ToInt32(Console.ReadLine());
                        }

                        if (seat <= Senior_seats)
                        {
                            Senior_seats -= seat;
                            Console.WriteLine($"Booked successfully! {seat} seats. Remaining: {Senior_seats}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough seats available.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("You chose Ladies Quota");
                        Console.Write("Choose number of seats (1-2): ");
                        seat = Convert.ToInt32(Console.ReadLine());

                        while (seat < 1 || seat > 2)
                        {
                            Console.Write("Enter a valid number (1-2): ");
                            seat = Convert.ToInt32(Console.ReadLine());
                        }

                        if (seat <= Ladies_seat)
                        {
                            Ladies_seat -= seat;
                            Console.WriteLine($"Booked successfully! {seat} seats. Remaining: {Ladies_seat}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough seats available.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("You chose Defence Quota");
                        Console.Write("Choose number of seats (1-2): ");
                        seat = Convert.ToInt32(Console.ReadLine());

                        while (seat < 1 || seat > 2)
                        {
                            Console.Write("Enter a valid number (1-2): ");
                            seat = Convert.ToInt32(Console.ReadLine());
                        }

                        if (seat <= Defence_seat)
                        {
                            Defence_seat -= seat;
                            Console.WriteLine($"Booked successfully! {seat} seats. Remaining: {Defence_seat}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough seats available.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("You chose Emergency Quota");
                        Console.Write("Choose number of seats (1-2): ");
                        seat = Convert.ToInt32(Console.ReadLine());

                        while (seat < 1 || seat > 2)
                        {
                            Console.Write("Enter a valid number (1-2): ");
                            seat = Convert.ToInt32(Console.ReadLine());
                        }

                        if (seat <= EQ_seat)
                        {
                            EQ_seat -= seat;
                            Console.WriteLine($"Booked successfully! {seat} seats. Remaining: {EQ_seat}");
                        }
                        else
                        {
                            Console.WriteLine("Not enough seats available.");
                        }
                        break;

                    case 6:
                        isRunning = false;
                        Console.WriteLine("Thank you for using Railway Reservation System.");
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}