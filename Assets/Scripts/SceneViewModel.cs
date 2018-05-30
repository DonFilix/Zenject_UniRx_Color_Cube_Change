using System;
using UnityEngine;
using Zenject;
using UniRx;


public class SceneViewModel : MonoBehaviour
{
    // Presenter is aware of its View (binded in the inspector)
    public GameObject MyCube;
    public Material TestMaterial;

    // State-Change-Events from Model by ReactiveProperty
    [Inject] private CubeModel _cubeModel;


    void Start()
    {
        MyCube = GameObject.FindGameObjectWithTag("MyCube");

        //// Rx supplies user events from Views and Models in a reactive manner 
        _cubeModel.BackgroundColor.Subscribe(_ =>
        {
            Debug.Log(_cubeModel.BackgroundColor.Value + " " + DateTime.Now.ToShortTimeString());
            MyCube.GetComponent<Renderer>().material = TestMaterial; 
        });
    }
}


