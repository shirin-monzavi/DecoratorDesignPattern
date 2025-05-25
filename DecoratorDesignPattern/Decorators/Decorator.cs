using DecoratorDesignPattern.Components;

namespace DecoratorDesignPattern.Decorators;

public class Decorator : VisualComponent
{
    #region Field
    private readonly VisualComponent _component;
    #endregion

    public Decorator(VisualComponent component)
    {
        _component = component;
    }

    public override void Draw()
    {
        _component.Draw();
    }

    public override void Resize()
    {
        _component.Resize();
    }
}
