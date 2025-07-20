using Coding_Session_Tracker.Models;
using Dapper;
using SQLitePCL;

namespace Coding_Session_Tracker.Controller
{
    public class CodingController
    {
        public void CreateTable() 
        { 
            using var connection = Database.GetConnection();
            connection.Open();
            
            string tableCmd = @"CREATE TABLE IF NOT EXISTS CodingSessions(
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                StartTime TEXT,
                                EndTime TEXT,
                                Duration TEXT);";

            connection.Execute(tableCmd);
        }

        public void InsertSession(CodingSession session) 
        { 
            using var connection = Database.GetConnection();
            connection.Open();

            string insertCmd = @"INSERT INTO CodingSessions (StartTime, EndTime, Duration) 
                                 VALUES (@StartTime, @EndTime, @Duration);";  //Parameterized Query

            connection.Execute(insertCmd, session);
        }
        public List<CodingSession> GetAllSessions()
        {
            using var connection = Database.GetConnection();
            connection.Open();
            string selectCmd = "SELECT * FROM CodingSessions;";
            return connection.Query<CodingSession>(selectCmd).ToList();
        }
        public void DeleteSession(int id)
        {
            using var connection = Database.GetConnection();
            connection.Open();
            string deleteCmd = "DELETE FROM CodingSessions WHERE Id = @Id;";
            int rowsAffected = connection.Execute(deleteCmd, new { Id = id });

            if (rowsAffected > 0)
            {
                Console.WriteLine("Session deleted.");
            }
            else
            {
                Console.WriteLine($"No session found with Id {id}.");
            }
        }
    }
}
