using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endMeteo : MonoBehaviour {

   
    Rigidbody rigid;
    public ParticleSystem particle;
    public GameObject destroyedVersion;

    void Start () {
        rigid = GetComponent<Rigidbody>();

        rigid.velocity = transform.up * -80;
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
