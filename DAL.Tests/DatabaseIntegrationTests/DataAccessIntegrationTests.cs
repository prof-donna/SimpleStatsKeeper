using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using DAL;
using Models;

namespace DAL.Tests.DatabaseIntegrationTests
{
    [Category("SkipWhenLiveUnitTesting")]
    public class DataAccessIntegrationTests
    {
        [Test]
        public void AddCountToDatabase_UsingStoredProcedure()
        {
            // arrange
            StatisticEntry entry = new StatisticEntry();
            entry.Count = 3456;
            entry.DateEntered = DateTime.Now;
            Common.Result expected = Common.Result.OK;

            // act
            DataAccess db = new DataAccess();
            Common.Result actual = db.AddCountToDatabase_UsingStoredProcedure(entry);

            // assert
            Assert.AreEqual(expected, actual);

        }

    }
}
