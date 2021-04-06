using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillBar : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    void Start()
    {
        
    }

  
    // Update is called once per frame
    void Update()
    {
        slider.value = 0;
    }

    public void Fill()
    {
        slider.GetComponent<Slider>();
        
        slider.value += 0.5f;
    }
}
