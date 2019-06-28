using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionGenerator : MonoBehaviour
{
    public GameObject PotionPrefab;
    float span = 10.0f;
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
            GameObject go = Instantiate(PotionPrefab) as GameObject;
            float py = Random.Range(-0.9f, 0.7f);
            go.transform.position = new Vector3(3, py, 0);
        }
    }
}
