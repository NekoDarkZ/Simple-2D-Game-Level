using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    GameObject player, canvas;

    GameObject [] gemTotal;
    public static int gemCont;
    bool keySpawned;
    
    [SerializeField] GameObject derrota, victoria;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        canvas = GameObject.FindGameObjectWithTag("canvas");
        gemTotal = GameObject.FindGameObjectsWithTag("gem");
        gemCont = 0;
        keySpawned = false;

    }

    // Update is called once per frame
    void Update()
    {
        IsPlayerDead();
        AllGemsCollected();
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
            //spawnea la llave random
            Debug.Log("todas las gemas fueron recolectadas");
            keySpawned = true;
        }
    }

    public static void AddGem() 
    {
        gemCont++;
    }
}
