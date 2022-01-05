using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIShowroom : MonoBehaviour
{
    public GameObject wait;
    void Start()
    {
        wait.SetActive(false);
    }

    public void initialIllustration()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("initialIllustration");
    }

    public void back()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("buildings");
    }

}
