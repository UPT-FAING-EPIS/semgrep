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
