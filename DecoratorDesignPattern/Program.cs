using DecoratorDesignPattern;
using DecoratorDesignPattern.Components;
using DecoratorDesignPattern.Decorators;

Windows window = new();
TextView writer = new();

window.SetContent(writer);
window.Draw();

Console.WriteLine("------");

window.SetContent(new BorderDecorator(new ScrollDecorator(writer), 1));
window.Draw();

