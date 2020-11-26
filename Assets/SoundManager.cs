using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour

{

    public static AudioClip  coinSound, gameOverSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
       
        gameOverSound = Resources.Load<AudioClip> ("game_over_17");
        coinSound = Resources.Load<AudioClip> ("coin_04");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "gameOver":
                audioSrc.PlayOneShot(gameOverSound);
                break;
            case "coin":
                audioSrc.PlayOneShot(coinSound);
                break;
        }
    }
}
