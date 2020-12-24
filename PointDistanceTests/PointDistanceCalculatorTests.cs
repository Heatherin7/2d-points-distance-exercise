using NUnit.Framework;
using PointDistance;

namespace PointDistanceTests
{
	public class PointDistanceCalculatorTests
	{

		private PointDistanceCalculator _calculator;

		[SetUp]
		public void Setup() => _calculator = new PointDistanceCalculator();

		//These are the same point, distance should be zero
		[TestCase(0, 0, 0, 0, 0)]
		[TestCase(1, 1, 1, 1, 0)]
		[TestCase(-1, -1, -1, -1, 0)]
		
		//Point a is 1 unit away from the origin
		[TestCase(0, -0, 0, 1, 1)]
		[TestCase(0, 0, 1, 0, 1)]
		[TestCase(0, -0, 0, -1, 1)]
		[TestCase(0, 0, -1, 0, 1)]

		//Point b is 1 unit away from the origin
		[TestCase(0, 1, 0, 0, 1)]
		[TestCase(1, 0, 0, 0, 1)]
		[TestCase(0, -1, 0, 0, 1)]
		[TestCase(-1, 0, 0, 0, 1)]
		
		//Points are in different quadrants
		[TestCase(1, 1, -1, 1, 2)]
		[TestCase(1, 1, 1, -1, 2)]
		[TestCase(1, 1, -1, -1, 2.828)]
		[TestCase(-1, 1, 1, 1, 2)]
		[TestCase(1, -1, 1, 1, 2)]
		[TestCase(-1, -1, 1, 1, 2.828)]

		//Test cases with random values
		[TestCase(27, 109, 0, 44, 70.385)]
		[TestCase(99, 13, -7, -20, 111.018)]
		[TestCase(-12, 50, 24, -113, 166.928)]
		[TestCase(13, 14, 81, 38, 72.111)]
		[TestCase(49, 88, -9, 999, 912.844)]
		public void Returns_Distance_Between_Points(int x1, int y1, int x2, int y2, double distance)
		{
			var pointA = new Point
			{
				X = x1,
				Y = y1
			};

			var pointB = new Point
			{
				X = x2,
				Y = y2
			};

			var calculatedDistance = _calculator.GetDistance(pointA, pointB);
			
			Assert.AreEqual(distance, calculatedDistance);
		}
	}
}