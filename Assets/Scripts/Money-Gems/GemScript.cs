using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemScript : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {
            GameScript.AddGem();
            SoundManager.PlaySound("Gem");
            Destroy(gameObject);
        }
    }
}
