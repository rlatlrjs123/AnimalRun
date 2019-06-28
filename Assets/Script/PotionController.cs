using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionController : MonoBehaviour
{
    GameObject player;

    float potionSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(potionSpeed * -(Time.deltaTime), 0, 0);

        if (transform.position.x < -3)
            Destroy(gameObject);

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.1f;
        float r2 = 0.1f;

        if (d < r1 + r2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().IncreaseHp();

            Debug.Log("+10 HP");
            Destroy(gameObject);
        }
    }
}
