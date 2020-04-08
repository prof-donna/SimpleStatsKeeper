using System;
using Models;
using DAL;

namespace SimpleStatsKeeper
{
    public class StatisticsHandler
    {
        private IDataAccess _db;

        public StatisticsHandler()
        {
            _db = new DataAccess();
        }

        public StatisticsHandler(IDataAccess db)
        {
            _db = db;
        }


        public Common.Result EnterCountingStatistics(StatisticEntry entry)
        {
            Common.Result result = Common.Result.Error;

            if (entry.Count < 0)
            {
                result = Common.Result.Fail;
            }
            else
            {
                result = _db.AddCountToDatabase(entry); 
            }

            return result;
        }
    }
}
