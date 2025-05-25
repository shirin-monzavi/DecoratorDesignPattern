using DecoratorDesignPattern.Components;

namespace DecoratorDesignPattern.Decorators;

public class BorderDecorator : Decorator
{
    #region Field
    private readonly int _width;
    #endregion

    public BorderDecorator(VisualComponent component, int width) : base(component)
    {
        _width = width;
    }

    public override void Draw()
    {
        base.Draw();
        DrawBorder(_width);
    }

    private void DrawBorder(int width)
    {
        Console.WriteLine($"Drawing border with width {width}");
    }
}
