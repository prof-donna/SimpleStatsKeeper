using System;
using NUnit.Framework;
using Models;
using DAL;
using Moq;

namespace SimpleStatsKeeper.Tests.UnitTests
{
    public class StatisticsHandlerUnitTests
    {

        [Test]
        public void EnterCountingStatistics_PostiveValueAdded_Success()
        {
            // arrange
            int count = 100;
            DateTime date = DateTime.Now;
            StatisticEntry entry = new StatisticEntry(count,date);
            Common.Result expected = Common.Result.OK;

            var mockDB = new Mock<IDataAccess>();
            mockDB.Setup(dal => dal.AddCountToDatabase(It.IsAny<StatisticEntry>())).Returns(expected);

            // act
            StatisticsHandler sut = new StatisticsHandler(mockDB.Object);
            Common.Result actual = sut.EnterCountingStatistics(entry);

            // assert
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void EnterCountingStatistics_NegativeValueAdded_Fail()
        {
            // arrange
            int count = -100;
            DateTime date = DateTime.Now;
            StatisticEntry entry = new StatisticEntry(count, date);
            Common.Result expected = Common.Result.Fail;

            var mockDB = new Mock<IDataAccess>();
            mockDB.Setup(dal => dal.AddCountToDatabase(It.IsAny<StatisticEntry>())).Returns(expected);

            // act
            StatisticsHandler sut = new StatisticsHandler(mockDB.Object);
            Common.Result actual = sut.EnterCountingStatistics(entry);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}