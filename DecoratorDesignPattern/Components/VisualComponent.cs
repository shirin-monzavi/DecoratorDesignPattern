namespace DecoratorDesignPattern.Components;

public class VisualComponent
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing...");
    }

    public virtual void Resize()
    {
        Console.WriteLine("Resizing...");
    }
}
