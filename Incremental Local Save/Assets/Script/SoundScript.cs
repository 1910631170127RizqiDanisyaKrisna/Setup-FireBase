using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip Click, Upgrade, notUpgrade ;
    static AudioSource audioSource;
    void Start()
    {
        Click = Resources.Load<AudioClip>("CLICK");
        Upgrade = Resources.Load<AudioClip>("Buying");
        notUpgrade = Resources.Load<AudioClip>("BuyDenied");
        

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
       switch (clip){
        case "Click":
        audioSource.PlayOneShot(Click);
        break;
       }

       switch (clip){
        case "UPGRADE":
        audioSource.PlayOneShot(Upgrade);
        break;
       }

       switch (clip){
        case "notUpgrade":
        audioSource.PlayOneShot(notUpgrade);
        break;
       }

    }
}
