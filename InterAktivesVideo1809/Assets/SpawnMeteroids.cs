using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteroids : MonoBehaviour {

    public GameObject meteroid;

    Vector3 spawnPos;

    float xPos;
    float zPos;


    float counter;

    float randomSpawnTime = 0;

	// Update is called once per frame
	void Update () {
        counter += Time.deltaTime;

        spawnPos = new Vector3( xPos, 450, zPos );


        if (counter >= randomSpawnTime)
        {
            Instantiate(meteroid, spawnPos, transform.rotation);

            xPos = Random.RandomRange(-490, 490);
            zPos = Random.RandomRange(-490, 490);

            randomSpawnTime = Random.RandomRange(0.1f, 0.9f);

            counter = 0;
        }
	}
}
