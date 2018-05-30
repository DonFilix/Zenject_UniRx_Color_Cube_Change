using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material_test : MonoBehaviour
{

    public Material matRed;

    public void onclick()
    {
        gameObject.GetComponent<Renderer>().material = matRed;
    }
}
