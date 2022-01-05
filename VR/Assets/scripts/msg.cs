using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class msg : MonoBehaviour
{

    public GameObject notification;

    void Start()
    {
        notification.SetActive(true);
    }

    public void close()
    {
        notification.SetActive(false);
    }

    public void back()
    {
        SceneManager.LoadScene("buildings");
    }

}
