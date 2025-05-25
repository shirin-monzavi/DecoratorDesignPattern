namespace DecoratorDesignPattern.Components;

public class TextView:VisualComponent
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Text View");
    }

    public override void Resize()
    {
        Console.WriteLine("Resizing Text View");
    }
}
