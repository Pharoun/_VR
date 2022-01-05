using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMarketplace : MonoBehaviour
{
    public GameObject wait;
    public GameObject buildings;
    public GameObject showroom;
    public GameObject training;
    bool third = false;
    void Start()
    {
        wait.SetActive(false);
    }

    public void back()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("buildings");
    }

    public void eCommerce()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("eCommerce");
    }

    public void thirdPerson()
    {

        third = !third;

        if (third)
        {
            hideTraining();
            hideShowroom();
            showBuildings();
        }
        else
        {
            hideBuildings();
            hideTraining();
            hideShowroom();
        }
    }

    public void trainingMenu()
    {
        hideShowroom();
        showTraining();
    }

    public void showroomMenu()
    {
        hideTraining();
        showShowroom();
    }

    void showBuildings()
    {
        buildings.SetActive(true);
    }

    void hideBuildings()
    {
        buildings.SetActive(false);
    }

    void showTraining()
    {
        training.SetActive(true);
    }

    void hideTraining()
    {
        training.SetActive(false);
    }

    void showShowroom()
    {
        showroom.SetActive(true);
    }

    void hideShowroom()
    {
        showroom.SetActive(false);
    }

}
