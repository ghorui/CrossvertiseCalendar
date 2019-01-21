using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrossvertiseCalendar;
using CrossvertiseCalendar.Controllers;
using CrossvertiseCalendar.Service;

namespace CrossvertiseCalendar.Tests.Controllers
{
    [TestClass]
    public class CalendarControllerTest
    {
        [TestMethod]
        public void CheckViewResult()
        {
            // Arrange
            CalendarController controller = new CalendarController();

            // Act
            ViewResult result = controller.Index("1") as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CheckDataForJan()
        {
            //Arrange
            CalendarService calendarService = new CalendarService();

            // Act
            var result = calendarService.GetCalendarEntriesByMonth(1);

            // Assert
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void CheckDataForFeb()
        {
            //Arrange
            CalendarService calendarService = new CalendarService();

            // Act
            var result = calendarService.GetCalendarEntriesByMonth(2);

            // Assert
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod]
        public void CheckDataForDec()
        {
            //Arrange
            CalendarService calendarService = new CalendarService();

            // Act
            var result = calendarService.GetCalendarEntriesByMonth(12);

            // Assert
            Assert.IsTrue(result.Count == 0);
        }

        [TestMethod]
        public void CheckDataForFirstAppointment()
        {
            //Arrange
            CalendarService calendarService = new CalendarService();

            // Act
            var result = calendarService.GetCalendarEntriesForMonthById("1");

            // Assert
            Assert.IsTrue(result.Count == 3);
        }

        [TestMethod]
        public void CheckDataForSeventhAppointment()
        {
            //Arrange
            CalendarService calendarService = new CalendarService();

            // Act
            var result = calendarService.GetCalendarEntriesForMonthById("7");

            // Assert
            Assert.IsTrue(result.Count == 1);
        }

    }
}
