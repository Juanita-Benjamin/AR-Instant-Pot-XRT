using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InstructionSteps : MonoBehaviour
{
    public Image ProgressBar;
    //public GameObject backButton;
    public GameObject doneText;
    public GameObject[] stepsAnimation;
    public GameObject[] stepsText;
    public GameObject instantPotModel;
    public GameObject nextButton;
    public GameObject backButton;
    public int counter = 0;

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

        // Make the pot disappear after the first step.
        if(counter != 0)
        {
            instantPotModel.SetActive(false);
            backButton.SetActive(true);
        }

        //End of the steps so disable the next button.
        if (counter == stepsAnimation.Length - 1)
        {
            nextButton.SetActive(false);
        }
            ScreenMessage.LogForModelTransform(counter.ToString());
    }

    public void Previous()
    {
        //End of the steps so re-enable the next button.
        if (counter == stepsAnimation.Length - 1)
        {
            nextButton.SetActive(true);
        }

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

        // Back at the first step.
        if (counter == 0)
        {
            instantPotModel.SetActive(true);
            backButton.SetActive(false);
        }
        ScreenMessage.LogForModelTransform(counter.ToString());
    }

    public void DoneText()
    {
        doneText.gameObject.SetActive(true);
    }
    
    public void FillUp()
    {
        ProgressBar.fillAmount += 0.09f;
    }

    public void FillDown()
    {
        ProgressBar.fillAmount -= 0.09f;
    }
}
