using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Flight> flights = new List<Flight>
            {
                new Flight
                {
                    FlightNumber = "ABC123",
                    DepartureCity = "New York",
                    ArrivalCity = "Los Angeles",
                    DepartureTime = DateTime.Parse("2024-01-17 08:00"),
                    ArrivalTime = DateTime.Parse("2024-01-17 11:00"),
                },

                new Flight
                {
                    FlightNumber = "XYZ789",
                    DepartureCity = "Chicago",
                    ArrivalCity = "Miami",
                    DepartureTime = DateTime.Parse("2024-01-17 12:30"),
                    ArrivalTime = DateTime.Parse("2024-01-17 15:30"),
                },
            };

            Console.WriteLine("Flight Information System");
            while (true)
            {
                Console.WriteLine("\n1. List all flights");
                Console.WriteLine("2. Search for flights");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ListAllFlights(flights);
                            break;
                        case 2:
                            SearchFlights(flights);
                            break;
                        case 3:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        static void ListAllFlights(List<Flight> flights)
        {
            Console.WriteLine("\nAll flights:");
            flights.ForEach(Console.WriteLine);
        }
        static void SearchFlights(List<Flight> flights)
        {
            Console.Write("Enter departure city: ");
            string departureCity = Console.ReadLine();

            Console.Write("Enter arrival city: ");
            string arrivalCity = Console.ReadLine();


            var matchingFlights = flights.Where(f => 
            f.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase) 
            && f.ArrivalCity.Equals(arrivalCity, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine(matchingFlights.Any() 
                ? "\nMatching Flights:\n" + string.Join("\n", matchingFlights) 
                : "No matching flights found.");
        }
    }
}
