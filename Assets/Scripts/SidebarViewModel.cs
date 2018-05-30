using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;
using UniRx;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SidebarViewModel : MonoBehaviour
{
    [Inject] private CubeModel _cubeModel;
    [Inject]
    public List<Material> Materials;

    public void onSelectColor()
    {
        var material = EventSystem.current.currentSelectedGameObject.GetComponent<Renderer>().material;
        _cubeModel.ChangeColor(material.color);
    }

    // Use this for initialization
    void Start ()
    {
        var canvas = GameObject.FindGameObjectWithTag("ColorPicker");
        var buttons = canvas.GetComponentsInChildren<Button>();

        for (int i = 0; i < buttons.Length && i < Materials.Count; i++)
        {
            var b = buttons[i];
            b.GetComponent<Renderer>().material = Materials[i];
        }

        // za sekoe kopce add materiall at index
    }

    // Update is called once per frame
    void Update () {
		
	}
}
