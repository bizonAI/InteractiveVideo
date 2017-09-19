using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour {

    public string sceneName;
    public float sceneTime;

    //public GameObject changePlane;

    float sceneTimeCounter;

	void Update () {
        sceneTimeCounter += Time.deltaTime;

		if (sceneTimeCounter >= sceneTime || Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene(sceneName);
        }

        /*
        if (sceneTimeCounter >= sceneTime - 6.0f)
        {
            changePlane.SetActive(true);

            if (changePlane.transform.rotation.x >= -90)
            {
                changePlane.transform.Rotate(Vector3.left * Time.deltaTime *20);
            }
        }
        */

	}
}
