using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionSteps : MonoBehaviour
{
    public Slider slider;
    //public GameObject backButton;
    public GameObject doneText;
    public GameObject[] stepsAnimation;
    public GameObject[] stepsText;
    public int counter = 0;
    [SerializeField] private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        stepsAnimation[counter].SetActive(true);
        stepsText[counter].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        // Check to see if we're at the end of the array.
        if (counter != stepsAnimation.Length - 1)
        {
            stepsAnimation[counter].SetActive(false);
            stepsAnimation[counter + 1].SetActive(true);

            stepsText[counter].SetActive(false);
            stepsText[counter + 1].SetActive(true);

            counter++;
        }
        else
        {
            // Do nothing.
            Debug.Log("Not valid");
        }
        ScreenMessage.LogForModelTransform(counter.ToString());
    }

    public void Previous()
    {
        //get current position, then deactivate it.
        if (counter != 0)
        {
            stepsAnimation[counter].SetActive(false);
            stepsAnimation[counter - 1].SetActive(true);

            stepsText[counter].SetActive(false);
            stepsText[counter - 1].SetActive(true);

            counter--;
        }
        else
        {
            // Do nothing.
            Debug.Log("Not Invalid!");
        }
        ScreenMessage.LogForModelTransform(counter.ToString());
    }

    public void DoneText()
    {
        doneText.gameObject.SetActive(true);
    }
    
    public void IncreaseBar()
    {
        slider.GetComponent<Slider>();
        slider.value += counter;
    }
}
