```mermaid
classDiagram

class IShape
IShape : +Draw() Void

class LegacyRectangle
LegacyRectangle : +DrawRectangle() Void

class LegacyRectangleAdapter
LegacyRectangleAdapter : +Draw() Void


IShape <|.. LegacyRectangleAdapter


PASO A PASO:

1.Creamos los siguientes archivos en el directorio Estructural.Domain:


LegacyRectangle.cs:

using System;

public class LegacyRectangle
{
    public void DrawRectangle(int x1, int y1, int x2, int y2)
    {
        Console.WriteLine($"Dibujando rectángulo en ({x1},{y1}) y ({x2},{y2})");
    }
}


IShape.cs:

public interface IShape
{
    void Draw();
}


LegacyRectangleAdapter.cs:

using System;

public class LegacyRectangleAdapter : IShape
{
    private LegacyRectangle _legacyRectangle;

    public LegacyRectangleAdapter(LegacyRectangle legacyRectangle)
    {
        _legacyRectangle = legacyRectangle;
    }

    public void Draw()
    {
        _legacyRectangle.DrawRectangle(0, 0, 100, 50);
    }
}
Luego, en tu archivo de programa principal (por ejemplo, Program.cs), puedes utilizar el adaptador como se mostró en el ejemplo anterior. Asegúrate de incluir los archivos adecuadamente en tu proyecto y de establecer el punto de entrada (Main) correctamente.

2. Creamos el test en el directorio Estructural.Domain.Test

LegacyRectangleAdapterTest.cs:

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
Este archivo de prueba contiene un solo método de prueba llamado Draw_WhenCalled_DrawsRectangleWithCorrectParameters, que prueba si el método Draw del adaptador LegacyRectangleAdapter dibuja un rectángulo con los parámetros correctos.

```


