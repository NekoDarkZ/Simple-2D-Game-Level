using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private float speedEnemy;
    private bool MovLeft = false;


    private void Update()
    {


        if (MovLeft)
        {
            speedEnemy = -2;

        }
        else
        {

            speedEnemy = 2;

        }

        transform.Translate(Vector2.right * speedEnemy * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("borde") && MovLeft == false)
        {
            MovLeft = true;
        }
        else if(other.gameObject.CompareTag("borde") && MovLeft == true)
        {
            MovLeft = false;
        }
    }

}
