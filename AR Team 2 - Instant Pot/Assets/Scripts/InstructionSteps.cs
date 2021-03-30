using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionSteps : MonoBehaviour
{
    //public GameObject backButton;
    public GameObject doneText;
    
    public GameObject[] steps;

    public int counter = 0;

    [SerializeField] private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        
        if ( counter <= steps.Length - 1)
        {
            steps[counter].SetActive(true);
        }
        
        else
        {
            Debug.Log("NOt valid");
        }
        counter++;
    }

    public void Previous()
    {
        counter--;
        if (counter <= 0)
        {
            counter = 0;
        }

        //get current position, then deactivate it.
        if (counter != 0)
        {
            steps[counter - 1].SetActive(false);
        }

        else
        {
            Debug.Log("Not Invalid!");
        }
        
        

    }

    public void DoneText()
    {
        doneText.gameObject.SetActive(true);
    }

}
