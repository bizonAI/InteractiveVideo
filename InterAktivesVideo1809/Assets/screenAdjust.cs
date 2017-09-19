using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenAdjust : MonoBehaviour {

	public int width = 3075;
	public int height = 900;

	void Start () {
		Screen.SetResolution(width, height, false);
	}
	
	
}
