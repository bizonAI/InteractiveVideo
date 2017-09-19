using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour {

	private float counter;

	void Update () {
		counter = counter + Time.deltaTime;

		if (counter >= 5) {
			//Application.LoadLevel ("Scene_002");
		}
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.name == "EndPoint") {
			SceneManager.LoadScene ("Scene_001");
		}
	}


}
