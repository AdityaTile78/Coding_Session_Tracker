using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

public static class Database
{
    private static readonly string _connectionString;

    static Database()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json");

        var config = builder.Build();
        _connectionString = config.GetConnectionString("Default");
    }

    public static SqliteConnection GetConnection()
    {
        return new SqliteConnection(_connectionString);
    }
}
