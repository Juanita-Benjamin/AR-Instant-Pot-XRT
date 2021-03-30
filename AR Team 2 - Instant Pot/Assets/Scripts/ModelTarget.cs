using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelTarget : MonoBehaviour
{
    Vector3 modelTargetPlacedPostition;

    [Tooltip("The button we use for making the Instant Pot stationary.")]
    public Button placeButton;

    // Start is called before the first frame update
    void Start()
    {
        placeButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    { 
        //ScreenMessage.LogForModelTransform(transform.position.ToString());
    }

    public void EnablePlacePotButton()
    {
        ScreenMessage.Log("In EnablePlacePotButton()");
        placeButton.interactable = true;
        ScreenMessage.Log("position for enable: " + transform.position.ToString());

    }

    public void PlacePot()
    {
        ScreenMessage.Log("In PlacePot()");
        ScreenMessage.Log("position: " + this.transform.position.ToString());

        modelTargetPlacedPostition = transform.position;

        ScreenMessage.Log("SAVED position: " + this.modelTargetPlacedPostition);

    }

    void FixedUpdate()
    {
        ScreenMessage.LogForModelTransform("position: " + '\n' + transform.position.ToString() + '\n' + "SAVED position: " + '\n' + modelTargetPlacedPostition);

        if (modelTargetPlacedPostition != transform.position)
        {
            transform.position = modelTargetPlacedPostition;
            ScreenMessage.LogForModelTransform("don't equal");

        }
    }
}
