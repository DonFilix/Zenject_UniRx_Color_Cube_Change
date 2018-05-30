using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;
using UnityEngine.Experimental.UIElements;


public class SceneViewModel : MonoBehaviour
{
    // Presenter is aware of its View (binded in the inspector)
    public GameObject MyCube;
    public Material TestMaterial;
    public SceneViewModel()
    {
    }

    //public Toggle MyToggle;

    // State-Change-Events from Model by ReactiveProperty
    CubeModel cubeModel = new CubeModel("red");

    void Start()
    {
        MyCube = GameObject.FindGameObjectWithTag("MyCube");

        //// Rx supplies user events from Views and Models in a reactive manner 
        //MyButton.OnClickAsObservable().Subscribe(_ => cube.Color = );
        //MyToggle.OnValueChangedAsObservable().SubscribeToInteractable(MyButton);

        //// Models notify Presenters via Rx, and Presenters update their views
        //enemy.CurrentHp.SubscribeToText(MyText);
        //enemy.IsDead.Where(isDead => isDead == true)
        //    .Subscribe(_ =>
        //    {
        //        MyToggle.interactable = MyButton.interactable = false;
        //    });
        cubeModel.BackgroundColor.Subscribe(_ => { MyCube.GetComponent<Renderer>().material = TestMaterial; });
    }
}

// The Model. All property notify when their values change
public class CubeModel
{
    public ReactiveProperty<string> BackgroundColor { get; private set; }
    public CubeModel(string initialColor)
    {
        // Declarative Property
        BackgroundColor = new ReactiveProperty<string>(initialColor);
    }
}
