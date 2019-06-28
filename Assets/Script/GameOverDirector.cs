using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverDirector : MonoBehaviour
{
    GameObject player;

    float animalSpeed = 2f;
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.player.transform.Translate(animalSpeed * Time.deltaTime, 0, 0);

        if (this.player.transform.position.x > 12)
        {
            SceneManager.LoadScene("MainScene");
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
