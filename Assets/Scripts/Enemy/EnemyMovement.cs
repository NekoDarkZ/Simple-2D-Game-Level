using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float speedEnemy;
    public bool MovLeft;

    private void Update()
    {


        if (MovLeft)
        {
            speedEnemy = -1;

        }
        else
        {

            speedEnemy = 1;

        }

        transform.Translate(Vector2.right * speedEnemy * Time.deltaTime);
    }

}
