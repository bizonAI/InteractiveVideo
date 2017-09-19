using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour {

    public GameObject destroyedVersion;

    Rigidbody rigid;

    float movementSpeed;
    float rndFor;
    float rndSide;

    public ParticleSystem particle;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();

        movementSpeed = Random.RandomRange(30, 80);

        rndFor = Random.RandomRange(-10, 10);
        rndSide = Random.RandomRange(-10, 10);
    }

    private void Update()
    {
        rigid.velocity =  (transform.forward * rndFor) + (transform.right * rndSide) + transform.up * -movementSpeed;

        //rigid.velocity = transform.right * 3;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 2)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            //Destroy(gameObject);
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<SphereCollider>().enabled = false;

            particle.GetComponent<ParticleSystem>().enableEmission = false; ;

            Destroy(gameObject, 3);
        }
    }
}
