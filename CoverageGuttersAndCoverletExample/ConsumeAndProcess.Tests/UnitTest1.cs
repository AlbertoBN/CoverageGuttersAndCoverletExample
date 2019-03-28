using System;
using System.Collections.Generic;
using ConsumeAndProcess;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ValidateData_PunchOutEarlierThanPunchIn_InvalidCard()
        {
            List<EmployeeTimeCard> cards = new List<EmployeeTimeCard>();

            cards.Add(new EmployeeTimeCard()
            {
                PunchIn = new DateTime(2019, 01, 01, 18, 0, 0),
                PunchOut = new DateTime(2019, 01, 01, 8, 0, 0),
                HoursLimit = 9,
                IsOvertimeAllowed = false
            });

            ValidateData v = new ValidateData();

            var result = v.Validate(cards);

            Assert.IsTrue(result.Count == 1);
        }
    }
}