using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

	public EditorPathScript pathToFollow;
	public int currentWaypointID = 0;
	public float speed;
	private float reachDistance = 1.0f;

	public string pathName;

	Vector3 lastPos;
	Vector3 currentPos;

	public Transform target;

	// Use this for initialization
	void Start () {
		//pathToFollow = GameObject.Find (pathName).GetComponent<EditorPathScript> ();
		//lastPos = transform.position;
	}

	// Update is called once per frame
	void Update () {




		transform.LookAt (target);
		//transform.Rotate (Vector3.left * Time.deltaTime * 10);

//		float distance = Vector3.Distance (pathToFollow.path_objs [currentWaypointID].position, transform.position);
//		transform.position = Vector3.MoveTowards (transform.position, pathToFollow.path_objs [currentWaypointID].position, Time.deltaTime * speed);
//
//		if (distance <= reachDistance) {
//			currentWaypointID++;
//		}
//
//		if (currentWaypointID >= pathToFollow.path_objs.Count) {
//
//		}
	}
}
