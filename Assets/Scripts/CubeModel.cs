using UniRx;


public class CubeModel
{
    // The Model. All property notify when their values change

    public ReactiveProperty<string> BackgroundColor { get; private set; }
    public CubeModel(string initialColor)
    {
        // Declarative Property
        BackgroundColor = new ReactiveProperty<string>(initialColor);
    }

    public void ChangeColor(string color)
    {
        BackgroundColor.SetValueAndForceNotify(color);
    }
}
