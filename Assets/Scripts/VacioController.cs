using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacioController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            other.gameObject.GetComponent<PlayerHealth>().LifePoints = 0;
        }
    }
}
