using UniRx;
using UnityEngine;


public class CubeModel
{
    // The Model. All property notify when their values change

    public ReactiveProperty<Color> BackgroundColor { get; private set; }
    public CubeModel(Color initialColor)
    {
        // Declarative Property
        BackgroundColor = new ReactiveProperty<Color>(initialColor);
    }

    public void ChangeColor(Color color)
    {
        BackgroundColor.SetValueAndForceNotify(color);
    }
}
