﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("display connected" + Display.displays.Length);
        if (Display.displays.Length > 1)
        {
            Display.displays[1].Activate();
        }
        if (Display.displays.Length > 2)
        {
            Display.displays[2].Activate();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
