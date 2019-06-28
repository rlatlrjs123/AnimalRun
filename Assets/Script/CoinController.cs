using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    GameObject player;

    float coinSpeed = 0.5f;

    void Start()
    {
        this.player = GameObject.Find("player");
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //코인이 맵 바깥을 벗어날 때 코인 소멸
        if (transform.position.x < -3)
            Destroy(gameObject);
        //코인을 왼쪽으로 이동
        transform.Translate(coinSpeed * -(Time.deltaTime), 0, 0);

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.1f;
        float r2 = 0.1f;

        if (d < r1 + r2 )
        {
            if (gameObject.tag == "Coin")
            {
                Destroy(gameObject);
                GameObject.Find("GameDirector").GetComponent<GameDirector>().GetCoin();
            }
        }
    }
    //void OnTriggerEnter(Collider c)
    //{
    //    if (c.gameObject.tag == "Coin")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
