using Coding_Session_Tracker.Models;
using Spectre.Console;
using System.Collections.Generic;


namespace Coding_Session_Tracker.Services
{
    public static class TableVisualiser
    {
        public static void DisplaySessions(List<CodingSession> sessions)
        {
            var table = new Table();

            table.Border = TableBorder.Rounded;
            table.AddColumn("[yellow]Id[/]");
            table.AddColumn("[green]Start Time[/]");
            table.AddColumn("[green]End Time[/]");
            table.AddColumn("[cyan]Duration[/]");

            foreach (var session in sessions)
            {
                table.AddRow(
                    session.Id.ToString(),
                    session.StartTime,
                    session.EndTime,
                    session.Duration
                );
            }

            AnsiConsole.Write(table);
        }
    }
}
