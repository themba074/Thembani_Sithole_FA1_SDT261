using System;
using System.Collections.Generic;

namespace EmfuleniMunicipalityApp
{
    // Resident class
    public class Resident
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int AccountNumber { get; set; }
        public double MonthlyUtilityUsage { get; set; }
    }

    // ServiceRequest class
    public class ServiceRequest
    {
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }
        public int SeverityLevel { get; set; }
        public int EstimatedResolutionHours { get; set; }
        public Resident Resident { get; set; }
    }

    // UtilitiesManager class
    public class UtilitiesManager
    {
        public double CalculateUrgency(ServiceRequest request)
        {
            return request.PriorityLevel * request.SeverityLevel * request.EstimatedResolutionHours;
        }

        public void GenerateReport(ServiceRequest request)
        {
            double urgency = CalculateUrgency(request);
            Console.WriteLine("\n=== Service Report ===");
            Console.WriteLine($"Resident: {request.Resident.Name}");
            Console.WriteLine($"Address: {request.Resident.Address}");
            Console.WriteLine($"Account Number: {request.Resident.AccountNumber}");
            Console.WriteLine($"Monthly Utility Usage: {request.Resident.MonthlyUtilityUsage:F2}");
            Console.WriteLine($"Service Request: {request.RequestType}");
            Console.WriteLine($"Priority Level: {request.PriorityLevel}");
            Console.WriteLine($"Severity Level: {request.SeverityLevel}");
            Console.WriteLine($"Estimated Resolution Hours: {request.EstimatedResolutionHours}");
            Console.WriteLine($"Urgency Score: {urgency:F2}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            // Collect residents
            Console.Write("How many residents do you want to register? ");
            int residentCount = int.Parse(Console.ReadLine());
            List<Resident> residents = new List<Resident>();

            for (int i = 0; i < residentCount; i++)
            {
                Resident r = new Resident();
                Console.Write("Name: ");
                r.Name = Console.ReadLine();
                Console.Write("Address: ");
                r.Address = Console.ReadLine();
                Console.Write("Account Number: ");
                r.AccountNumber = int.Parse(Console.ReadLine());
                Console.Write("Monthly Utility Usage (kWh or Litres): ");
                r.MonthlyUtilityUsage = double.Parse(Console.ReadLine());
                residents.Add(r);
            }

            // Collect service requests
            Console.Write("How many service requests do you want to log? ");
            int requestCount = int.Parse(Console.ReadLine());
            Queue<ServiceRequest> requests = new Queue<ServiceRequest>();
            UtilitiesManager manager = new UtilitiesManager();

            for (int i = 0; i < requestCount; i++)
            {
                ServiceRequest sr = new ServiceRequest();
                Console.Write("Service Request Type (e.g., Water Outage, Burst Pipe): ");
                sr.RequestType = Console.ReadLine();
                Console.Write("Priority Level (1 to 5): ");
                sr.PriorityLevel = int.Parse(Console.ReadLine());
                Console.Write("Severity Level (1 to 10): ");
                sr.SeverityLevel = int.Parse(Console.ReadLine());
                Console.Write("Estimated Resolution Hours: ");
                sr.EstimatedResolutionHours = int.Parse(Console.ReadLine());

                // Associate with first resident for simplicity
                sr.Resident = residents[0];
                requests.Enqueue(sr);
            }

            // Process requests
            List<ServiceRequest> resolvedRequests = new List<ServiceRequest>();
            double highestUrgency = 0;
            ServiceRequest mostUrgent = null;

            while (requests.Count > 0)
            {
                ServiceRequest current = requests.Dequeue();
                manager.GenerateReport(current);
                resolvedRequests.Add(current);

                double urgency = manager.CalculateUrgency(current);
                if (urgency > highestUrgency)
                {
                    highestUrgency = urgency;
                    mostUrgent = current;
                }
            }

            // Summary
            Console.WriteLine("\n=== Summary of Resolved Requests ===");
            foreach (var req in resolvedRequests)
            {
                Console.WriteLine($"{req.RequestType} (Urgency: {manager.CalculateUrgency(req):F2})");
            }

            Console.WriteLine($"\nMost Urgent Request: {mostUrgent.RequestType} with score {highestUrgency:F2}");
            Console.WriteLine("Thank you for using the Emfuleni Municipality Service Desk.");
        }
    }
}
