using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class setPlayerName : MonoBehaviour
{
    public TextMeshProUGUI inputfiled;
    public TextMeshProUGUI placeholder;

    public string textinfiled;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkName()
    {
        textinfiled = inputfiled.text;
        Debug.Log(textinfiled);
        if(inputfiled.text.Length > 1)
        {
            PlayerPrefs.SetString("PlayerName", textinfiled);
            SceneManager.LoadScene("2 Game Screen");
        }
        else
        {
            placeholder.text = "Please enter your Name";
        }
    }
}
