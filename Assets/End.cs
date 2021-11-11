using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public bool isMoving = true;
    public Transform coin;

    private float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2d(Collider2D collision)
    {
        if (collision.CompareTag("Chrome"))
        {
            do
            {
                coin.transform.position = new Vector2(0f, transform.position.y + 5f + Time.deltaTime * speed);
            } while (isMoving = true);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
