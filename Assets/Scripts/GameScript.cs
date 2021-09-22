using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    GameObject player, canvas;

    [SerializeField] GameObject key1, key2, key3;

    GameObject [] gemTotal;
    public static int gemCont;
    bool keySpawned;
    public static bool keyCollected;
    
    [SerializeField] GameObject derrota, victoria;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GameObject.FindGameObjectWithTag("canvas");
        gemTotal = GameObject.FindGameObjectsWithTag("gem");

        gemCont = 0;
        keySpawned = false;
        keyCollected = false;

    }

    // Update is called once per frame
    void Update()
    {
        IsPlayerDead();
        AllGemsCollected();
        Victory();
    }

    void IsPlayerDead() 
    {
        if (player != null)
        {
            if (player.GetComponent<PlayerHealth>().LifePoints == 0)
            {
                Destroy(player);
                Time.timeScale = 0;
                canvas.gameObject.SetActive(false);
                derrota.gameObject.SetActive(true);
            }
        }
    }

    void AllGemsCollected() 
    {
        if (gemTotal.Length == gemCont && !keySpawned) 
        {
            RandomKey();
            Debug.Log("todas las gemas fueron recolectadas");
            keySpawned = true;
        }
    }

    public static void AddGem() 
    {
        gemCont++;
    }

    public static void CollectKey() 
    {
        keyCollected = true;
    }

    void RandomKey() 
    {
        float rnd = Random.value;

        if (rnd >= 0.0 && rnd <= 0.33)
        {
            Destroy(key2);
            Destroy(key3);
            key1.SetActive(true);
        } 
        else if (rnd >= 0.33 && rnd <= 0.66)
        {
            Destroy(key1);
            Destroy(key3);
            key2.SetActive(true);
        }
        else 
        {
            Destroy(key1);
            Destroy(key2);
            key3.SetActive(true);
        }
    }

    void Victory() 
    {
        if (DoorScript.victory && keyCollected) 
        {
            Destroy(player);
            Time.timeScale = 0;
            canvas.gameObject.SetActive(false);
            victoria.gameObject.SetActive(true);
        }
    }
}
