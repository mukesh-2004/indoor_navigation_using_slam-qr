using UnityEngine;
using System.Collections;

public class AppController : MonoBehaviour
{
    private void Start()
    {
        // Initialization code
        Debug.Log("Application Starting...");
    }

    private void Update()
    {
        // Main application loop code
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitApplication();
        }
    }

    private void QuitApplication()
    {
        Debug.Log("Application Exiting...");
        Application.Quit();
    }
}