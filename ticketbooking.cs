namespace System
{
    class TicketBooking
    {
        public static void Main(String[] args)
        {
            var General_Trainseats = 700;
            var Senior_seats = 200;
            var Ladies_seat = 20;
            var EQ_seat = 30;
            var Defence_seat = 2;
            System.Console.WriteLine("Available seats in train, Choose the quota");
            System.Console.WriteLine("1.General Quota: " + General_Trainseats);
            System.Console.WriteLine("2.Senior Citizen Quota: " + Senior_seats);
            System.Console.WriteLine("3.Ladies Quota; " + Ladies_seat);
            System.Console.WriteLine("4.Defence quota " + Defence_seat);
            System.Console.WriteLine("5.Emergency quota " + EQ_seat);
            Console.Write("Select an option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            int seat;
            switch (option)
            {
                case 1:
                     System.Console.WriteLine("you choosen general quota available seats" + General_Trainseats);
                     System.Console.Write("Choose number of seats: ");
                     seat = Convert.ToInt32(Console.ReadLine());
                     while(seat > 6)
                    {
                        System.Console.Write("You can choose upto maximum 6 seats: ");
                        seat = Convert.ToInt32(Console.ReadLine());
                        General_Trainseats = General_Trainseats - seat;
                        System.Console.WriteLine("Booked successfully! " + seat + " seats, remaining seats " + General_Trainseats);
                    }
                    General_Trainseats = General_Trainseats - seat;
                    System.Console.WriteLine("Booked successfully! " + seat + " seats, remaining seats " + General_Trainseats);
                     break;
                case 2:
                     System.Console.WriteLine("you choosen Senior citizen quota available seats " + Senior_seats);
                     System.Console.WriteLine("Note! Ladies aged 45 an above and Gents above 60 are only eligble to avail the reservation");
                     System.Console.Write("Choose number of seats: ");
                     seat = Convert.ToInt32(Console.ReadLine());
                     while(seat > 2)
                    {
                        System.Console.Write("You can choose upto maximum 2 seats: ");
                        seat = Convert.ToInt32(Console.ReadLine());
                    }
                    Senior_seats = Senior_seats - seat;
                    System.Console.WriteLine("Booked successfully! " + seat + " seats, remaining seats " + Senior_seats);
                    break;
                case 3:
                     System.Console.WriteLine("you choosen Ladies Quota " + Ladies_seat);
                     System.Console.Write("Choose number of seats: ");
                     seat = Convert.ToInt32(Console.ReadLine());
                     while(seat > 2)
                    {
                        System.Console.Write("You can choose upto maximum 2 seats: ");
                        seat = Convert.ToInt32(Console.ReadLine());
                    }
                    Ladies_seat = Ladies_seat - seat;
                    System.Console.WriteLine("Booked successfully! " + seat + " seats, remaining seats " + Ladies_seat);
                    break;
                case 4:
                     System.Console.WriteLine("you choosen Defence quota available seats" + Defence_seat);
                     System.Console.Write("Choose number of seats: ");
                     seat = Convert.ToInt32(Console.ReadLine());
                     while(seat > 2)
                    {
                        System.Console.Write("You can choose upto maximum 2 seats: ");
                        seat = Convert.ToInt32(Console.ReadLine());
                    }
                    Defence_seat = Defence_seat - seat;
                    System.Console.WriteLine("Booked successfully! " + seat + " seats, remaining seats " + Defence_seat);
                     break;
                case 5:
                     System.Console.WriteLine("you choosen Emergency Quota" + EQ_seat);
                     System.Console.Write("Choose number of seats: ");
                     seat = Convert.ToInt32(Console.ReadLine());
                     while(seat > 2)
                    {
                        System.Console.Write("You can choose upto maximum 2 seats: ");
                        seat = Convert.ToInt32(Console.ReadLine());
                    }
                    EQ_seat = EQ_seat - seat;
                    System.Console.WriteLine("Booked successfully! " + seat + " seats, remaining seats " + EQ_seat);
                     break;
                default:
                      System.Console.WriteLine("invalid");
                      break;
            }
        }
    }
}
