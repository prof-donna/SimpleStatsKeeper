using System;
using Models;

namespace DAL
{
    public interface IDataAccess
    {
        public Common.Result AddCountToDatabase(StatisticEntry entry);
    }
}
