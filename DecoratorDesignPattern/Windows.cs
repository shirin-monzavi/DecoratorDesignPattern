using DecoratorDesignPattern.Components;

namespace DecoratorDesignPattern;

public class Windows
{
    #region Field
    private VisualComponent _content;
    #endregion

    public void SetContent(VisualComponent content)
    {
        _content = content;
    }

    public void Draw()
    {
        _content.Draw();
    }
}
