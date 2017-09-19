using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonBeh : MonoBehaviour {

    public Transform player;

    [SerializeField]
    float distance;

    public float triggerDistance;
    public float particleDistance = 165.8f;
    public Light pointLight;

    public Transform particleSpawn;
    public GameObject[] instantParts;

    bool spawnParticles;

    public Animator anim;

    bool begin = true;

    bool spawnFirstParticles;
    bool beginFirst = true;


    // Update is called once per frame
    void Update () {
        distance = Vector3.Distance(transform.position, player.position);

        if (distance <= triggerDistance)
        {
            anim.Play("rise");


            pointLight.intensity += Time.deltaTime * 2;


            if (beginFirst)
            {
                spawnFirstParticles = true;
            }

        }

        if (spawnFirstParticles)
        {
            beginFirst = false;
            Instantiate(instantParts[1], particleSpawn.position, instantParts[1].transform.rotation);
            spawnFirstParticles = false;
        }


        if (distance <= particleDistance)
        {
            //call particles
            if (begin)
            {
                spawnParticles = true;
            }
        }

        if (spawnParticles)
        {
            begin = false;
            Instantiate(instantParts[0], particleSpawn.position, instantParts[0].transform.rotation);

            

            spawnParticles = false;
        }
	}
}
