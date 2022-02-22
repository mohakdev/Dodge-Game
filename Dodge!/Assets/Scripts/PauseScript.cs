using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseScreen;
    private void Update()
    {
        //If user pressed escape key
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (PauseScreen.activeSelf == true)
            {
                Time.timeScale = 1;
                PauseScreen.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                PauseScreen.SetActive(true);
            }
        }
    }

}
