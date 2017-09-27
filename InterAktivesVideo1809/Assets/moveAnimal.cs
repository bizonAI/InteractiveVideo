using UnityEngine;

public class moveAnimal : MonoBehaviour {

    Rigidbody rigid;
    float distance;

    public Transform player;

    public float triggerDistance;

    [SerializeField]
    float showDistance;

    public Animator anim;

    bool troeten;


    public float moveSpeed = 1;

	void Start () {
        rigid = GetComponent<Rigidbody>();	
	}
	
	void Update () {
        rigid.velocity = transform.right * -moveSpeed;


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
