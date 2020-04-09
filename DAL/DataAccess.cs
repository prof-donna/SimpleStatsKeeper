using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using Models;
using System.Linq; // needed for Array
using System.Collections.Generic;  // needed for List

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



        public Common.Result AddCountToDatabase_UsingStoredProcedure(StatisticEntry entry)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Common.BlogConnectionStringValue_Simple()))
                {
                    List<StatisticEntry> entries = new List<StatisticEntry>();
                    entries.Add(entry);

                    //spAttendanceData_AddCount

                    connection.Execute("dbo.spAttendanceData_AddCount @Count, @DateEntered", entries);

                    return Common.Result.OK;
                }
            }
            catch (Exception e)
            {
                return Common.Result.Error;
                //throw e;
            }
        }

    }
}
