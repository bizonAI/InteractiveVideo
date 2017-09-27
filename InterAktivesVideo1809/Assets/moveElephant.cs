using UnityEngine;

public class moveElephant : MonoBehaviour {

    Rigidbody rigid;
    float distance;

    public Transform player;

    public float triggerDistance;
    public float actionTriggerDistance;

    [SerializeField]
    float showDistance;

    public Animator anim;

    bool troeten;

    public float moveSpeed = 1;

	void Start () {
        rigid = GetComponent<Rigidbody>();	
	}
	
	void Update () {

        if (distance <= actionTriggerDistance)
        {
            rigid.velocity = transform.right * -moveSpeed;
        }
        


        distance = Vector3.Distance(transform.position, player.position);

        //Debug.Log(distance);

        showDistance = distance;

        if (distance <= triggerDistance)
        {
            //Play kranke Animation
            anim.Play("Tröten");

            troeten = true;
            
        }
        else
        {
            troeten = false;
        }

        anim.SetBool("tröten", troeten);

    }
}
