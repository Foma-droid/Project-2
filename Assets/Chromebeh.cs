using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chromebeh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var hits = Physics2D.CircleCastAll(transform.position, 0.35f, Vector2.zero);
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
