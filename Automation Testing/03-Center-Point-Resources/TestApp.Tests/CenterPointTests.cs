using System;
using NUnit.Framework;

namespace TestApp.Tests
{
    public class CenterPointTests
    {
        [Test]
        public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
        {
            // Arrange
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 3.0;
            double y2 = 4.0;

            // Act
            string result = CenterPoint.GetClosest(x1, y1, x2, y2);

            // Assert
            Assert.AreEqual("(1, 2)", result);
        }

        [Test]
        public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
        {
            // Arrange
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = -1.0;
            double y2 = -2.0;

            // Act
            string result = CenterPoint.GetClosest(x1, y1, x2, y2);

            // Assert
            Assert.AreEqual("(-1, -2)", result);
        }

        [Test]
        public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnSecondPoint()
        {
            // Arrange
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = -1.0;
            double y2 = -2.0;

            // Act
            string result = CenterPoint.GetClosest(x1, y1, x2, y2);

            // Assert
            Assert.AreEqual("(-1, -2)", result);
        }


        [Test]
        public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
        {
            // Arrange
            double x1 = -1.0;
            double y1 = -2.0;
            double x2 = 1.0;
            double y2 = 2.0;

            // Act
            string result = CenterPoint.GetClosest(x1, y1, x2, y2);

            // Assert
            Assert.AreEqual("(-1, -2)", result);
        }

        [Test]
        public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
        {
            // Arrange
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = -1.0;
            double y2 = -2.0;

            // Act
            string result = CenterPoint.GetClosest(x1, y1, x2, y2);

            // Assert
            Assert.AreEqual("(-1, -2)", result);
        }
    }
}
