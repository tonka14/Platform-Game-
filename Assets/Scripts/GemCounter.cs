using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemCounter : MonoBehaviour
{
    
    public static GemCounter instance;
    public Text GemText;
    public int currentGem= 0;

    public Slider slider;

    public GameObject Fill;
    

    void Awake()
    {
        instance = this;
    }

    public void increaseGems(int v)
    {
        currentGem += v;
        slider.value = currentGem;
        if (currentGem == 10)
        {
            GemsTen();
        }
    }

    public void GemsTen ()
    {
        Fill.GetComponent<Image>().color = Color.green;
    }
    


    

}
