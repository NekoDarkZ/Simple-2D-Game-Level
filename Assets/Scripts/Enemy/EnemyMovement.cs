using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public bool movingLeft;
    



    // Update is called once per frame
    void Update()
    {
        float speed = 2;

        if (movingLeft)
        {
            speed = -1;
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
}
