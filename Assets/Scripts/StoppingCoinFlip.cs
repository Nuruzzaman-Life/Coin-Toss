using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoppingCoinFlip : MonoBehaviour
{
    public AudioSource onAirSound;
    public AudioSource onTableSound;
    public void StopCoinFlip(){
        FindObjectOfType<CoinFunction>().StopFlip();
    }
    public void UpdateTossResult(){
        FindObjectOfType<CoinFunction>().ShowResult();
    }
    public void PlayOnAirSound(){
        onAirSound.GetComponent<AudioSource>().Play();
    }
    public void PlayOnTableSound(){
        onTableSound.GetComponent<AudioSource>().Play();
    }
}
