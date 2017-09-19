using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startTheGame : MonoBehaviour {

    public void GameStart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene_001");
    }
}
