using System;

namespace PointDistance
{
	public class PointDistanceCalculator
	{
		/// <summary>
		/// Returns the distance between the two points in a 2 dimensional plane, rounded to 3 decimal places.
		/// </summary>
		public double GetDistance(Point a, Point b)
		{
			var deltaX = b.X - a.X;
			var deltaXSquared = Math.Pow(deltaX, 2);
			var deltaY = b.Y - a.Y;
			var deltaYSquared = Math.Pow(deltaY, 2);
			var deltaSum = deltaXSquared + deltaYSquared;
			var distance = Math.Sqrt(deltaSum);
			return Math.Round(distance, 3);
		}
	}
}
