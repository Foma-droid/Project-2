using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Chromebeh : MonoBehaviour
{
    private Input m_PlayerInput;
    public Vector2 worldscreen; 
    private bool isk = true;
    private Rigidbody2D rb;
    public bool canshoot = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void Dynamic()
    {
        Vector2 mousePosition =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 actscreen = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        rb.simulated = true;
            rb.AddForce(actscreen*800f);
           
    }

    public void Kinematic()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }
    // Update is called once per frame
    void Update()
    {
        var hits = Physics2D.CircleCastAll(transform.position, 0.5f, Vector2.zero);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider.CompareTag("Coin"))
            {
                hits[i].transform.GetComponent<Coinbeh>().MinusHp();
               
            }

            
        }
        
    }
    public void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 0.45f);
    }
}
