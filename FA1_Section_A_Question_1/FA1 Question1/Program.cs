using System;

class StudentResults
{
    static void Main()
    {
        // Prompt for student name
        Console.Write("Enter student name: ");
        string studentName = Console.ReadLine();

        // Array to store marks
        int[] marks = new int[3];
        int total = 0;

        // Input and validation for 3 subjects
        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                Console.Write($"Enter mark for Subject {i + 1}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out marks[i]))
                {
                    total += marks[i];
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }
        }

        // Calculate average
        double average = total / 3.0;

        // Determine result
        string result = average >= 50 ? "PASS" : "FAIL";

        // Display results
        Console.WriteLine("\n===== STUDENT RESULTS =====");
        Console.WriteLine($"Student Name: {studentName}");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average Marks: {average:F1}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Result Issued At: {DateTime.Now}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
