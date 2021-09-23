using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsCont : MonoBehaviour
{
    public static TextMeshProUGUI textCoins;
    private static int coinsCont;

    // Start is called before the first frame update
    void Start()
    {

        coinsCont = 0;
        textCoins = GameObject.Find("CoinsText").GetComponent<TextMeshProUGUI>();
    }

    
    public static void Cont()
    {
        coinsCont++;
        textCoins.text = coinsCont.ToString();
        
    }
}
