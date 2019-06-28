using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagDirector : MonoBehaviour
{
    GameObject player;

    float flagSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(flagSpeed * -(Time.deltaTime), 0, 0);

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;

        float d = dir.magnitude; 
        float r1 = 0.1f;
        float r2 = 0.1f;

        //깃발에 도달하지 못하고 깃발이 맵 바깥으로 나가면 게임오버 씬으로 변경
        if (transform.position.x < -3)
        {
            SceneManager.LoadScene("GameOverScene");
        }
        if (d < r1 + r2 /*|| d1 < r1 + r2 || d2 < r1 + r2*/)
        {
            SceneManager.LoadScene("ClearScene");
            Debug.Log("Stage Clear!");
        }
    }
}