using UnityEngine;

public class MoveElch : MonoBehaviour
{
    public Transform player;

    public float actionTriggerDistance;
    public float moveSpeed = 1;

    [SerializeField]
    float showDistance;

    Rigidbody rigid;
    float distance;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (distance <= actionTriggerDistance)
        {
            rigid.velocity = transform.right * -moveSpeed;
        }



        distance = Vector3.Distance(transform.position, player.position);

        //Debug.Log(distance);

        showDistance = distance;
    }
}
