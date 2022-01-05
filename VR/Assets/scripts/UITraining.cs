using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UITraining : MonoBehaviour
{
    public GameObject wait;
    public GameObject ConfirmationPanel;
    public GameObject SkillsPanel;
    public GameObject TrainingPanel;
    public GameObject ContinuousPanel;
    void Start()
    {
        wait.SetActive(false);
        hideAllPanels();
    }

    public void selfManagement()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("selfManagement");
    }

    public void challengesOvercome()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("challengesOvercome");
    }

    public void back()
    {
        wait.SetActive(true);
        SceneManager.LoadScene("buildings");
    }

    public void showConfirmation()
    {
        hideAllPanels();
        ConfirmationPanel.SetActive(true);
    }

    public void showSkills()
    {
        hideAllPanels();
        SkillsPanel.SetActive(true);
    }

    public void showTraining()
    {
        hideAllPanels();
        TrainingPanel.SetActive(true);
    }

    public void showContinuous()
    {
        hideAllPanels();
        ContinuousPanel.SetActive(true);
    }

    void hideAllPanels()
    {
        ConfirmationPanel.SetActive(false);
        SkillsPanel.SetActive(false);
        TrainingPanel.SetActive(false);
        ContinuousPanel.SetActive(false);
    }

}
