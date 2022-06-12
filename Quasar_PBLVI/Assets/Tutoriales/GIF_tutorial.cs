using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GIF_tutorial : MonoBehaviour
{
    public Sprite[] animatedImages;
    public Image animatedImageObj;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animatedImageObj.sprite = animatedImages[(int)(Time.time * 1) % animatedImages.Length];
    }
}
