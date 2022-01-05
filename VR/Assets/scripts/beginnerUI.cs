using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class beginnerUI : MonoBehaviour
{

    public GameObject wait;
    public GameObject panel2;
    bool panel2Shown;
    void Start()
    {
        wait.SetActive(false);
        panel2.SetActive(false);
    }

    public void togglePanel2()
    {
        panel2Shown = !panel2Shown;

        if(panel2Shown)
            panel2.SetActive(false);
        else
            panel2.SetActive(true);
    }

    public void buildings()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("buildings");
    }

}
