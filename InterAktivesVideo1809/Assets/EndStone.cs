using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndStone : MonoBehaviour
{

    public GameObject metero;
    public GameObject brokenStone;

    public Transform player;

    [SerializeField]
    float distance;
    public float triggerDistance = 100;

    bool spawn = false;

    float counter;

    void Update()
    {
        counter += Time.deltaTime;

        distance = Vector3.Distance(transform.position, player.position);


        if (distance <= triggerDistance && !spawn && counter >= 20)
        {
            spawn = true;
            Instantiate(metero, new Vector3(377.4f, 258.7f, 153.0f), metero.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "endMeteo(Clone)")
        {
            Instantiate(brokenStone, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
