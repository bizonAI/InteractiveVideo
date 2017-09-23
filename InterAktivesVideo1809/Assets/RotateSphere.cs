using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour {

    public float speed = 10; 

	void Update () {
        transform.Rotate(Vector3.right * Time.deltaTime * speed);
	}
}
