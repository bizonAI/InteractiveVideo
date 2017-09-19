using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallParticle : MonoBehaviour {
	public GameObject particles;
	public GameObject particlesClones;

	public GameObject thisObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		particlesClones = GameObject.Find ("FeatherL(Clone)");

		//thisObject.transform.parent = particlesClones.transform;

		if (Input.GetMouseButtonDown (0)) {
			Instantiate (particles, transform.position, transform.rotation);

		}
		Destroy (particlesClones, 2);
	}
}
