using System.Globalization;
using IntroInterfaces.Entities;
using IntroInterfaces.Services;

namespace IntroInterfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/mm/yy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/mm/yy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceDay = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(priceHour, priceDay);

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine();
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}