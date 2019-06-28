using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    public GameObject cloudPrefab;
    float span = 2.0f;
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
            GameObject go = Instantiate(cloudPrefab) as GameObject;
            float py = Random.Range(-4f,4f);
            go.transform.position = new Vector3(11, py, 0);
        }
    }
}
