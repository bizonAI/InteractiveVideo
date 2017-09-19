using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnPath : MonoBehaviour {

	public PathEditor PathToFollow;

	public int CurrentWayPointID = 0;
	public float speed;
	private float reachDistance = 0.0f;
	public float rotationSpeed = 5.0f;
	public string pathName; 

	public Transform target;


	Vector3 lastPos; 
	Vector3 currentPos;


	// Use this for initialization
	void Start () {
//		PathToFollow = GameObject.Find (pathName).GetComponent<PathEditor> ();
		lastPos = transform.position; 
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (PathToFollow.path_objs [CurrentWayPointID].position, transform.position);
		transform.position = Vector3.MoveTowards (transform.position, PathToFollow.path_objs [CurrentWayPointID].position, Time.deltaTime * speed);

//		var rot = Quaternion.LookRotation (PathToFollow.path_objs [CurrentWayPointID].position - transform.position);
//		transform.rotation = Quaternion.Slerp (transform.rotation, rot, Time.deltaTime * rotationSpeed);

		transform.LookAt (target);

		if (distance <= reachDistance) {
			CurrentWayPointID++;

		}

		//Return
		if (CurrentWayPointID >= PathToFollow.path_objs.Count) {
			CurrentWayPointID = 0;
		} 

	}
}
