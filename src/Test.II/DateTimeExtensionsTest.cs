﻿// Copyright 2014 by PeopleWare n.v..
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

using NUnit.Framework;

using PPWCode.Util.OddsAndEnds.II.Extensions;

namespace PPWCode.Util.OddsAndEnds.Test.II
{
    [TestFixture]
    public class DateTimeExtensionsTest
    {
        [Test, TestCaseSource(typeof(DateTimeExtensionsFactory), "StripMilliseconds")]
        public DateTime StripMillisecondsTest(DateTime dateTime)
        {
            return dateTime.StripMilliseconds();
        }

        [Test, TestCaseSource(typeof(DateTimeExtensionsFactory), "StripSeconds")]
        public DateTime StripSecondsTest(DateTime dateTime)
        {
            return dateTime.StripSeconds();
        }

        [Test, TestCaseSource(typeof(DateTimeExtensionsFactory), "StripHours")]
        public DateTime StripHours(DateTime dateTime)
        {
            return dateTime.StripHours();
        }

        [Test, TestCaseSource(typeof(DateTimeExtensionsFactory), "IsLegalSqlDate")]
        public bool IsLegalSqlDateTest(DateTime dateTime)
        {
            return dateTime.IsLegalSqlDate();
        }

        public void IsLegalSqlDateNullableDatetimeTest()
        {
            // todo add tests
        }

        public DateTime AddQuartersTest()
        {
            // todo add tests
           throw new NotImplementedException();
        }

        public DateTime? StripMillisecondsTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime? StripSeconds()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime? StripHours()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime? AddMonthsTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime? AddQuartersForNullableDatetimeTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime ImmediateFirstOfQuarterTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public bool IsFirstDayOfQuarterTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        [Test, Description("DateTimeExtensions FirstDayOfCurrentQuarter")]
        public void TestFirstDayOfCurrentQuarter()
        {
            Assert.AreEqual(new DateTime(2000, 1, 1), new DateTime(2000, 3, 28).FirstDayOfQuarter());
            Assert.AreEqual(new DateTime(2000, 10, 1), new DateTime(2000, 12, 31).FirstDayOfQuarter());
            Assert.AreEqual(new DateTime(2000, 7, 1), new DateTime(2000, 7, 1).FirstDayOfQuarter());
        }

        [Test, Description("DateTimeExtensions FirstDayOfNextQuarter")]
        public void TestFirstDayOfNextQuarter()
        {
            Assert.AreEqual(new DateTime(2000, 4, 1), new DateTime(2000, 3, 28).FirstDayOfNextQuarter());
            Assert.AreEqual(new DateTime(2001, 1, 1), new DateTime(2000, 12, 31).FirstDayOfNextQuarter());
            Assert.AreEqual(new DateTime(2000, 10, 1), new DateTime(2000, 7, 1).FirstDayOfNextQuarter());
            Assert.AreEqual(new DateTime(2011, 1, 1), new DateTime(2010, 10, 1).FirstDayOfNextQuarter());
        }

        [Test, Description("DateTimeExtensions LastDayOfCurrentQuarter")]
        public void TestLastDayOfCurrentQuarter()
        {
            Assert.AreEqual(new DateTime(2000, 3, 31), new DateTime(2000, 3, 28).LastDayOfCurrentQuarter());
            Assert.AreEqual(new DateTime(2000, 12, 31), new DateTime(2000, 12, 31).LastDayOfCurrentQuarter());
            Assert.AreEqual(new DateTime(2000, 9, 30), new DateTime(2000, 7, 1).LastDayOfCurrentQuarter());
        }

        [Test, Description("DateTimeExtensions LastDayOfNextQuarter")]
        public void TestLastDayOfNextQuarter()
        {
            Assert.AreEqual(new DateTime(2000, 6, 30), new DateTime(2000, 3, 28).LastDayOfNextQuarter());
            Assert.AreEqual(new DateTime(2001, 3, 31), new DateTime(2000, 12, 31).LastDayOfNextQuarter());
            Assert.AreEqual(new DateTime(2000, 12, 31), new DateTime(2000, 7, 1).LastDayOfNextQuarter());
        }

        [Test, Description("DateTimeExtensions FirstDayOfQuarter(string)")]
        public void TestFirstDayOfQuarterString()
        {
            Assert.AreEqual(new DateTime(2000, 1, 1), "20001".FirstDayOfQuarter());
            Assert.AreEqual(new DateTime(2001, 4, 1), "20012".FirstDayOfQuarter());
            Assert.AreEqual(new DateTime(2000, 10, 1), "20004".FirstDayOfQuarter());
        }

        [Test, Description("DateTimeExtensions FirstDayOfQuarter(int)")]
        public void TestFirstDayOfQuarterInt()
        {
            Assert.AreEqual(new DateTime(2000, 1, 1), 20001.FirstDayOfQuarter());
            Assert.AreEqual(new DateTime(2001, 4, 1), 20012.FirstDayOfQuarter());
            Assert.AreEqual(new DateTime(2000, 10, 1), 20004.FirstDayOfQuarter());
        }

        [Test, Description("DateTimeExtensions FirstDayOfPreviousQuarter")]
        public void TestFirstDayOfPreviousQuarter()
        {
            Assert.AreEqual(new DateTime(2013, 10, 1), new DateTime(2014, 2, 28).FirstDayOfPreviousQuarter());
        }

        public DateTime LastDayOfCurrentQuarterTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime LastDayOfNextQuarterTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public bool IsFirstDayOfMonthTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public bool? IsFirstDayOfMonthForNullableDatetimeTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime ImmediateFirstOfMonthTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime FirstDayOfNextMonthTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public int DaysBetweenTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public int MonthBetweenTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public int QuartersBetweenTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime ImmediateFirstOfYearTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime FirstDayOfNextYearTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime FirstDayOfMonthTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public DateTime LastDayOfMonthTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public int NumberOfDaysInYearTest()
        {
            // todo add tests
            throw new NotImplementedException();
        }

        public int AgeInYearsTest()
        {
                        // todo add tests
            throw new NotImplementedException();
        }
    }
}