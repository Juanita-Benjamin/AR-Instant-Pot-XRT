using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadARScene()
    {
        SceneManager.LoadScene("ARScene v1.9");
    }
}
