using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UniRx;

public class SidebarViewModel : MonoBehaviour
{

    [Inject] private CubeModel _cubeModel;

    public void onSelectColor()
    {
        string color = "green"; //TODO Get color/material from button that is clicked
        _cubeModel.ChangeColor(color);
    }

    // Use this for initialization
    void Start () {
	   
    }

    // Update is called once per frame
    void Update () {
		
	}
}
