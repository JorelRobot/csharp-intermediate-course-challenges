
namespace CSharpIntermediateChallenges.PolymorphismChallenge
{
    public class DbConnectionChallenge
    {
        public static void RunApplication()
        {
            DbConnection sqlconnection = new SqlConnection();
            DbConnection oracleconnection = new OracleConnection();

            sqlconnection.StringConnection = "Server=localhost;Database=Inventoty;Uid=root;Pwd=aweakpassword;";
            sqlconnection.Open();
            sqlconnection.Close();

            oracleconnection.StringConnection = "Data Source=Inventory;User Id=root;Password=aweakpassword;Integrated Security=yes;";
            oracleconnection.Open();
            oracleconnection.Close();
        }
    }

    abstract class DbConnection
    {
        public string StringConnection { get; set; } = "";
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(5);
        public bool isOpened { get; set; } = false;

        public abstract void Open();
        public abstract void Close();
    }

    class SqlConnection : DbConnection
    {
        public override void Close()
        {
            if (!isOpened) throw new Exception("The connections is already closed");

            isOpened = false;
            System.Console.WriteLine("SQL Database closed successfully");
        }

        public override void Open()
        {
            if (string.IsNullOrWhiteSpace(StringConnection)) throw new Exception("String connection must not be empty");

            isOpened = true;
            System.Console.WriteLine("SQL Database opened successfully");
        }
    }

    class OracleConnection : DbConnection
    {
        public override void Close()
        {
            if (!isOpened) throw new Exception("The connections is already closed");

            isOpened = false;
            System.Console.WriteLine("Oracle Database closed successfully");
        }

        public override void Open()
        {
            if (string.IsNullOrWhiteSpace(StringConnection)) throw new Exception("String connection must not be empty");

            isOpened = true;
            System.Console.WriteLine("Oracle Database opened successfully");
        }
    }
}