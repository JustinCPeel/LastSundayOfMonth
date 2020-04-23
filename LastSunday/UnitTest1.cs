using System;
using System.Collections.Generic;
using NUnit;
using NUnit.Framework;

namespace LastSunday
{
	[TestFixture]
	public class LastSundayOfMonth
	{
		[Test]
		public void Jan2013_shouldReturn_LastSundayOfJanuary()
		{
			//arrange
			var year = 2013;
			var month = 1;
			//act
			var expected = "2013-01-27";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Feb2013_shouldReturn_LastSundayOfFebruary()
		{
			//arrange
			var year = 2013;
			var month = 2;
			//act
			var expected = "2013-02-24";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void March2013_shouldReturn_LastSundayOfMarch()
		{
			//arrange
			var year = 2013;
			var month = 3;
			//act
			var expected = "2013-03-31";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void April2013_shouldReturn_LastSundayOfApril()
		{
			//arrange
			var year = 2013;
			var month = 4;
			//act
			var expected = "2013-04-28";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void May2013_shouldReturn_LastSundayOfMay()
		{
			//arrange
			var year = 2013;
			var month = 5;
			//act
			var expected = "2013-05-26";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void June2013_shouldReturn_LastSundayOfJune()
		{
			//arrange
			var year = 2013;
			var month = 6;
			//act
			var expected = "2013-06-30";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void July2013_shouldReturn_LastSundayOfJuly()
		{
			//arrange
			var year = 2013;
			var month = 7;
			//act
			var expected = "2013-07-28";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void August2013_shouldReturn_LastSundayOfAugust()
		{
			//arrange
			var year = 2013;
			var month = 8;
			//act
			var expected = "2013-08-25";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void September2013_shouldReturn_LastSundayOfSeptember()
		{
			//arrange
			var year = 2013;
			var month = 9;
			//act
			var expected = "2013-09-29";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}
		[Test]
		public void October2013_shouldReturn_LastSundayOfOctober()
		{
			//arrange
			var year = 2013;
			var month = 10;
			//act
			var expected = "2013-10-27";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void November2013_shouldReturn_LastSundayOfNovember()
		{
			//arrange
			var year = 2013;
			var month = 11;
			//act
			var expected = "2013-11-24";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void December2013_shouldReturn_LastSundayOfDecember()
		{
			//arrange
			var year = 2013;
			var month = 12;
			//act
			var expected = "2013-12-29";
			var actual = LastSunday_Month(year, month);
			//assert
			Assert.AreEqual(expected, actual);
		}

		private string LastSunday_Month(int year, int month)
		{
				DateTime lastSundayOfMonth = new DateTime(year, month, DateTime.DaysInMonth(year, month));
				while (lastSundayOfMonth.DayOfWeek != DayOfWeek.Sunday)
				{
					lastSundayOfMonth = lastSundayOfMonth.Date.AddDays(-1);
				}
				
			return lastSundayOfMonth.ToString("yyyy-MM-dd");
		}

	}
}
