using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using Models;
using System.Linq;

namespace DAL
{
    public class DataAccess : IDataAccess
    {
        public DataAccess()
        {
        }

        public Common.Result AddCountToDatabase(StatisticEntry entry)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Common.BlogConnectionStringValue_Simple()))
                {
                    string query = @"INSERT INTO AttendanceData(Count, Date) VALUES('" + entry.Count + "', '" + entry.DateEntered + "');";

                    connection.Query<StatisticEntry>(query).ToArray();

                    return Common.Result.OK;
                }
            }
            catch
            {
                return Common.Result.Error;
            }
        }
    }
}
