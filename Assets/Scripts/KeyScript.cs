using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            GameScript.CollectKey();
            SoundManager.PlaySound("Key");
            Destroy(gameObject);
        }
    }
}
