using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstcleGenerator : MonoBehaviour
{
    public GameObject swordPrefab;
    float span = 1f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(swordPrefab) as GameObject;
            float py = Random.Range(-0.75f, 0.9f);
            go.transform.position = new Vector3(7, py, 0);
        }
    }

}