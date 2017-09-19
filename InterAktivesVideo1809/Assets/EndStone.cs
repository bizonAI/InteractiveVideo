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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.position);


        if (distance <= triggerDistance && !spawn)
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
