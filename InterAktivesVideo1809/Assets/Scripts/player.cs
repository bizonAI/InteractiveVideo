using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public Transform leftTarget;
    public Transform rightTarget;
    public Transform midTarget;

    bool idlePos;

    bool buttonsUp;

    [SerializeField]
    private float moveSpeed;

	void Start () {
	}
	
	void Update () {
        Debug.Log(GestureListener.leftSwipe + "left");
        Debug.Log(GestureListener.rightSwipe + "right");

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            idlePos = true;
        }
        
        if (idlePos)
        {
            transform.position = Vector3.MoveTowards(transform.position, midTarget.position, moveSpeed * Time.deltaTime);

            if (transform.position.x == 0)
            {
                //idlePos = false;
            }
        }
        
        if (GestureListener.leftSwipe && !idlePos || Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.MoveTowards(transform.position, leftTarget.position, moveSpeed * Time.deltaTime);



            idlePos = false;

            if (transform.position.x == -4)
            {
             //   GestureListener.leftSwipe = false;
            }
        }

        if (GestureListener.rightSwipe && !idlePos || Input.GetKey(KeyCode.D))
        {
            idlePos = false;
            transform.position = Vector3.MoveTowards(transform.position, rightTarget.position, moveSpeed * Time.deltaTime);
            //transform.rotation = Vector3.RotateTowards(transform.rotation, rightTarget.rotation, moveSpeed * Time.deltaTime);

            if (transform.position.x == 4)
            {
               // GestureListener.rightSwipe = false;
            }
        }
    }
}
