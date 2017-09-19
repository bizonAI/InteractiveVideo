using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {

    float depth = 1.0f;
    Vector3 mousePos;
    Vector3 wantedPos;

    public Camera camera;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousePos = Input.mousePosition;

        wantedPos = Camera.current.ScreenToWorldPoint (new Vector3(mousePos.x, mousePos.y, depth));

        transform.position = wantedPos;
    }
}
