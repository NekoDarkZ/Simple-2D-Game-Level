using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedScript : MonoBehaviour
{

    public Sprite[] ani;
    public Image animatedImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animatedImage.sprite = ani[(int)(Time.unscaledTime * 10) % ani.Length];
    }
}
