using DecoratorDesignPattern.Components;

namespace DecoratorDesignPattern.Decorators;

public class ScrollDecorator : Decorator
{
    public ScrollDecorator(VisualComponent component) : base(component)
    {
    }

    public override void Draw()
    {
        base.Draw();
        DrawScroll();
    }

    private void DrawScroll()
    {
        Console.WriteLine("Drawing scroll bars");
    }
}
