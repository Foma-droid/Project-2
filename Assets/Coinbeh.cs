using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coinbeh : MonoBehaviour
{ 
    private float hp = 1;
    public float currenthp;
    public float damage = 1;
    public TMP_Text hptext;

    private float lastTimeHit;
    // Start is called before the first frame update
    void Start()
    {
        
        hptext.text = hp.ToString();
        
    }

    public void MinusHp()
    {
        var currentTime = Time.realtimeSinceStartup;

        if(lastTimeHit == 0 || (currentTime - lastTimeHit > 1f))
        {
            hp --;
            lastTimeHit = currentTime;
        }
        hptext.text = hp.ToString();
        if (hp == 0)
        {
           Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        hptext.text = hp.ToString(); 
    }
}
