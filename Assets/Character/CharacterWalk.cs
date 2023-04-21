using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWalk : MonoBehaviour
{
    Animator animator;
    [SerializeField] float desiredwalkspeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float walkdistanceonframe = desiredwalkspeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if(vertical > 0)
        {
            animator.SetInteger("direction", 2);
            transform.Translate(0,walkdistanceonframe,0);
        } else if (vertical < 0)
        {
            animator.SetInteger("direction", 0);
            transform.Translate(0,-walkdistanceonframe,0);
        } else if (horizontal > 0)
        {
            animator.SetInteger("direction", 3);
            transform.Translate(walkdistanceonframe,0,0);
        } else if (horizontal < 0)
        {
            animator.SetInteger("direction", 1);
            transform.Translate(-walkdistanceonframe,0,0);
        }

    }
}
