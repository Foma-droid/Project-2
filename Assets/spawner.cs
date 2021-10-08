using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private Vector2[] points = new Vector2[]
    {
        new Vector2(-2.56f, y: -4.49f),
        new Vector2(-1.42f, -4.54f),
        new Vector2(-0.47f, -4.43f),
    };
    private void DoSpawn()
    {
        int index = Random.Range(0, 5);
        GameObject go = Instantiate(coin, points[index], Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
