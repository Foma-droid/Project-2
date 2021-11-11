using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coinbeh : MonoBehaviour
{ 
    public float hp = 2;
    private spawner _spawner;
    public float damage = 1;
    public TMP_Text hptext;
    private int pole;
    private float lastTimeHit;

    public TextMeshProUGUI count;
    // Start is called before the first frame update
    void Start()
    {
        
        hptext.text = hp.ToString();
        
    }
    
    public void setspawner(spawner s)
    {
        _spawner = s;
        
    }
    public void MinusHp()
    {
        var currentTime = Time.realtimeSinceStartup;

        if(lastTimeHit == 0 || (currentTime - lastTimeHit > 0.2f))
        {
            hp--;
            lastTimeHit = currentTime;
            count.text += 1.ToString();
            
        }
        hptext.text = hp.ToString();
        if (hp == 0)
        {
            _spawner.Remover(this);
           Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        hptext.text = hp.ToString(); 
    }
}
