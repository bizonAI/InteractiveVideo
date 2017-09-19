using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParent : MonoBehaviour {

    public GameObject bird;
    public float moveSpeed = 5;

    [SerializeField]
    private float counter;


	void Update () {
        counter += Time.deltaTime;

        float speed = moveSpeed * Time.deltaTime;

		if (counter >= 10)
        {
            bird.transform.parent = gameObject.transform;

            bird.transform.position = Vector3.MoveTowards(bird.transform.position, transform.position, speed);
        }

        
	}
}
