using System;
using NUnit.Framework;
using Models;
using DAL;

namespace SimpleStatsKeeper.Tests.DatabaseIntegrationTests
{
    [Category("SkipWhenLiveUnitTesting")]
    public class StatisticsHandlerIntegrationTests
    {
        [Test]
        public void EnterCountingStatistics_PostiveValueAdded_Success()
        {
            // arrange
            int count = 100;
            DateTime date = DateTime.Now;
            StatisticEntry entry = new StatisticEntry(count,date);
            Common.Result expected = Common.Result.OK;

            // act
            StatisticsHandler sut = new StatisticsHandler();
            Common.Result actual = sut.EnterCountingStatistics(entry);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void EnterCountingStatistics_NegativeValueAdded_Fail() // doesn't hit the DB, if it runs properly
        {
            // arrange
            int count = -100;
            DateTime date = DateTime.Now;
            StatisticEntry entry = new StatisticEntry(count, date);
            Common.Result expected = Common.Result.Fail;

            // act
            StatisticsHandler sut = new StatisticsHandler();
            Common.Result actual = sut.EnterCountingStatistics(entry);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}