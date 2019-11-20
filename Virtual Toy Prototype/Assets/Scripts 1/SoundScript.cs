using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip bomb;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<AudioClip>("explode");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public static void playSound(string clip)
    {
        print("sonido");

        switch (clip)
        {
            case "explode":
                audioSrc.PlayOneShot(bomb);
                break;
        }
    }
}
