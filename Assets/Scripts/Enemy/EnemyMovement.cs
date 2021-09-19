using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public bool movingLeft;

    public float strenght;



    // Update is called once per frame
    void Update()
    {
        float speed = 0;

        if (movingLeft)
        {
            speed = -1;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            speed = 1;
            
            GetComponent<SpriteRenderer>().flipX = true;
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        EdgeCheck check = other.gameObject.GetComponent<EdgeCheck>();
        if (check != null)
        {
        
            movingLeft = !check.isBound;
        }
    }
}
