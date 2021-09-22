using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RecolectMoney : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Player")
        {   
            CoinsCont.Cont();
            SoundManager.PlaySound("Coins");
            Destroy(gameObject);
        }
    }
}
