using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class user : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "marketplace")
        {
            SceneManager.LoadScene("marketplace");
        }
        else if(other.gameObject.tag == "showroom")
        {
            SceneManager.LoadScene("showroom");
        }
        else if(other.gameObject.tag == "training")
        {
            SceneManager.LoadScene("training");
        }
    }
}
