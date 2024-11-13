using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
   
    void Update()
    {
        gameObject.transform.position += transform.forward * speed * Time.deltaTime;
        if (Math.Abs(gameObject.transform.position.x) > 10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            GameManager.Instance.GameOver();
        }
    }
}
