using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelControllerHole : MonoBehaviour {

    public Animator dragonAnim;
    public ParticleSystem ParticleOne;
    public ParticleSystem ParticleTwo;
    public GameObject ParticleThree;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            //dragonAnim.Play("rise");
            ParticleOne.startLifetime = 5.0f;
        }


        if (Input.GetKeyDown(KeyCode.A))
        {
            dragonAnim.Play("rise");

            ParticleOne.enableEmission = true;

            ParticleTwo.enableEmission = true;
            ParticleThree.SetActive(true);
        }

	}

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "animationCollider") {
            Debug.Log("");
            dragonAnim.Play("rise");
        }
        if (coll.gameObject.name == "particleCollider") {
            ParticleOne.enableEmission = true;
            
            ParticleTwo.enableEmission = true;
            ParticleThree.SetActive(true);
        }
    }
}
