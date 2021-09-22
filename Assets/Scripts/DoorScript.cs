using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    public static bool victory;
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player" && GameScript.keyCollected)
        {
            victory = true;
        }
    }
}
