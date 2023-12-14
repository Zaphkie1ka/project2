using MySql.Data.MySqlClient;

namespace project2;

public class DBHelper
{
    public MySqlConnectionStringBuilder _connectionString { get; }

    public DBHelper()
    {
        _connectionString = new MySqlConnectionStringBuilder
            {
                /*Server = "localhost",
                Database = "up",
                UserID = "zaphkie1",
                Password = "123456"*/
                
                Server = "10.10.1.24",
                Database = "pro18",
                UserID = "user_01",
                Password = "user01pro"
            };
    }
    
}