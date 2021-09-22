using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{

    public float JumpForceSpring = 2f;
    private bool isCompressed;
    Animator anim;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovement>().jumpSpeed = collision.gameObject.GetComponent<PlayerMovement>().jumpSpeed + JumpForceSpring;
            isCompressed = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerMovement>().jumpSpeed = collision.gameObject.GetComponent<PlayerMovement>().jumpSpeed - JumpForceSpring;
            isCompressed = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        isCompressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Compressed", isCompressed);
    }
}
