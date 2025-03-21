
using System;   
using Spectre.Console;

namespace WorkerTable
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var table = new Table();

            //add column
            table.AddColumn("ID");
            table.AddColumn(new TableColumn("Name").Centered());
            table.AddColumn(new TableColumn("Job").Centered());

            //add row to the table
            table.AddRow("1", "Fábio Nobre", "Human Implemention Planner");
            table.AddRow("2", "Clara Coelho", "Chief Tactics Coordinator");
            table.AddRow("3", "Juliana Ramos", "International Program Executive");

            //print the table
            AnsiConsole.Write(table);

        }
    }

}
