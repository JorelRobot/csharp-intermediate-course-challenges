using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpIntermediateChallenges.PolymorphismChallenge
{
    public class DbCommandChallenge : ChallengeApplication
    {
        public void RunApplication()
        {
            DbConnection sqlconnection = new SqlConnection();
            DbConnection oraclconnection = new OracleConnection();

            sqlconnection.StringConnection = "sql-string-connection";
            oraclconnection.StringConnection = "oracle-string-connection";

            DbCommand sqlcommand = new DbCommand(sqlconnection, "sql-command");
            DbCommand oraclecommand = new DbCommand(oraclconnection, "oracle-command");

            sqlcommand.Execute();
            oraclecommand.Execute();
        }
    }

    class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _instruction = instruction;
            _dbConnection = dbConnection;
        }

        public void Execute()
        {
            if (_dbConnection == null) throw new InvalidOperationException("DbConnection doesn't have to be null");
            if (string.IsNullOrWhiteSpace(_instruction)) throw new InvalidOperationException("Instructions string doesn't have to be null or whitespaces");

            _dbConnection.Open();
            System.Console.WriteLine("Command executed succesfully");
            _dbConnection.Close();
        }
    }
}