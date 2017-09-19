using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnim : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(GestureListener.leftSwipe);

		if (Input.GetKey(KeyCode.A) || GestureListener.leftSwipe)
        {
            // anim.Play("LeftRoll");
            anim.SetBool("leftRoll", true);
            GestureListener.leftSwipe = false;
        } else
        {
            anim.SetBool("leftRoll", false);
        }

        if (Input.GetKey(KeyCode.D) || GestureListener.rightSwipe)
        {
            // anim.Play("LeftRoll");
            anim.SetBool("rightRoll", true);
            GestureListener.rightSwipe = false;
        }
        else
        {
            anim.SetBool("rightRoll", false);
        }


    }
}
