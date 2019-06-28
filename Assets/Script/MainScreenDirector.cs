using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainScreenDirector : MonoBehaviour
{
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene("AnimalChoiceScene");
        Debug.Log("Start Game ! ");
    }
    public void InfoButton()
    {
        SceneManager.LoadScene("AnimalInfoScene");
    }
    public void ExitButton()
    {
            Application.Quit();
            Debug.Log("Quit Game...");
    }
    public void BackSpaceButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void SelectCat()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void SelectHedgehog()
    {
        SceneManager.LoadScene("HedgehogScene");
    }
    public void SelectRabbit()
    {
        SceneManager.LoadScene("RabbitScene");
    }
}
