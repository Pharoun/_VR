using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public void playSound()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
