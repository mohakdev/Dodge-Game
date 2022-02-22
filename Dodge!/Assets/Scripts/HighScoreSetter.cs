using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreSetter : MonoBehaviour
{
    Text Label;
    // Start is called before the first frame update
    void Start()
    {
        Label = GetComponent<Text>();
    }
    private void Update()
    {
        int Highscore = PlayerPrefs.GetInt("HS", 0);
        Label.text = "HIGHSCORE: " + Highscore.ToString();
    }
}
