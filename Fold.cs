using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fold : MonoBehaviour
{

    RectTransform menu;
    bool folded;
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out menu);
    }

    // Update is called once per frame
    void Update()
    {        
        if(!menu) {
            return;
        }
        float r = (float) Screen.height / (float) Screen.width;
        folded = r > 0.3f && r < 0.8f;
        if(folded) {
            menu.anchorMax = new Vector2(0, 1);
            menu.pivot = new Vector2(0, 0.5f);
            menu.sizeDelta = new Vector2(300, 0);
        }
        else {
            menu.anchorMax = new Vector2(1, 0);
            menu.pivot = new Vector2(0.5f, 0);
            menu.sizeDelta = new Vector2(0, 300);
        }
    }

}