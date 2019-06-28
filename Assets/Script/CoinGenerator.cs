using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject CoinPrefab;
    float span = 0.3f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(CoinPrefab) as GameObject;
            float py = Random.Range(-0.9f, 0.7f);
            go.transform.position = new Vector3(3, py, 0);
        }
    }
}
