using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpSpeed;
  

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
   
    }

    // Start is called before the first frame update
    void Start()
    {
        

       
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            rb.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            rb.velocity = new Vector2(- movementSpeed * Time.fixedDeltaTime, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
}
