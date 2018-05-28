using UnityEngine;
using System.Collections;

public class DemoGUI_ColorPickerDemo : MonoBehaviour {

	float cameraDistance = 0.7f;

	
	void Start () {
		cameraDistance = GetComponent<Camera>().orthographicSize;
	}
	
	
	void OnGUI () {
		GUIStyle style = new GUIStyle(GUI.skin.label);
		style.fontSize = 12;
	}
}
