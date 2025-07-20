using Coding_Session_Tracker.Controller;
using Coding_Session_Tracker.Models;
using Coding_Session_Tracker.Services;
using Itenso.TimePeriod;
using SQLitePCL;
using DurationCalculator = Coding_Session_Tracker.Services.DurationCalculator;

class Program
{
    static void Main(string[] args) 
    {
        Batteries.Init();// 👈 Required for Microsoft.Data.Sqlite

        var controller = new CodingController();
        controller.CreateTable();

        bool running = true;

        while (running) 
        {
            Console.WriteLine("\n=== Coding Tracker ===");
            Console.WriteLine("1. - View all Coding Sessions");
            Console.WriteLine("2. - Add a new Coding Session");
            Console.WriteLine("3. - Delete a Coding Session");
            Console.WriteLine("0. - Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    var sessions = controller.GetAllSessions();
                    TableVisualiser.DisplaySessions(sessions);
                    break;

                case "2":
                    var start = UserInput.GetDateTime("Enter start time");
                    var end = UserInput.GetDateTime("Enter end time");

                    if (!Validation.IsEndAfterStart(start, end))
                    {
                        Console.WriteLine("End time must be after start time!");
                        break;
                    }
                    var duration = DurationCalculator.Calculate(start, end);
                    var session = new CodingSession { StartTime = start, EndTime = end, Duration = duration };
                    controller.InsertSession(session);
                    Console.WriteLine("Session added.");
                    break;

                case "3":
                    Console.Write("Enter session Id to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        controller.DeleteSession(id);
                    }
                    break;

                case "0":
                    running = false;
                    Console.WriteLine("Exiting the application...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again 1,2,3,0.");
                    break;
                }
            }
        }
    }
