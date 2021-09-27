using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coinbeh : MonoBehaviour
{ 
    public float hp = 1;
    public float currenthp;
    public float damage = 1;
    public TMP_Text hptext;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void MinusHp()
    {
        currenthp = hp - damage;
        hptext.text = currenthp.ToString();
        if (currenthp == 0)
        {
           Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
