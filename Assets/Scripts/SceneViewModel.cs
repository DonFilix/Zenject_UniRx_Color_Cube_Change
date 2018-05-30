using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;
using UniRx;


public class SceneViewModel : MonoBehaviour
{
    // Presenter is aware of its View (binded in the inspector)
    public GameObject MyCube;
    public Material TestMaterial;

    // State-Change-Events from Model by ReactiveProperty
    [Inject]
    private CubeModel _cubeModel;
    [Inject]
    public List<Material> Materials;


    void Start()
    {
        MyCube = GameObject.FindGameObjectWithTag("MyCube");

        //// Rx supplies user events from Views and Models in a reactive manner 
        _cubeModel.BackgroundColor.Subscribe(_ =>
        {
            var material = Materials.FirstOrDefault(x => x.color == _cubeModel.BackgroundColor.Value);
            MyCube.GetComponent<Renderer>().material = material;
        });
    }
}


