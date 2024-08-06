namespace GymApp;

public static class Constants
{
    public const string DataBaseFileName = "GymAppDBSQLite.db3";
    public const SQLite.SQLiteOpenFlags flags = 
        // open the database in read/write mode
        SQLite.SQLiteOpenFlags.ReadWrite |
        // create the database if it doesn't exist
        SQLite.SQLiteOpenFlags.Create | 
        // enable multi-threaded database access
        SQLite.SQLiteOpenFlags.SharedCache;
    
    public static string DataBasePath => Path.Combine(FileSystem.AppDataDirectory, DataBaseFileName);
}
