using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip audioMoney, audioGems, audioKey,audioPlayer;
    static AudioSource audioGen;


    void Start()
    {

        audioMoney = Resources.Load<AudioClip>("coin_pick"); //Audios en resources
        audioPlayer = Resources.Load<AudioClip>("player_damage");
        audioGems = Resources.Load<AudioClip>("gem_pick");
        audioGen = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {

        switch(clip){
            case "Coins":

                audioGen.PlayOneShot(audioMoney);
                break;
            case "Player":
                audioGen.PlayOneShot(audioPlayer);
                break;

            case "Gem":
                audioGen.PlayOneShot(audioGems);
                break;
        }

    }
}
