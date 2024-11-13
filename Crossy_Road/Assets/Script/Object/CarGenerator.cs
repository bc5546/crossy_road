using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public float minTime;
    public float maxTime;
    public float lastTime;
    private float randomTime;
    // Start is called before the first frame update
    void Start()
    {
        lastTime = Time.time;
        RandomTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastTime + randomTime) 
        {
            lastTime = Time.time;
            RandomTime();
            Instantiate(carPrefab,gameObject.transform.position,gameObject.transform.rotation,null);
        }
    }

    void RandomTime()
    {
        randomTime = Random.Range(minTime, maxTime);
    }
}
