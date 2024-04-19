using NUnit.Framework;
using System;

[TestFixture]
public class LegacyRectangleAdapterTest
{
    [Test]
    public void Draw_WhenCalled_DrawsRectangleWithCorrectParameters()
    {
        // Arrange
        LegacyRectangle legacyRectangle = new LegacyRectangle();
        LegacyRectangleAdapter adapter = new LegacyRectangleAdapter(legacyRectangle);
        var expectedOutput = "Dibujando rectángulo en (0,0) y (100,50)";

        // Act
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            adapter.Draw();
            var result = sw.ToString().Trim();

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
